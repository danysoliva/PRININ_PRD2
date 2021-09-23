using DevExpress.XtraEditors;
using PRININ.Notas_UNITE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRININ.DEV
{
    public partial class frmGenerateXML : DevExpress.XtraEditors.XtraForm
    {
        public frmGenerateXML()
        {
            InitializeComponent();
            memoEdit1.Text = ToXml(dsNotasUNITE1.detalle_nota_print,0);
        }

        public static string ToXml(dsNotasUNITE.detalle_nota_printDataTable table, int metaIndex = 0)
        {
            XDocument xdoc = new XDocument(new XElement(table.TableName,
                                                        from column in table.Columns.Cast<DataColumn>()
                                                        where column != table.Columns[metaIndex]
                                                        select new XElement(column.ColumnName,
                                                        from row in table.AsEnumerable()
                        select new XElement(row.Field<string>(metaIndex), row[column])
                        )
                    )
                );
            
            return xdoc.ToString();
        }
    }
}
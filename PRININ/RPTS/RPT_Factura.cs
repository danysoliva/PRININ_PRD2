using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using PRININ.Classes;

namespace PRININ.RPTS
{
    public partial class RPT_Factura : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;

        public RPT_Factura(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
            //lblRegexo.Text = pRegistroExo;
           
            foreach (DataRow data in ds.Tables["header"].Rows)
            {
                Functions fn = new Functions();
                string codigo = data[9].ToString().ToUpper() + "-" +
                                  fn.QuitSpecialChar(data["customer_long_name"].ToString().ToUpper()) + "-" +
                                  fn.QuitSpecialChar(data[34].ToString().ToUpper()) + "-" +
                                  fn.QuitSpecialChar(data[37].ToString().ToUpper()) + "-" +
                                  fn.QuitSpecialChar(data[39].ToString().ToUpper());
                
                BarCodeFac.Text = codigo;
            }
            //BarCodeFac.Text = lblFactura.Text + "*" + lblCliente.Text + "*" + lblDestino.Text + "*" + lblDireccion.Text;
        }
    }
}

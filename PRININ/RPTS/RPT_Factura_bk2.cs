using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PRININ.RPTS
{
    public partial class RPT_Factura_bk2 : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;

        public RPT_Factura_bk2(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
           
            foreach (DataRow data in ds.Tables["header"].Rows)
            {
                BarCodeFac.Text = data[9].ToString().ToUpper() + "-" + 
                                  data["customer_long_name"].ToString().ToUpper() + "-" + 
                                  data[34].ToString().ToUpper() + "-" +
                                  data[37].ToString().ToUpper();
            }
            //BarCodeFac.Text = lblFactura.Text + "*" + lblCliente.Text + "*" + lblDestino.Text + "*" + lblDireccion.Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Localization;
using PRININ.Compras;
using PRININ.Notas;
using PRININ.Classes;
using PRININ.Mantenimiento;
using PRININ.Pedidos;
using PRININ.Factura;
using PRININ.Retencion;

namespace PRININ
{
    public partial class frmMenuPrinin : DevExpress.XtraEditors.XtraForm
    {
        DBOperations dp = new DBOperations();
        public Users UsuarioLogueado;

        string theme;
        public frmMenuPrinin(Users pUserLogin, string Theme)
        {
            Users us;
            InitializeComponent();
            //comentario
            UsuarioLogueado = pUserLogin;
            this.theme = Theme;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //invoice_OptionsPrint form = new invoice_OptionsPrint();
            //form.Show();

            if (UsuarioLogueado.ValidarNivelPermisos(1))
            {
                invoice_OptionsPrint form = new invoice_OptionsPrint();
                form.Show();
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta funcion! Permiso Requerido #1");
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //frmNewNota form = new frmNewNota();
            //form.Show();

            if (UsuarioLogueado.ValidarNivelPermisos(2))
            {
                frmNewNota form = new frmNewNota();
                form.Show();
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta funcion! Permiso Requerido #2");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //LayoutLocalizer.Active = new LayoutLocalizer();
            //SimpleButton btnSender = (SimpleButton)sender;
            //Point ptLowerLeft = new Point(0, btnSender.Height);
            //ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            //contextMenuStrip1.Show(ptLowerLeft);

            if (UsuarioLogueado.ValidarNivelPermisos(4))
            {
                LayoutLocalizer.Active = new LayoutLocalizer();
                SimpleButton btnSender = (SimpleButton)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                contextMenuStrip1.Show(ptLowerLeft);
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta funcion! Permiso Requerido #4");
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            //frmCheques form = new frmCheques();
            //form.Show();

            if (UsuarioLogueado.ValidarNivelPermisos(5))
            {
                frmCheques form = new frmCheques();
                form.Show();
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta funcion! Permiso Requerido #5");
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Facturas
            Invoice_Re_Print form = new Invoice_Re_Print();
            form.Show();
        }

        private void notasCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Notas Credito
            ND_NC_OptionsPrint form = new ND_NC_OptionsPrint("NC");
            form.Show(); 
        }

        private void cmdOrdenesCompra_Click(object sender, EventArgs e)
        {
            //frmOrdenesC frm = new frmOrdenesC();
            //frm.Show();

            if (UsuarioLogueado.ValidarNivelPermisos(6))
            {
                frmOrdenesC frm = new frmOrdenesC();
                frm.Show();
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta funcion! Permiso Requerido #6");
            }

        }

        private void cmdRptsNotas_Click(object sender, EventArgs e)
        {
            //RPTSNotasDC frm = new RPTSNotasDC();
            //frm.Show();

            if (UsuarioLogueado.ValidarNivelPermisos(8))
            {
                RPTSNotasDC frm = new RPTSNotasDC();
                frm.Show();
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta funcion! Permiso Requerido #8");
            }
        }

        private void cmdResumenNotas_Click(object sender, EventArgs e)
        {
            //frmNotaD form = new frmNotaD();
            //form.Show();

            if (UsuarioLogueado.ValidarNivelPermisos(3))
            {
                frmNotaD form = new frmNotaD();
                form.Show();
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta funcion! Permiso Requerido #3");
            }
        }

        private void cmdMantenimiento_Click(object sender, EventArgs e)
        {
            frmMant frm = new frmMant(UsuarioLogueado);
            frm.Show();

            //if (UsuarioLogueado.ValidarNivelPermisos(9))
            //{
            //    frmMant frm = new frmMant(UsuarioLogueado);
            //    frm.Show();
            //}
            //else
            //{
            //    CajaDialogo.Error("No tiene privilegios para esta funcion! Permiso Requerido #9");
            //}
        }

        private void cmdPedidos_Click(object sender, EventArgs e)
        {
            //frmPedidos frm = new frmPedidos();
            //frm.Show();

            if (UsuarioLogueado.ValidarNivelPermisos(7))
            {
                frmPedidos frm = new frmPedidos();
                frm.Show();
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta funcion! Permiso Requerido #7");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmHomeFacturas frm = new frmHomeFacturas(this.theme);
            
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            frmNotaD_UNITE frm = new frmNotaD_UNITE(this.theme);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnComprobanteRetencion_Click(object sender, EventArgs e)
        {
            xfrmRetencion frm = new xfrmRetencion(this.theme,UsuarioLogueado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
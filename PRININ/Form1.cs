﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRININ
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private bool allowVisible = true;
        private bool allowClose;
        private bool menuallowvisible = true;

        public Form1()
        {
            InitializeComponent();
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            this.mostrarOpcionesToolStripMenuItem.Click += mostrarOpcionesToolStripMenuItem_Click;
            this.salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            this.ocultarOpcionesToolStripMenuItem.Click += ocultarOpcionesToolStripMenuItem_Click;
            rd_menu.ShowPopup(new Point((this.Width-50), (this.Height-50)));
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
            allowVisible = false;
            base.SetVisibleCore(allowVisible);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                this.Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }

        private void mostrarOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuallowvisible = true;
            //Show();
            rd_menu.ShowPopup(new Point((this.Width / 2), (this.Height / 2)));
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowClose = true;
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rd_menu.ShowPopup(new Point((this.Width / 2), (this.Height / 2)));
        }

        private void ocultarOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuallowvisible = false;
            rd_menu.HidePopup();
        }

        private void rd_menu_CloseUp(object sender, EventArgs e)
        {
            if (menuallowvisible == true)
                rd_menu.ShowPopup(new Point((this.Width / 2), (this.Height / 2)));
        }

        private void btn_CloseInterface_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            allowClose = true;
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (menuallowvisible == true)
            {
                menuallowvisible = false;
                rd_menu.HidePopup();
            }
            else 
            {
                menuallowvisible = true;
                rd_menu.ShowPopup(new Point((this.Width / 2), (this.Height / 2)));
            }
        }

        private void btn_inv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            menuallowvisible = false;
            rd_menu.HidePopup();
            invoice_OptionsPrint form = new invoice_OptionsPrint();
            form.Show();
        }

        private void btn_DebitNotes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            menuallowvisible = false;
            rd_menu.HidePopup();
            ND_NC_OptionsPrint form = new ND_NC_OptionsPrint("ND");
            form.Show(); 
        }

        private void btn_creditNOtes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            menuallowvisible = false;
            rd_menu.HidePopup();
            ND_NC_OptionsPrint form = new ND_NC_OptionsPrint("NC");
            form.Show(); 
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            allowClose = true;
            Application.Exit();
        }

        private void btn_InvoiceRePrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            menuallowvisible = false;
            rd_menu.HidePopup();
            Invoice_Re_Print form = new Invoice_Re_Print();
            form.Show();
        }

        private void btn_NCNDRePrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            menuallowvisible = false;
            rd_menu.HidePopup();
            ND_NC_OptionsPrint form = new ND_NC_OptionsPrint("NC");
            form.Show(); 
        }

        private void cmdCheques_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            menuallowvisible = false;
            rd_menu.HidePopup();
            frmCheques form = new frmCheques();
            form.Show(); 
        }
    }
}

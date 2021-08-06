namespace PRININ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_invoice = new DevExpress.XtraBars.BarButtonItem();
            this.btn_nd = new DevExpress.XtraBars.BarButtonItem();
            this.btn_nc = new DevExpress.XtraBars.BarButtonItem();
            this.btn_close = new DevExpress.XtraBars.BarButtonItem();
            this.btn_inv = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DebitNotes = new DevExpress.XtraBars.BarButtonItem();
            this.btn_creditNOtes = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CloseInterface = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btn_InvoiceRePrint = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NCNDRePrint = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CloseProgram = new DevExpress.XtraBars.BarButtonItem();
            this.cmdCheques = new DevExpress.XtraBars.BarButtonItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rd_menu = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rd_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_invoice,
            this.btn_nd,
            this.btn_nc,
            this.btn_close,
            this.btn_inv,
            this.btn_DebitNotes,
            this.btn_creditNOtes,
            this.btn_CloseInterface,
            this.barButtonItem1,
            this.barSubItem1,
            this.btn_InvoiceRePrint,
            this.btn_NCNDRePrint,
            this.btn_CloseProgram,
            this.cmdCheques});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 14;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(120, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 0);
            this.barDockControlBottom.Size = new System.Drawing.Size(120, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(120, 20);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 0);
            // 
            // btn_invoice
            // 
            this.btn_invoice.Caption = "Facturas";
            this.btn_invoice.Id = 0;
            this.btn_invoice.Name = "btn_invoice";
            // 
            // btn_nd
            // 
            this.btn_nd.Caption = "Notas de Débito";
            this.btn_nd.Id = 1;
            this.btn_nd.Name = "btn_nd";
            // 
            // btn_nc
            // 
            this.btn_nc.Caption = "Notas de Crédito";
            this.btn_nc.Id = 2;
            this.btn_nc.Name = "btn_nc";
            // 
            // btn_close
            // 
            this.btn_close.Caption = "Cerrar Interfaz";
            this.btn_close.Id = 3;
            this.btn_close.Name = "btn_close";
            // 
            // btn_inv
            // 
            this.rd_menu.SetAutoSize(this.btn_inv, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_inv.Caption = "Facturas";
            this.btn_inv.Id = 4;
            this.btn_inv.LargeGlyph = global::PRININ.Properties.Resources.invoice_321;
            this.btn_inv.Name = "btn_inv";
            this.btn_inv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_inv_ItemClick);
            // 
            // btn_DebitNotes
            // 
            this.rd_menu.SetAutoSize(this.btn_DebitNotes, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_DebitNotes.Caption = "Notas de Débito";
            this.btn_DebitNotes.Id = 5;
            this.btn_DebitNotes.LargeGlyph = global::PRININ.Properties.Resources.debitnote_32;
            this.btn_DebitNotes.Name = "btn_DebitNotes";
            this.btn_DebitNotes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DebitNotes_ItemClick);
            // 
            // btn_creditNOtes
            // 
            this.rd_menu.SetAutoSize(this.btn_creditNOtes, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_creditNOtes.Caption = "Notas de Crédito";
            this.btn_creditNOtes.Id = 6;
            this.btn_creditNOtes.LargeGlyph = global::PRININ.Properties.Resources.creditnote_32;
            this.btn_creditNOtes.Name = "btn_creditNOtes";
            this.btn_creditNOtes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_creditNOtes_ItemClick);
            // 
            // btn_CloseInterface
            // 
            this.rd_menu.SetAutoSize(this.btn_CloseInterface, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.btn_CloseInterface.Caption = "Cerrar Interfaz";
            this.btn_CloseInterface.Id = 7;
            this.btn_CloseInterface.LargeGlyph = global::PRININ.Properties.Resources.close_32;
            this.btn_CloseInterface.Name = "btn_CloseInterface";
            this.btn_CloseInterface.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_CloseInterface_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSubItem1
            // 
            this.rd_menu.SetAutoSize(this.barSubItem1, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.barSubItem1.Caption = "Reimpresión";
            this.barSubItem1.Glyph = global::PRININ.Properties.Resources.print_32;
            this.barSubItem1.Id = 9;
            this.rd_menu.SetItemAutoSize(this.barSubItem1, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Spring);
            this.barSubItem1.LargeGlyph = global::PRININ.Properties.Resources.print_32;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_InvoiceRePrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_NCNDRePrint)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btn_InvoiceRePrint
            // 
            this.btn_InvoiceRePrint.Caption = "Facturas";
            this.btn_InvoiceRePrint.Glyph = global::PRININ.Properties.Resources.invoice_321;
            this.btn_InvoiceRePrint.Id = 10;
            this.btn_InvoiceRePrint.Name = "btn_InvoiceRePrint";
            this.btn_InvoiceRePrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_InvoiceRePrint_ItemClick);
            // 
            // btn_NCNDRePrint
            // 
            this.btn_NCNDRePrint.Caption = "Notas de Débito y Crédito";
            this.btn_NCNDRePrint.Glyph = global::PRININ.Properties.Resources.creditnote_32;
            this.btn_NCNDRePrint.Id = 11;
            this.btn_NCNDRePrint.Name = "btn_NCNDRePrint";
            this.btn_NCNDRePrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NCNDRePrint_ItemClick);
            // 
            // btn_CloseProgram
            // 
            this.btn_CloseProgram.Caption = "Cerrar Interfaz";
            this.btn_CloseProgram.Glyph = global::PRININ.Properties.Resources.close_32;
            this.btn_CloseProgram.Id = 12;
            this.btn_CloseProgram.Name = "btn_CloseProgram";
            this.btn_CloseProgram.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // cmdCheques
            // 
            this.cmdCheques.Caption = "Cheques";
            this.cmdCheques.Glyph = global::PRININ.Properties.Resources.Bank_Check_icon32px;
            this.cmdCheques.Id = 13;
            this.cmdCheques.Name = "cmdCheques";
            this.cmdCheques.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmdCheques_ItemClick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Imprimir Facturas, Notas de Débito y Crédito de M3";
            this.notifyIcon1.BalloonTipTitle = "M3 Invoice Print";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Tag = "Imprimir Facturas, Notas de Débito y Crédito de M3";
            this.notifyIcon1.Text = "M3 Invoice Print";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarOpcionesToolStripMenuItem,
            this.ocultarOpcionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 70);
            // 
            // mostrarOpcionesToolStripMenuItem
            // 
            this.mostrarOpcionesToolStripMenuItem.Name = "mostrarOpcionesToolStripMenuItem";
            this.mostrarOpcionesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.mostrarOpcionesToolStripMenuItem.Text = "Mostrar Opciones";
            this.mostrarOpcionesToolStripMenuItem.Click += new System.EventHandler(this.mostrarOpcionesToolStripMenuItem_Click);
            // 
            // ocultarOpcionesToolStripMenuItem
            // 
            this.ocultarOpcionesToolStripMenuItem.Name = "ocultarOpcionesToolStripMenuItem";
            this.ocultarOpcionesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ocultarOpcionesToolStripMenuItem.Text = "Ocultar Opciones";
            this.ocultarOpcionesToolStripMenuItem.Click += new System.EventHandler(this.ocultarOpcionesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.salirToolStripMenuItem.Text = "Cerrar Interfaz";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // rd_menu
            // 
            this.rd_menu.Glyph = global::PRININ.Properties.Resources.shrimp_32;
            this.rd_menu.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.rd_menu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_inv),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DebitNotes),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_creditNOtes),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_CloseProgram),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdCheques)});
            this.rd_menu.Manager = this.barManager1;
            this.rd_menu.MenuRadius = 150;
            this.rd_menu.Name = "rd_menu";
            this.rd_menu.CloseUp += new System.EventHandler(this.rd_menu_CloseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 0);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PRININ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rd_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocultarOpcionesToolStripMenuItem;
        private DevExpress.XtraBars.BarButtonItem btn_invoice;
        private DevExpress.XtraBars.BarButtonItem btn_nd;
        private DevExpress.XtraBars.BarButtonItem btn_nc;
        private DevExpress.XtraBars.BarButtonItem btn_close;
        private DevExpress.XtraBars.Ribbon.RadialMenu rd_menu;
        private DevExpress.XtraBars.BarButtonItem btn_inv;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_DebitNotes;
        private DevExpress.XtraBars.BarButtonItem btn_creditNOtes;
        private DevExpress.XtraBars.BarButtonItem btn_CloseInterface;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btn_InvoiceRePrint;
        private DevExpress.XtraBars.BarButtonItem btn_NCNDRePrint;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_CloseProgram;
        private DevExpress.XtraBars.BarButtonItem cmdCheques;

    }
}


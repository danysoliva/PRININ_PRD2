namespace PRININ
{
    partial class frmMenuPrinin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrinin));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPedidos = new DevExpress.XtraEditors.SimpleButton();
            this.cmdMantenimiento = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRptsNotas = new DevExpress.XtraEditors.SimpleButton();
            this.cmdOrdenesCompra = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdResumenNotas = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasCréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem,
            this.notasCréditoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(230, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.ImageOptions.Image = global::PRININ.Properties.Resources.document_photo_icon32px;
            this.simpleButton7.Location = new System.Drawing.Point(12, 573);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(224, 44);
            this.simpleButton7.TabIndex = 11;
            this.simpleButton7.Text = "Notas UNITED";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = global::PRININ.Properties.Resources.invoice_321;
            this.simpleButton3.Location = new System.Drawing.Point(12, 523);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(224, 44);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "Facturas UNITED";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // cmdPedidos
            // 
            this.cmdPedidos.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPedidos.Appearance.Options.UseFont = true;
            this.cmdPedidos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdPedidos.ImageOptions.Image")));
            this.cmdPedidos.Location = new System.Drawing.Point(12, 323);
            this.cmdPedidos.Name = "cmdPedidos";
            this.cmdPedidos.Size = new System.Drawing.Size(224, 44);
            this.cmdPedidos.TabIndex = 9;
            this.cmdPedidos.Text = "Pedidos";
            this.cmdPedidos.Click += new System.EventHandler(this.cmdPedidos_Click);
            // 
            // cmdMantenimiento
            // 
            this.cmdMantenimiento.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMantenimiento.Appearance.Options.UseFont = true;
            this.cmdMantenimiento.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdMantenimiento.ImageOptions.Image")));
            this.cmdMantenimiento.Location = new System.Drawing.Point(12, 423);
            this.cmdMantenimiento.Name = "cmdMantenimiento";
            this.cmdMantenimiento.Size = new System.Drawing.Size(224, 44);
            this.cmdMantenimiento.TabIndex = 8;
            this.cmdMantenimiento.Text = "Mantenimiento";
            this.cmdMantenimiento.Click += new System.EventHandler(this.cmdMantenimiento_Click);
            // 
            // cmdRptsNotas
            // 
            this.cmdRptsNotas.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRptsNotas.Appearance.Options.UseFont = true;
            this.cmdRptsNotas.ImageOptions.Image = global::PRININ.Properties.Resources.debitnote_32;
            this.cmdRptsNotas.Location = new System.Drawing.Point(12, 373);
            this.cmdRptsNotas.Name = "cmdRptsNotas";
            this.cmdRptsNotas.Size = new System.Drawing.Size(224, 44);
            this.cmdRptsNotas.TabIndex = 7;
            this.cmdRptsNotas.Text = "Reporte de Notas";
            this.cmdRptsNotas.Click += new System.EventHandler(this.cmdRptsNotas_Click);
            // 
            // cmdOrdenesCompra
            // 
            this.cmdOrdenesCompra.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOrdenesCompra.Appearance.Options.UseFont = true;
            this.cmdOrdenesCompra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdOrdenesCompra.ImageOptions.Image")));
            this.cmdOrdenesCompra.Location = new System.Drawing.Point(12, 273);
            this.cmdOrdenesCompra.Name = "cmdOrdenesCompra";
            this.cmdOrdenesCompra.Size = new System.Drawing.Size(224, 44);
            this.cmdOrdenesCompra.TabIndex = 6;
            this.cmdOrdenesCompra.Text = "Ordenes de Compra";
            this.cmdOrdenesCompra.Click += new System.EventHandler(this.cmdOrdenesCompra_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.ImageOptions.Image = global::PRININ.Properties.Resources.close_32;
            this.simpleButton6.Location = new System.Drawing.Point(12, 473);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(224, 44);
            this.simpleButton6.TabIndex = 5;
            this.simpleButton6.Text = "Cerrar";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.Image = global::PRININ.Properties.Resources.Bank_Check_icon32px;
            this.simpleButton5.Location = new System.Drawing.Point(12, 223);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(224, 44);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "Cheques";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = global::PRININ.Properties.Resources.print_32;
            this.simpleButton4.Location = new System.Drawing.Point(12, 173);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(224, 44);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Reimpresión";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // cmdResumenNotas
            // 
            this.cmdResumenNotas.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResumenNotas.Appearance.Options.UseFont = true;
            this.cmdResumenNotas.ImageOptions.Image = global::PRININ.Properties.Resources.creditnote_32;
            this.cmdResumenNotas.Location = new System.Drawing.Point(12, 123);
            this.cmdResumenNotas.Name = "cmdResumenNotas";
            this.cmdResumenNotas.Size = new System.Drawing.Size(224, 44);
            this.cmdResumenNotas.TabIndex = 2;
            this.cmdResumenNotas.Text = "Resumen de Notas";
            this.cmdResumenNotas.Click += new System.EventHandler(this.cmdResumenNotas_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::PRININ.Properties.Resources.debitnote_32;
            this.simpleButton2.Location = new System.Drawing.Point(12, 73);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(224, 44);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "NC / ND";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = global::PRININ.Properties.Resources.invoice_321;
            this.simpleButton1.Location = new System.Drawing.Point(12, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(224, 44);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Facturas";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturasToolStripMenuItem.Image = global::PRININ.Properties.Resources.invoice_16;
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // notasCréditoToolStripMenuItem
            // 
            this.notasCréditoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasCréditoToolStripMenuItem.Image = global::PRININ.Properties.Resources.creditnote_16;
            this.notasCréditoToolStripMenuItem.Name = "notasCréditoToolStripMenuItem";
            this.notasCréditoToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.notasCréditoToolStripMenuItem.Text = "Notas Crédito y Débito";
            this.notasCréditoToolStripMenuItem.Click += new System.EventHandler(this.notasCréditoToolStripMenuItem_Click);
            // 
            // frmMenuPrinin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 625);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.cmdPedidos);
            this.Controls.Add(this.cmdMantenimiento);
            this.Controls.Add(this.cmdRptsNotas);
            this.Controls.Add(this.cmdOrdenesCompra);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.cmdResumenNotas);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrinin";
            this.Text = "PRININ";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton cmdResumenNotas;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasCréditoToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton cmdOrdenesCompra;
        private DevExpress.XtraEditors.SimpleButton cmdRptsNotas;
        private DevExpress.XtraEditors.SimpleButton cmdMantenimiento;
        private DevExpress.XtraEditors.SimpleButton cmdPedidos;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
    }
}
namespace PRININ.Notas
{
    partial class frmNewNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewNota));
            this.txtCodigoProveedor = new DevExpress.XtraEditors.TextEdit();
            this.txtRTN = new DevExpress.XtraEditors.TextEdit();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toggleTipoNota = new DevExpress.XtraEditors.ToggleSwitch();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConcepto = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDocumento = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCai = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtTasaCambio = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdAbrirBusq = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleTipoNota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaCambio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.Enabled = false;
            this.txtCodigoProveedor.Location = new System.Drawing.Point(183, 107);
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoProveedor.Properties.NullValuePrompt = "Código";
            this.txtCodigoProveedor.Size = new System.Drawing.Size(94, 24);
            this.txtCodigoProveedor.TabIndex = 30;
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(553, 107);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTN.Properties.Appearance.Options.UseFont = true;
            this.txtRTN.Properties.NullValuePrompt = "RTN";
            this.txtRTN.Size = new System.Drawing.Size(193, 24);
            this.txtRTN.TabIndex = 27;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(283, 107);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtProveedor.Properties.NullValuePrompt = "Nombre del Proveedor";
            this.txtProveedor.Size = new System.Drawing.Size(264, 24);
            this.txtProveedor.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Proveedor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(341, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nueva Nota";
            // 
            // toggleTipoNota
            // 
            this.toggleTipoNota.EditValue = true;
            this.toggleTipoNota.Location = new System.Drawing.Point(645, 58);
            this.toggleTipoNota.Name = "toggleTipoNota";
            this.toggleTipoNota.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.toggleTipoNota.Properties.Appearance.Options.UseFont = true;
            this.toggleTipoNota.Properties.OffText = "Credito";
            this.toggleTipoNota.Properties.OnText = "Debito";
            this.toggleTipoNota.Size = new System.Drawing.Size(151, 29);
            this.toggleTipoNota.TabIndex = 0;
            this.toggleTipoNota.Toggled += new System.EventHandler(this.toggleTipoNota_Toggled);
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(183, 137);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFecha.Properties.Appearance.Options.UseFont = true;
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Size = new System.Drawing.Size(212, 26);
            this.dtFecha.TabIndex = 2;
            this.dtFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtFecha_KeyDown);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Fecha";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(183, 169);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Properties.Appearance.Options.UseFont = true;
            this.txtConcepto.Size = new System.Drawing.Size(563, 24);
            this.txtConcepto.TabIndex = 3;
            this.txtConcepto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConcepto_KeyDown);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 24);
            this.label10.TabIndex = 36;
            this.label10.Text = "Concepto";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Location = new System.Drawing.Point(183, 199);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Properties.Appearance.Options.UseFont = true;
            this.txtDocumento.Properties.NullValuePrompt = "Nombre del Contacto";
            this.txtDocumento.Size = new System.Drawing.Size(563, 24);
            this.txtDocumento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "# Documento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCai
            // 
            this.txtCai.Enabled = false;
            this.txtCai.Location = new System.Drawing.Point(183, 229);
            this.txtCai.Name = "txtCai";
            this.txtCai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCai.Properties.Appearance.Options.UseFont = true;
            this.txtCai.Properties.NullValuePrompt = "Nombre del Contacto";
            this.txtCai.Size = new System.Drawing.Size(563, 24);
            this.txtCai.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "CAI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMonto
            // 
            this.txtMonto.EditValue = "0.00";
            this.txtMonto.Location = new System.Drawing.Point(183, 289);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Properties.Appearance.Options.UseFont = true;
            this.txtMonto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMonto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMonto.Size = new System.Drawing.Size(224, 24);
            this.txtMonto.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Monto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCancelar.Location = new System.Drawing.Point(413, 329);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(200, 35);
            this.cmdCancelar.TabIndex = 8;
            this.cmdCancelar.Text = "Salir";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.Location = new System.Drawing.Point(207, 329);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(200, 35);
            this.cmdGuardar.TabIndex = 7;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // txtTasaCambio
            // 
            this.txtTasaCambio.EditValue = "0.0000";
            this.txtTasaCambio.Location = new System.Drawing.Point(183, 259);
            this.txtTasaCambio.Name = "txtTasaCambio";
            this.txtTasaCambio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasaCambio.Properties.Appearance.Options.UseFont = true;
            this.txtTasaCambio.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTasaCambio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTasaCambio.Properties.Mask.EditMask = "###,##0.0000";
            this.txtTasaCambio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTasaCambio.Size = new System.Drawing.Size(224, 24);
            this.txtTasaCambio.TabIndex = 5;
            this.txtTasaCambio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTasaCambio_KeyDown);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "Tasa de Cambio";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdAbrirBusq
            // 
            this.cmdAbrirBusq.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdAbrirBusq.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAbrirBusq.ImageOptions.Image")));
            this.cmdAbrirBusq.Location = new System.Drawing.Point(752, 101);
            this.cmdAbrirBusq.Name = "cmdAbrirBusq";
            this.cmdAbrirBusq.Size = new System.Drawing.Size(44, 39);
            this.cmdAbrirBusq.TabIndex = 45;
            this.cmdAbrirBusq.Click += new System.EventHandler(this.cmdAbrirBusq_Click);
            // 
            // frmNewNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 376);
            this.Controls.Add(this.cmdAbrirBusq);
            this.Controls.Add(this.txtTasaCambio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toggleTipoNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoProveedor);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label1);
            this.Name = "frmNewNota";
            this.Text = "Nueva Nota";
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleTipoNota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaCambio.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCodigoProveedor;
        private DevExpress.XtraEditors.TextEdit txtRTN;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ToggleSwitch toggleTipoNota;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtConcepto;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtDocumento;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtCai;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.TextEdit txtTasaCambio;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton cmdAbrirBusq;
    }
}
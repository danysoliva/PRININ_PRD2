namespace PRININ
{
    partial class frmCheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheques));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtleyenda = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsCheques1 = new PRININ.dsCheques();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colleyenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_letras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmd_print = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdImprimirCheque = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmd_delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Button_Eliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colconcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.impresiónesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeChequesEmitidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeSecuenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheques1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdImprimirCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Leyenda:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(302, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(176, 25);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Emisión de Cheques";
            // 
            // txtleyenda
            // 
            this.txtleyenda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtleyenda.Location = new System.Drawing.Point(79, 41);
            this.txtleyenda.Name = "txtleyenda";
            this.txtleyenda.Size = new System.Drawing.Size(142, 25);
            this.txtleyenda.TabIndex = 0;
            this.txtleyenda.Text = "NO NEGOCIABLE";
            this.txtleyenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtleyenda_KeyDown);
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(314, 41);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(230, 25);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFecha_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(265, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 21);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Fecha:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(79, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(465, 25);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 83);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 21);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Nombre:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(579, 83);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 21);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(625, 83);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(130, 25);
            this.txtValor.TabIndex = 4;
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            // 
            // txtLetras
            // 
            this.txtLetras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetras.Location = new System.Drawing.Point(79, 124);
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(465, 25);
            this.txtLetras.TabIndex = 5;
            this.txtLetras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLetras_KeyDown);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(28, 124);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 21);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Letras:";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(562, 154);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(193, 38);
            this.cmdGuardar.TabIndex = 6;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "cheques";
            this.gridControl1.DataSource = this.dsCheques1;
            this.gridControl1.Location = new System.Drawing.Point(3, 204);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdImprimirCheque,
            this.Button_Eliminar});
            this.gridControl1.Size = new System.Drawing.Size(773, 250);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // dsCheques1
            // 
            this.dsCheques1.DataSetName = "dsCheques";
            this.dsCheques1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colleyenda,
            this.colnombre,
            this.colfecha,
            this.colmonto,
            this.colvalor_letras,
            this.colnumero,
            this.cmd_print,
            this.cmd_delete,
            this.colconcepto,
            this.colmoneda});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colleyenda
            // 
            this.colleyenda.Caption = "Leyenda";
            this.colleyenda.FieldName = "leyenda";
            this.colleyenda.Name = "colleyenda";
            this.colleyenda.Visible = true;
            this.colleyenda.VisibleIndex = 0;
            this.colleyenda.Width = 70;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 134;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            this.colfecha.Width = 73;
            // 
            // colmonto
            // 
            this.colmonto.Caption = "Monto";
            this.colmonto.FieldName = "monto";
            this.colmonto.Name = "colmonto";
            this.colmonto.Visible = true;
            this.colmonto.VisibleIndex = 3;
            this.colmonto.Width = 73;
            // 
            // colvalor_letras
            // 
            this.colvalor_letras.Caption = "Valor en Letras";
            this.colvalor_letras.FieldName = "valor_letras";
            this.colvalor_letras.Name = "colvalor_letras";
            this.colvalor_letras.Visible = true;
            this.colvalor_letras.VisibleIndex = 4;
            this.colvalor_letras.Width = 142;
            // 
            // colnumero
            // 
            this.colnumero.Caption = "# Cheque";
            this.colnumero.FieldName = "numero";
            this.colnumero.Name = "colnumero";
            this.colnumero.Visible = true;
            this.colnumero.VisibleIndex = 5;
            this.colnumero.Width = 59;
            // 
            // cmd_print
            // 
            this.cmd_print.Caption = "Imprimir";
            this.cmd_print.ColumnEdit = this.cmdImprimirCheque;
            this.cmd_print.Name = "cmd_print";
            this.cmd_print.Visible = true;
            this.cmd_print.VisibleIndex = 8;
            this.cmd_print.Width = 40;
            // 
            // cmdImprimirCheque
            // 
            this.cmdImprimirCheque.AutoHeight = false;
            editorButtonImageOptions1.Image = global::PRININ.Properties.Resources.print_24;
            this.cmdImprimirCheque.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.cmdImprimirCheque.Name = "cmdImprimirCheque";
            this.cmdImprimirCheque.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdImprimirCheque.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdImprimirCheque_ButtonClick);
            // 
            // cmd_delete
            // 
            this.cmd_delete.Caption = "Eliminar";
            this.cmd_delete.ColumnEdit = this.Button_Eliminar;
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Visible = true;
            this.cmd_delete.VisibleIndex = 9;
            this.cmd_delete.Width = 58;
            // 
            // Button_Eliminar
            // 
            this.Button_Eliminar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.Button_Eliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.Button_Eliminar.Name = "Button_Eliminar";
            this.Button_Eliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.Button_Eliminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Button_Eliminar_ButtonClick_1);
            // 
            // colconcepto
            // 
            this.colconcepto.FieldName = "concepto";
            this.colconcepto.Name = "colconcepto";
            this.colconcepto.Visible = true;
            this.colconcepto.VisibleIndex = 7;
            this.colconcepto.Width = 69;
            // 
            // colmoneda
            // 
            this.colmoneda.FieldName = "moneda";
            this.colmoneda.Name = "colmoneda";
            this.colmoneda.Visible = true;
            this.colmoneda.VisibleIndex = 6;
            this.colmoneda.Width = 37;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(625, 41);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(130, 25);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(550, 41);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 21);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "# Cheque:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(79, 164);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(465, 25);
            this.txtConcepto.TabIndex = 14;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(4, 166);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(69, 21);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Concepto:";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(625, 121);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.OffText = "Lempiras";
            this.toggleSwitch1.Properties.OnText = "Dolares";
            this.toggleSwitch1.Size = new System.Drawing.Size(130, 26);
            this.toggleSwitch1.TabIndex = 16;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impresiónesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // impresiónesToolStripMenuItem
            // 
            this.impresiónesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeChequesEmitidosToolStripMenuItem,
            this.mantenimientoDeSecuenciaToolStripMenuItem});
            this.impresiónesToolStripMenuItem.Name = "impresiónesToolStripMenuItem";
            this.impresiónesToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.impresiónesToolStripMenuItem.Text = "Impresiónes";
            // 
            // listadoDeChequesEmitidosToolStripMenuItem
            // 
            this.listadoDeChequesEmitidosToolStripMenuItem.Image = global::PRININ.Properties.Resources.Custom_Icon_Design_Flatastic_5_Reports;
            this.listadoDeChequesEmitidosToolStripMenuItem.Name = "listadoDeChequesEmitidosToolStripMenuItem";
            this.listadoDeChequesEmitidosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.listadoDeChequesEmitidosToolStripMenuItem.Text = "Listado de Cheques Emitidos";
            this.listadoDeChequesEmitidosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeChequesEmitidosToolStripMenuItem_Click);
            // 
            // mantenimientoDeSecuenciaToolStripMenuItem
            // 
            this.mantenimientoDeSecuenciaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoDeSecuenciaToolStripMenuItem.Image")));
            this.mantenimientoDeSecuenciaToolStripMenuItem.Name = "mantenimientoDeSecuenciaToolStripMenuItem";
            this.mantenimientoDeSecuenciaToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.mantenimientoDeSecuenciaToolStripMenuItem.Text = "Mantenimiento de Secuencia";
            this.mantenimientoDeSecuenciaToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeSecuenciaToolStripMenuItem_Click);
            // 
            // frmCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 457);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtleyenda);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCheques";
            this.Text = "Emisión de Cheques";
            this.Load += new System.EventHandler(this.frmCheques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheques1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdImprimirCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtleyenda;
        private System.Windows.Forms.TextBox txtFecha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtLetras;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsCheques dsCheques1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colleyenda;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_letras;
        private System.Windows.Forms.TextBox txtNumero;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero;
        private DevExpress.XtraGrid.Columns.GridColumn cmd_print;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdImprimirCheque;
        private System.Windows.Forms.TextBox txtConcepto;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colconcepto;
        private DevExpress.XtraGrid.Columns.GridColumn cmd_delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Button_Eliminar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem impresiónesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeChequesEmitidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeSecuenciaToolStripMenuItem;
    }
}
namespace PRININ.Compras
{
    partial class frmOrdenCompraNormalResumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenCompraNormalResumen));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tgMostrarCerradas = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.resumenocnBindingSource = new System.Windows.Forms.BindingSource();
            this.dsCompras1 = new PRININ.Compras.dsCompras();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_oc_sar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcerrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button_cerrar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnContacts = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnTarjetas = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdNueva = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tgMostrarCerradas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenocnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(977, 66);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(171, 35);
            this.simpleButton1.TabIndex = 34;
            this.simpleButton1.Text = "Detalle Ordenes ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(889, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mostrar Cerradas";
            // 
            // tgMostrarCerradas
            // 
            this.tgMostrarCerradas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tgMostrarCerradas.Location = new System.Drawing.Point(1039, 105);
            this.tgMostrarCerradas.Name = "tgMostrarCerradas";
            this.tgMostrarCerradas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgMostrarCerradas.Properties.Appearance.Options.UseFont = true;
            this.tgMostrarCerradas.Properties.OffText = "No";
            this.tgMostrarCerradas.Properties.OnText = "Si";
            this.tgMostrarCerradas.Size = new System.Drawing.Size(109, 26);
            this.tgMostrarCerradas.TabIndex = 31;
            this.tgMostrarCerradas.Toggled += new System.EventHandler(this.tgMostrarCerradas_Toggled);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(440, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(205, 25);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Ordenes de Compra";
            // 
            // gridMain
            // 
            this.gridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMain.DataSource = this.resumenocnBindingSource;
            this.gridMain.Location = new System.Drawing.Point(1, 131);
            this.gridMain.MainView = this.gridView1;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.btnContacts,
            this.btnTarjetas,
            this.repositoryItemButtonPrint,
            this.button_cerrar});
            this.gridMain.Size = new System.Drawing.Size(1146, 560);
            this.gridMain.TabIndex = 29;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // resumenocnBindingSource
            // 
            this.resumenocnBindingSource.DataMember = "resumen_oc_n";
            this.resumenocnBindingSource.DataSource = this.dsCompras1;
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colproveedor,
            this.colcodigo_proveedor,
            this.colfecha,
            this.colmoneda_name,
            this.colmoneda,
            this.colnumero,
            this.colnum_factura,
            this.colnum_oc_sar,
            this.colcerrada,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridMain;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colproveedor
            // 
            this.colproveedor.Caption = "Proveedor";
            this.colproveedor.FieldName = "proveedor";
            this.colproveedor.Name = "colproveedor";
            this.colproveedor.OptionsColumn.AllowEdit = false;
            this.colproveedor.Visible = true;
            this.colproveedor.VisibleIndex = 1;
            // 
            // colcodigo_proveedor
            // 
            this.colcodigo_proveedor.Caption = "Codigo Proveedor";
            this.colcodigo_proveedor.FieldName = "codigo_proveedor";
            this.colcodigo_proveedor.Name = "colcodigo_proveedor";
            this.colcodigo_proveedor.OptionsColumn.AllowEdit = false;
            this.colcodigo_proveedor.Visible = true;
            this.colcodigo_proveedor.VisibleIndex = 2;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            // 
            // colmoneda_name
            // 
            this.colmoneda_name.Caption = "Moneda";
            this.colmoneda_name.FieldName = "moneda_name";
            this.colmoneda_name.Name = "colmoneda_name";
            this.colmoneda_name.OptionsColumn.AllowEdit = false;
            this.colmoneda_name.Visible = true;
            this.colmoneda_name.VisibleIndex = 4;
            // 
            // colmoneda
            // 
            this.colmoneda.FieldName = "moneda";
            this.colmoneda.Name = "colmoneda";
            // 
            // colnumero
            // 
            this.colnumero.Caption = "Numero";
            this.colnumero.FieldName = "numero";
            this.colnumero.Name = "colnumero";
            this.colnumero.OptionsColumn.AllowEdit = false;
            this.colnumero.Visible = true;
            this.colnumero.VisibleIndex = 0;
            // 
            // colnum_factura
            // 
            this.colnum_factura.Caption = "# Factura";
            this.colnum_factura.FieldName = "num_factura";
            this.colnum_factura.Name = "colnum_factura";
            this.colnum_factura.Visible = true;
            this.colnum_factura.VisibleIndex = 5;
            // 
            // colnum_oc_sar
            // 
            this.colnum_oc_sar.Caption = "# OC SAR";
            this.colnum_oc_sar.FieldName = "num_oc_sar";
            this.colnum_oc_sar.Name = "colnum_oc_sar";
            this.colnum_oc_sar.Visible = true;
            this.colnum_oc_sar.VisibleIndex = 6;
            // 
            // colcerrada
            // 
            this.colcerrada.Caption = "Cerrar Orden";
            this.colcerrada.ColumnEdit = this.button_cerrar;
            this.colcerrada.FieldName = "cerrada";
            this.colcerrada.Name = "colcerrada";
            this.colcerrada.Visible = true;
            this.colcerrada.VisibleIndex = 7;
            // 
            // button_cerrar
            // 
            this.button_cerrar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.button_cerrar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.button_cerrar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.button_cerrar_ButtonClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Imprimir";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonPrint;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            // 
            // repositoryItemButtonPrint
            // 
            this.repositoryItemButtonPrint.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemButtonPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonPrint.Name = "repositoryItemButtonPrint";
            this.repositoryItemButtonPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonPrint.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonPrint_ButtonClick);
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnContacts
            // 
            this.btnContacts.AutoHeight = false;
            this.btnContacts.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnTarjetas
            // 
            this.btnTarjetas.AutoHeight = false;
            this.btnTarjetas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.btnTarjetas.Name = "btnTarjetas";
            this.btnTarjetas.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdNueva
            // 
            this.cmdNueva.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNueva.Appearance.Options.UseFont = true;
            this.cmdNueva.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNueva.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNueva.ImageOptions.Image")));
            this.cmdNueva.Location = new System.Drawing.Point(11, 77);
            this.cmdNueva.Name = "cmdNueva";
            this.cmdNueva.Size = new System.Drawing.Size(127, 35);
            this.cmdNueva.TabIndex = 35;
            this.cmdNueva.Text = "Nueva";
            this.cmdNueva.Click += new System.EventHandler(this.cmdNueva_Click);
            // 
            // frmOrdenCompraNormalResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 691);
            this.Controls.Add(this.cmdNueva);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tgMostrarCerradas);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridMain);
            this.Name = "frmOrdenCompraNormalResumen";
            this.Text = "frmOrdenCompraNormalResumen";
            ((System.ComponentModel.ISupportInitialize)(this.tgMostrarCerradas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenocnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ToggleSwitch tgMostrarCerradas;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit button_cerrar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnContacts;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnTarjetas;
        private DevExpress.XtraEditors.SimpleButton cmdNueva;
        private dsCompras dsCompras1;
        private System.Windows.Forms.BindingSource resumenocnBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colcerrada;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda_name;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_oc_sar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}
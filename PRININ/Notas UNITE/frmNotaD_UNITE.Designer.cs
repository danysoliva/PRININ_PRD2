namespace PRININ.Notas
{
    partial class frmNotaD_UNITE
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotaD_UNITE));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsNotas1 = new PRININ.Notas.dsNotas();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_nota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_cr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldebito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_letras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrtn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colAnular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAnular = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdNueva = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tgMostrarCerradas = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgMostrarCerradas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "notas_resumen";
            this.gridControl1.DataSource = this.dsNotas1;
            this.gridControl1.Location = new System.Drawing.Point(3, 80);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnImprimir,
            this.btnAnular});
            this.gridControl1.Size = new System.Drawing.Size(1032, 452);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsNotas1
            // 
            this.dsNotas1.DataSetName = "dsNotas";
            this.dsNotas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coltipo_nota,
            this.colfecha_cr,
            this.colcai,
            this.colcod_cliente,
            this.colcredito,
            this.coldebito,
            this.colmonto_letras,
            this.colconcepto,
            this.colnum_documento,
            this.colenable,
            this.colrtn,
            this.colfecha_doc,
            this.colmonto,
            this.coltipo,
            this.colcliente,
            this.colPrint,
            this.colAnular});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coltipo_nota
            // 
            this.coltipo_nota.FieldName = "tipo_nota";
            this.coltipo_nota.Name = "coltipo_nota";
            // 
            // colfecha_cr
            // 
            this.colfecha_cr.Caption = "F. Creada";
            this.colfecha_cr.FieldName = "fecha_cr";
            this.colfecha_cr.Name = "colfecha_cr";
            this.colfecha_cr.OptionsColumn.AllowEdit = false;
            this.colfecha_cr.Visible = true;
            this.colfecha_cr.VisibleIndex = 0;
            this.colfecha_cr.Width = 83;
            // 
            // colcai
            // 
            this.colcai.FieldName = "cai";
            this.colcai.Name = "colcai";
            // 
            // colcod_cliente
            // 
            this.colcod_cliente.Caption = "Cod. Cliente";
            this.colcod_cliente.FieldName = "cod_cliente";
            this.colcod_cliente.Name = "colcod_cliente";
            this.colcod_cliente.OptionsColumn.AllowEdit = false;
            this.colcod_cliente.Visible = true;
            this.colcod_cliente.VisibleIndex = 1;
            this.colcod_cliente.Width = 79;
            // 
            // colcredito
            // 
            this.colcredito.FieldName = "credito";
            this.colcredito.Name = "colcredito";
            // 
            // coldebito
            // 
            this.coldebito.FieldName = "debito";
            this.coldebito.Name = "coldebito";
            // 
            // colmonto_letras
            // 
            this.colmonto_letras.FieldName = "monto_letras";
            this.colmonto_letras.Name = "colmonto_letras";
            // 
            // colconcepto
            // 
            this.colconcepto.Caption = "Concepto";
            this.colconcepto.FieldName = "concepto";
            this.colconcepto.Name = "colconcepto";
            this.colconcepto.OptionsColumn.AllowEdit = false;
            this.colconcepto.Visible = true;
            this.colconcepto.VisibleIndex = 7;
            this.colconcepto.Width = 253;
            // 
            // colnum_documento
            // 
            this.colnum_documento.Caption = "# Doc.";
            this.colnum_documento.FieldName = "num_documento";
            this.colnum_documento.Name = "colnum_documento";
            this.colnum_documento.OptionsColumn.AllowEdit = false;
            this.colnum_documento.Visible = true;
            this.colnum_documento.VisibleIndex = 4;
            this.colnum_documento.Width = 149;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // colrtn
            // 
            this.colrtn.Caption = "RTN";
            this.colrtn.FieldName = "rtn";
            this.colrtn.Name = "colrtn";
            this.colrtn.Width = 118;
            // 
            // colfecha_doc
            // 
            this.colfecha_doc.Caption = "Fecha Doc.";
            this.colfecha_doc.FieldName = "fecha_doc";
            this.colfecha_doc.Name = "colfecha_doc";
            this.colfecha_doc.OptionsColumn.AllowEdit = false;
            this.colfecha_doc.Visible = true;
            this.colfecha_doc.VisibleIndex = 5;
            this.colfecha_doc.Width = 97;
            // 
            // colmonto
            // 
            this.colmonto.Caption = "Valor";
            this.colmonto.FieldName = "monto";
            this.colmonto.Name = "colmonto";
            this.colmonto.OptionsColumn.AllowEdit = false;
            this.colmonto.Visible = true;
            this.colmonto.VisibleIndex = 6;
            this.colmonto.Width = 113;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.OptionsColumn.AllowEdit = false;
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 3;
            this.coltipo.Width = 74;
            // 
            // colcliente
            // 
            this.colcliente.Caption = "Cliente";
            this.colcliente.FieldName = "cliente";
            this.colcliente.Name = "colcliente";
            this.colcliente.OptionsColumn.AllowEdit = false;
            this.colcliente.Visible = true;
            this.colcliente.VisibleIndex = 2;
            this.colcliente.Width = 166;
            // 
            // colPrint
            // 
            this.colPrint.Caption = "Imprimir";
            this.colPrint.ColumnEdit = this.btnImprimir;
            this.colPrint.Name = "colPrint";
            this.colPrint.Visible = true;
            this.colPrint.VisibleIndex = 8;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnImprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnImprimir.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnImprimir_ButtonClick);
            // 
            // colAnular
            // 
            this.colAnular.Caption = "Anular";
            this.colAnular.ColumnEdit = this.btnAnular;
            this.colAnular.Name = "colAnular";
            this.colAnular.Visible = true;
            this.colAnular.VisibleIndex = 9;
            // 
            // btnAnular
            // 
            this.btnAnular.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnAnular.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAnular.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAnular_ButtonClick);
            // 
            // cmdNueva
            // 
            this.cmdNueva.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNueva.Appearance.Options.UseFont = true;
            this.cmdNueva.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNueva.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNueva.ImageOptions.Image")));
            this.cmdNueva.Location = new System.Drawing.Point(3, 41);
            this.cmdNueva.Name = "cmdNueva";
            this.cmdNueva.Size = new System.Drawing.Size(111, 35);
            this.cmdNueva.TabIndex = 25;
            this.cmdNueva.Text = "Nueva";
            this.cmdNueva.Click += new System.EventHandler(this.cmdNueva_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(798, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mostrar Cerradas";
            // 
            // tgMostrarCerradas
            // 
            this.tgMostrarCerradas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tgMostrarCerradas.Location = new System.Drawing.Point(929, 48);
            this.tgMostrarCerradas.Name = "tgMostrarCerradas";
            this.tgMostrarCerradas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgMostrarCerradas.Properties.Appearance.Options.UseFont = true;
            this.tgMostrarCerradas.Properties.OffText = "No";
            this.tgMostrarCerradas.Properties.OnText = "Si";
            this.tgMostrarCerradas.Size = new System.Drawing.Size(95, 26);
            this.tgMostrarCerradas.TabIndex = 28;
            this.tgMostrarCerradas.Toggled += new System.EventHandler(this.tgMostrarCerradas_Toggled);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(364, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(256, 25);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Notas de Crédito/Débito";
            // 
            // frmNotaD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tgMostrarCerradas);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmdNueva);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmNotaD_UNITE";
            this.Text = "Notas Debito";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgMostrarCerradas.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdNueva;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ToggleSwitch tgMostrarCerradas;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private dsNotas dsNotas1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_nota;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_cr;
        private DevExpress.XtraGrid.Columns.GridColumn colcai;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colcredito;
        private DevExpress.XtraGrid.Columns.GridColumn coldebito;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_letras;
        private DevExpress.XtraGrid.Columns.GridColumn colconcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_documento;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colrtn;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_doc;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente;
        private DevExpress.XtraGrid.Columns.GridColumn colPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn colAnular;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAnular;
    }
}
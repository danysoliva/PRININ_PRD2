namespace PRININ.Mantenimiento
{
    partial class frmCAIProv_V2
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCAIProv_V2));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMante = new PRININ.Mantenimiento.dsMante();
            this.gridControlCAI = new DevExpress.XtraGrid.GridControl();
            this.caiprovV2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvCAI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrango = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_limite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAddCai = new DevExpress.XtraEditors.SimpleButton();
            this.TSCai = new DevExpress.XtraEditors.ToggleSwitch();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caiprovV2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSCai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "proveedores";
            this.proveedoresBindingSource.DataSource = this.dsMante;
            // 
            // dsMante
            // 
            this.dsMante.DataSetName = "dsMante";
            this.dsMante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControlCAI
            // 
            this.gridControlCAI.DataSource = this.caiprovV2BindingSource;
            this.gridControlCAI.Location = new System.Drawing.Point(8, 11);
            this.gridControlCAI.MainView = this.gvCAI;
            this.gridControlCAI.Name = "gridControlCAI";
            this.gridControlCAI.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDelete});
            this.gridControlCAI.Size = new System.Drawing.Size(677, 388);
            this.gridControlCAI.TabIndex = 1;
            this.gridControlCAI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCAI});
            // 
            // caiprovV2BindingSource
            // 
            this.caiprovV2BindingSource.DataMember = "cai_prov_V2";
            this.caiprovV2BindingSource.DataSource = this.dsMante;
            // 
            // gvCAI
            // 
            this.gvCAI.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCAI.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCAI.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCAI.Appearance.Row.Options.UseFont = true;
            this.gvCAI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcai,
            this.colrango,
            this.colfecha_limite,
            this.gridColumnDelete});
            this.gvCAI.GridControl = this.gridControlCAI;
            this.gvCAI.Name = "gvCAI";
            this.gvCAI.OptionsView.ShowGroupPanel = false;
            // 
            // colcai
            // 
            this.colcai.Caption = "CAI";
            this.colcai.FieldName = "cai";
            this.colcai.Name = "colcai";
            this.colcai.Visible = true;
            this.colcai.VisibleIndex = 0;
            // 
            // colrango
            // 
            this.colrango.Caption = "Rango Autorizado";
            this.colrango.FieldName = "rango";
            this.colrango.Name = "colrango";
            this.colrango.Visible = true;
            this.colrango.VisibleIndex = 1;
            // 
            // colfecha_limite
            // 
            this.colfecha_limite.Caption = "Fecha Limite de Emision";
            this.colfecha_limite.FieldName = "fecha_limite";
            this.colfecha_limite.Name = "colfecha_limite";
            this.colfecha_limite.Visible = true;
            this.colfecha_limite.VisibleIndex = 2;
            // 
            // gridColumnDelete
            // 
            this.gridColumnDelete.Caption = "Activar/Desactivar";
            this.gridColumnDelete.ColumnEdit = this.repositoryItemDelete;
            this.gridColumnDelete.Name = "gridColumnDelete";
            this.gridColumnDelete.Visible = true;
            this.gridColumnDelete.VisibleIndex = 3;
            // 
            // repositoryItemDelete
            // 
            this.repositoryItemDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemDelete.Name = "repositoryItemDelete";
            this.repositoryItemDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemDelete.Click += new System.EventHandler(this.repositoryItemDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAI de Proveedores";
            // 
            // cmdAddCai
            // 
            this.cmdAddCai.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAddCai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddCai.ImageOptions.Image")));
            this.cmdAddCai.Location = new System.Drawing.Point(12, 141);
            this.cmdAddCai.Name = "cmdAddCai";
            this.cmdAddCai.Size = new System.Drawing.Size(119, 34);
            this.cmdAddCai.TabIndex = 4;
            this.cmdAddCai.Text = "Agregar CAI";
            this.cmdAddCai.Click += new System.EventHandler(this.cmdAddCai_Click);
            // 
            // TSCai
            // 
            this.TSCai.EditValue = true;
            this.TSCai.Location = new System.Drawing.Point(549, 147);
            this.TSCai.Name = "TSCai";
            this.TSCai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSCai.Properties.Appearance.Options.UseFont = true;
            this.TSCai.Properties.OffText = "Inactivos";
            this.TSCai.Properties.OnText = "Activos";
            this.TSCai.Size = new System.Drawing.Size(140, 28);
            this.TSCai.TabIndex = 5;
            this.TSCai.Toggled += new System.EventHandler(this.TSCai_Toggled);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.ImageOptions.Image")));
            this.cmdCancelar.Location = new System.Drawing.Point(371, 408);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(200, 35);
            this.cmdCancelar.TabIndex = 17;
            this.cmdCancelar.Text = "Salir";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.Location = new System.Drawing.Point(146, 408);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(200, 35);
            this.cmdGuardar.TabIndex = 16;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlCAI);
            this.panelControl1.Controls.Add(this.cmdCancelar);
            this.panelControl1.Controls.Add(this.cmdGuardar);
            this.panelControl1.Location = new System.Drawing.Point(4, 192);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(694, 451);
            this.panelControl1.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(111, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 20);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Proveedor:";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(193, 74);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.searchLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.proveedorBindingSource;
            this.searchLookUpEdit1.Properties.DisplayMember = "proveedor";
            this.searchLookUpEdit1.Properties.NullText = "";
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Properties.ValueMember = "prv_key";
            this.searchLookUpEdit1.Size = new System.Drawing.Size(396, 24);
            this.searchLookUpEdit1.TabIndex = 30;
            this.searchLookUpEdit1.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged);
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dsMante;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Proveedor";
            this.gridColumn1.FieldName = "proveedor";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "RTN";
            this.gridColumn2.FieldName = "rtn";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // frmCAIProv_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 688);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.searchLookUpEdit1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.TSCai);
            this.Controls.Add(this.cmdAddCai);
            this.Controls.Add(this.label1);
            this.Name = "frmCAIProv_V2";
            this.Text = "CAI Proveedor";
            this.Load += new System.EventHandler(this.frmCAIProv_V2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caiprovV2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSCai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlCAI;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCAI;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton cmdAddCai;
        private DevExpress.XtraEditors.ToggleSwitch TSCai;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private dsMante dsMante;
        private DevExpress.XtraGrid.Columns.GridColumn colcai;
        private DevExpress.XtraGrid.Columns.GridColumn colrango;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_limite;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemDelete;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.BindingSource caiprovV2BindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}
namespace PRININ.Mantenimiento
{
    partial class frmCAIProv
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCAIProv));
            this.gridProv = new DevExpress.XtraEditors.GridLookUpEdit();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMante = new PRININ.Mantenimiento.dsMante();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlCAI = new DevExpress.XtraGrid.GridControl();
            this.caiprovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrango = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_limite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdAddCai = new DevExpress.XtraEditors.SimpleButton();
            this.TSCai = new DevExpress.XtraEditors.ToggleSwitch();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtCodigoProveedor = new DevExpress.XtraEditors.TextEdit();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.cmdAbrirBusqueda = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridProv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caiprovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSCai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProv
            // 
            this.gridProv.EditValue = "";
            this.gridProv.Location = new System.Drawing.Point(17, 22);
            this.gridProv.Name = "gridProv";
            this.gridProv.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridProv.Properties.Appearance.Options.UseFont = true;
            this.gridProv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridProv.Properties.DataSource = this.proveedoresBindingSource;
            this.gridProv.Properties.DisplayMember = "nombre";
            this.gridProv.Properties.ValueMember = "codigo";
            this.gridProv.Properties.View = this.gridLookUpEdit1View;
            this.gridProv.Size = new System.Drawing.Size(209, 26);
            this.gridProv.TabIndex = 0;
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
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlCAI
            // 
            this.gridControlCAI.DataSource = this.caiprovBindingSource;
            this.gridControlCAI.Location = new System.Drawing.Point(8, 11);
            this.gridControlCAI.MainView = this.gridView1;
            this.gridControlCAI.Name = "gridControlCAI";
            this.gridControlCAI.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDelete});
            this.gridControlCAI.Size = new System.Drawing.Size(677, 388);
            this.gridControlCAI.TabIndex = 1;
            this.gridControlCAI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // caiprovBindingSource
            // 
            this.caiprovBindingSource.DataMember = "cai_prov";
            this.caiprovBindingSource.DataSource = this.dsMante;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcai,
            this.colrango,
            this.colfecha_limite,
            this.gridColumnDelete});
            this.gridView1.GridControl = this.gridControlCAI;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proveedor:";
            // 
            // cmdAddCai
            // 
            this.cmdAddCai.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAddCai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddCai.ImageOptions.Image")));
            this.cmdAddCai.Location = new System.Drawing.Point(12, 125);
            this.cmdAddCai.Name = "cmdAddCai";
            this.cmdAddCai.Size = new System.Drawing.Size(119, 34);
            this.cmdAddCai.TabIndex = 4;
            this.cmdAddCai.Text = "Agregar CAI";
            this.cmdAddCai.Click += new System.EventHandler(this.cmdAddCai_Click);
            // 
            // TSCai
            // 
            this.TSCai.Location = new System.Drawing.Point(549, 131);
            this.TSCai.Name = "TSCai";
            this.TSCai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSCai.Properties.Appearance.Options.UseFont = true;
            this.TSCai.Properties.OffText = "Activos";
            this.TSCai.Properties.OnText = "Inactivos";
            this.TSCai.Size = new System.Drawing.Size(140, 28);
            this.TSCai.TabIndex = 5;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.ImageOptions.Image")));
            this.cmdCancelar.Location = new System.Drawing.Point(371, 419);
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
            this.cmdGuardar.Location = new System.Drawing.Point(146, 419);
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
            this.panelControl1.Location = new System.Drawing.Point(4, 164);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(694, 462);
            this.panelControl1.TabIndex = 18;
            // 
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.Enabled = false;
            this.txtCodigoProveedor.Location = new System.Drawing.Point(156, 61);
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoProveedor.Properties.NullValuePrompt = "Código";
            this.txtCodigoProveedor.Size = new System.Drawing.Size(74, 24);
            this.txtCodigoProveedor.TabIndex = 29;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(236, 61);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtProveedor.Properties.NullValuePrompt = "Nombre del Proveedor";
            this.txtProveedor.Size = new System.Drawing.Size(276, 24);
            this.txtProveedor.TabIndex = 26;
            // 
            // cmdAbrirBusqueda
            // 
            this.cmdAbrirBusqueda.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbrirBusqueda.Appearance.Options.UseFont = true;
            this.cmdAbrirBusqueda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAbrirBusqueda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAbrirBusqueda.ImageOptions.Image")));
            this.cmdAbrirBusqueda.Location = new System.Drawing.Point(531, 50);
            this.cmdAbrirBusqueda.Name = "cmdAbrirBusqueda";
            this.cmdAbrirBusqueda.Size = new System.Drawing.Size(44, 35);
            this.cmdAbrirBusqueda.TabIndex = 28;
            this.cmdAbrirBusqueda.Click += new System.EventHandler(this.cmdAbrirBusqueda_Click);
            // 
            // frmCAIProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 630);
            this.Controls.Add(this.txtCodigoProveedor);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.cmdAbrirBusqueda);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.TSCai);
            this.Controls.Add(this.cmdAddCai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridProv);
            this.Name = "frmCAIProv";
            this.Text = "frmCAIProv";
            ((System.ComponentModel.ISupportInitialize)(this.gridProv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caiprovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSCai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit gridProv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.GridControl gridControlCAI;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton cmdAddCai;
        private DevExpress.XtraEditors.ToggleSwitch TSCai;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private dsMante dsMante;
        private System.Windows.Forms.BindingSource caiprovBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcai;
        private DevExpress.XtraGrid.Columns.GridColumn colrango;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_limite;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemDelete;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtCodigoProveedor;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraEditors.SimpleButton cmdAbrirBusqueda;
    }
}
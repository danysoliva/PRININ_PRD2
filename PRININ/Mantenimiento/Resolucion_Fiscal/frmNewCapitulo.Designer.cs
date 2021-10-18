
namespace PRININ.Mantenimiento.Resolucion_Fiscal
{
    partial class frmNewCapitulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCapitulo));
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grLookEdit_Rubro = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblResolucion = new DevExpress.XtraEditors.LabelControl();
            this.grLookEdit_Capitulo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit3 = new DevExpress.XtraEditors.SpinEdit();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_cap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_rubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BS_Caps = new System.Windows.Forms.BindingSource(this.components);
            this.dsResolucion1 = new PRININ.Mantenimiento.Resolucion_Fiscal.dsResolucion();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.BS_RUbros = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grLookEdit_Rubro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grLookEdit_Capitulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Caps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResolucion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RUbros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Appearance.Options.UseTextOptions = true;
            this.btnCancelar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelar.ImageOptions.SvgImage")));
            this.btnCancelar.Location = new System.Drawing.Point(218, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 58);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Appearance.Options.UseTextOptions = true;
            this.btnGuardar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
            this.btnGuardar.Location = new System.Drawing.Point(97, 210);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 58);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 17);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Rubro";
            // 
            // grLookEdit_Rubro
            // 
            this.grLookEdit_Rubro.EditValue = "";
            this.grLookEdit_Rubro.Location = new System.Drawing.Point(120, 60);
            this.grLookEdit_Rubro.Name = "grLookEdit_Rubro";
            this.grLookEdit_Rubro.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grLookEdit_Rubro.Properties.Appearance.Options.UseFont = true;
            this.grLookEdit_Rubro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grLookEdit_Rubro.Properties.DataSource = this.BS_RUbros;
            this.grLookEdit_Rubro.Properties.DisplayMember = "descripcion";
            this.grLookEdit_Rubro.Properties.PopupFormSize = new System.Drawing.Size(500, 150);
            this.grLookEdit_Rubro.Properties.PopupView = this.gridLookUpEdit1View;
            this.grLookEdit_Rubro.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
            this.grLookEdit_Rubro.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDelete});
            this.grLookEdit_Rubro.Properties.ValueMember = "id";
            this.grLookEdit_Rubro.Size = new System.Drawing.Size(288, 24);
            this.grLookEdit_Rubro.TabIndex = 19;
            this.grLookEdit_Rubro.EditValueChanged += new System.EventHandler(this.grLookEdit_Rubro_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo,
            this.coldescripcion,
            this.colenable});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 24);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 17);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Resolución";
            // 
            // lblResolucion
            // 
            this.lblResolucion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblResolucion.Appearance.Options.UseFont = true;
            this.lblResolucion.Location = new System.Drawing.Point(120, 24);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(75, 17);
            this.lblResolucion.TabIndex = 21;
            this.lblResolucion.Text = "Resolución #";
            // 
            // grLookEdit_Capitulo
            // 
            this.grLookEdit_Capitulo.EditValue = "";
            this.grLookEdit_Capitulo.Location = new System.Drawing.Point(120, 90);
            this.grLookEdit_Capitulo.Name = "grLookEdit_Capitulo";
            this.grLookEdit_Capitulo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grLookEdit_Capitulo.Properties.Appearance.Options.UseFont = true;
            this.grLookEdit_Capitulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grLookEdit_Capitulo.Properties.DataSource = this.BS_Caps;
            this.grLookEdit_Capitulo.Properties.DisplayMember = "descripcion";
            this.grLookEdit_Capitulo.Properties.PopupFormSize = new System.Drawing.Size(500, 150);
            this.grLookEdit_Capitulo.Properties.PopupView = this.gridView1;
            this.grLookEdit_Capitulo.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
            this.grLookEdit_Capitulo.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.grLookEdit_Capitulo.Properties.ValueMember = "id";
            this.grLookEdit_Capitulo.Size = new System.Drawing.Size(288, 24);
            this.grLookEdit_Capitulo.TabIndex = 23;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colcodigo_cap,
            this.colenable1,
            this.colid_rubro,
            this.coldescripcion1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 93);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 17);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Capítulo";
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(120, 120);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(288, 24);
            this.spinEdit1.TabIndex = 24;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(15, 123);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 17);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Saldo Inicial";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(15, 153);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(99, 17);
            this.labelControl7.TabIndex = 27;
            this.labelControl7.Text = "Saldo Disponible";
            // 
            // spinEdit2
            // 
            this.spinEdit2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(120, 150);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.spinEdit2.Properties.Appearance.Options.UseFont = true;
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit2.Size = new System.Drawing.Size(288, 24);
            this.spinEdit2.TabIndex = 26;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(15, 183);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(69, 17);
            this.labelControl8.TabIndex = 29;
            this.labelControl8.Text = "Cant. Pagos";
            // 
            // spinEdit3
            // 
            this.spinEdit3.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit3.Location = new System.Drawing.Point(120, 180);
            this.spinEdit3.Name = "spinEdit3";
            this.spinEdit3.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.spinEdit3.Properties.Appearance.Options.UseFont = true;
            this.spinEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit3.Size = new System.Drawing.Size(288, 24);
            this.spinEdit3.TabIndex = 28;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 104;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 534;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colcodigo_cap
            // 
            this.colcodigo_cap.Caption = "Código";
            this.colcodigo_cap.FieldName = "codigo_cap";
            this.colcodigo_cap.Name = "colcodigo_cap";
            this.colcodigo_cap.Visible = true;
            this.colcodigo_cap.VisibleIndex = 0;
            this.colcodigo_cap.Width = 111;
            // 
            // colenable1
            // 
            this.colenable1.FieldName = "enable";
            this.colenable1.Name = "colenable1";
            // 
            // colid_rubro
            // 
            this.colid_rubro.FieldName = "id_rubro";
            this.colid_rubro.Name = "colid_rubro";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.Caption = "Descripción";
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            this.coldescripcion1.Width = 527;
            // 
            // BS_Caps
            // 
            this.BS_Caps.DataMember = "master_caps";
            this.BS_Caps.DataSource = this.dsResolucion1;
            // 
            // dsResolucion1
            // 
            this.dsResolucion1.DataSetName = "dsResolucion";
            this.dsResolucion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // BS_RUbros
            // 
            this.BS_RUbros.DataMember = "master_rubros";
            this.BS_RUbros.DataSource = this.dsResolucion1;
            // 
            // btnDelete
            // 
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmNewCapitulo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 277);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.spinEdit3);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.spinEdit2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.grLookEdit_Capitulo);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblResolucion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.grLookEdit_Rubro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelControl3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewCapitulo";
            this.Text = "Nuevo Saldo Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.grLookEdit_Rubro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grLookEdit_Capitulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Caps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResolucion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RUbros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit grLookEdit_Rubro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblResolucion;
        private DevExpress.XtraEditors.GridLookUpEdit grLookEdit_Capitulo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SpinEdit spinEdit3;
        private dsResolucion dsResolucion1;
        private System.Windows.Forms.BindingSource BS_RUbros;
        private System.Windows.Forms.BindingSource BS_Caps;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_cap;
        private DevExpress.XtraGrid.Columns.GridColumn colenable1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_rubro;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
    }
}

namespace PRININ.Notas_UNITE
{
    partial class frmTipoNotaCredito
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
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsNotasUNITE1 = new PRININ.Notas_UNITE.dsNotasUNITE();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_u = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateFechaVence = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtConcepto = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.pS_ButtonGuardar = new PRININ.Classes.PS_Button();
            this.pS_Button1 = new PRININ.Classes.PS_Button();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCuenta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.memoObservaciones = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotasUNITE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaVence.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaVence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObservaciones.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(150, 54);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.OffText = "No";
            this.toggleSwitch1.Properties.OnText = "Si";
            this.toggleSwitch1.Size = new System.Drawing.Size(133, 26);
            this.toggleSwitch1.TabIndex = 0;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(122, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nota por Articulos";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(150, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(263, 25);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Datos Adicionales Nota Crédito";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "detalle_nota";
            this.gridControl1.DataSource = this.dsNotasUNITE1;
            this.gridControl1.Location = new System.Drawing.Point(3, 218);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(570, 204);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsNotasUNITE1
            // 
            this.dsNotasUNITE1.DataSetName = "dsNotasUNITE";
            this.dsNotasUNITE1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcuenta,
            this.coldescripcion,
            this.colprecio,
            this.coltotal_linea,
            this.colcantidad_u,
            this.colcantidad_kg,
            this.colcodigo,
            this.colum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colcuenta
            // 
            this.colcuenta.FieldName = "cuenta";
            this.colcuenta.Name = "colcuenta";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 205;
            // 
            // colprecio
            // 
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 5;
            this.colprecio.Width = 60;
            // 
            // coltotal_linea
            // 
            this.coltotal_linea.FieldName = "total_linea";
            this.coltotal_linea.Name = "coltotal_linea";
            this.coltotal_linea.Visible = true;
            this.coltotal_linea.VisibleIndex = 6;
            this.coltotal_linea.Width = 88;
            // 
            // colcantidad_u
            // 
            this.colcantidad_u.FieldName = "cantidad_u";
            this.colcantidad_u.Name = "colcantidad_u";
            this.colcantidad_u.Visible = true;
            this.colcantidad_u.VisibleIndex = 3;
            this.colcantidad_u.Width = 67;
            // 
            // colcantidad_kg
            // 
            this.colcantidad_kg.FieldName = "cantidad_kg";
            this.colcantidad_kg.Name = "colcantidad_kg";
            this.colcantidad_kg.Visible = true;
            this.colcantidad_kg.VisibleIndex = 4;
            this.colcantidad_kg.Width = 69;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 63;
            // 
            // colum
            // 
            this.colum.Caption = "UM";
            this.colum.FieldName = "um";
            this.colum.Name = "colum";
            this.colum.OptionsColumn.AllowEdit = false;
            this.colum.Visible = true;
            this.colum.VisibleIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 196);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 20);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Detalle";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(3, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(128, 20);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Fecha Vencimiento:";
            // 
            // dateFechaVence
            // 
            this.dateFechaVence.EditValue = null;
            this.dateFechaVence.Location = new System.Drawing.Point(150, 108);
            this.dateFechaVence.Name = "dateFechaVence";
            this.dateFechaVence.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaVence.Properties.Appearance.Options.UseFont = true;
            this.dateFechaVence.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaVence.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaVence.Size = new System.Drawing.Size(133, 22);
            this.dateFechaVence.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(3, 137);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 20);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Concepto:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(150, 136);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Properties.ReadOnly = true;
            this.txtConcepto.Size = new System.Drawing.Size(423, 55);
            this.txtConcepto.TabIndex = 8;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(395, 428);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 20);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Valor:";
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(439, 424);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Properties.ReadOnly = true;
            this.spinEdit1.Size = new System.Drawing.Size(134, 28);
            this.spinEdit1.TabIndex = 10;
            // 
            // pS_ButtonGuardar
            // 
            this.pS_ButtonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pS_ButtonGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.pS_ButtonGuardar.BackColorButton = System.Drawing.Color.Gainsboro;
            this.pS_ButtonGuardar.BorderColorButton = System.Drawing.Color.Transparent;
            this.pS_ButtonGuardar.BorderRadius = 40;
            this.pS_ButtonGuardar.BorderSize = 0;
            this.pS_ButtonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.pS_ButtonGuardar.FlatAppearance.BorderSize = 0;
            this.pS_ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pS_ButtonGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pS_ButtonGuardar.ForeColor = System.Drawing.Color.Black;
            this.pS_ButtonGuardar.Location = new System.Drawing.Point(140, 548);
            this.pS_ButtonGuardar.Name = "pS_ButtonGuardar";
            this.pS_ButtonGuardar.Size = new System.Drawing.Size(150, 40);
            this.pS_ButtonGuardar.TabIndex = 47;
            this.pS_ButtonGuardar.Text = "Guardar";
            this.pS_ButtonGuardar.TextButton = "Guardar";
            this.pS_ButtonGuardar.TextColorButton = System.Drawing.Color.Black;
            this.pS_ButtonGuardar.UseVisualStyleBackColor = false;
            this.pS_ButtonGuardar.Click += new System.EventHandler(this.pS_ButtonGuardar_Click);
            // 
            // pS_Button1
            // 
            this.pS_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pS_Button1.BackColor = System.Drawing.Color.Black;
            this.pS_Button1.BackColorButton = System.Drawing.Color.Black;
            this.pS_Button1.BorderColorButton = System.Drawing.Color.PaleVioletRed;
            this.pS_Button1.BorderRadius = 40;
            this.pS_Button1.BorderSize = 0;
            this.pS_Button1.FlatAppearance.BorderSize = 0;
            this.pS_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pS_Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pS_Button1.ForeColor = System.Drawing.Color.White;
            this.pS_Button1.Location = new System.Drawing.Point(296, 548);
            this.pS_Button1.Name = "pS_Button1";
            this.pS_Button1.Size = new System.Drawing.Size(150, 40);
            this.pS_Button1.TabIndex = 46;
            this.pS_Button1.Text = "Cerrar";
            this.pS_Button1.TextButton = "Cerrar";
            this.pS_Button1.TextColorButton = System.Drawing.Color.White;
            this.pS_Button1.UseVisualStyleBackColor = false;
            this.pS_Button1.Click += new System.EventHandler(this.pS_Button1_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(3, 83);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 20);
            this.labelControl7.TabIndex = 49;
            this.labelControl7.Text = "Cuenta:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(150, 83);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(133, 20);
            this.txtCuenta.TabIndex = 50;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(3, 438);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(99, 20);
            this.labelControl8.TabIndex = 51;
            this.labelControl8.Text = "Observaciones:";
            // 
            // memoObservaciones
            // 
            this.memoObservaciones.Location = new System.Drawing.Point(3, 459);
            this.memoObservaciones.Name = "memoObservaciones";
            this.memoObservaciones.Size = new System.Drawing.Size(386, 82);
            this.memoObservaciones.TabIndex = 52;
            // 
            // frmTipoNotaCredito
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 594);
            this.Controls.Add(this.memoObservaciones);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.pS_ButtonGuardar);
            this.Controls.Add(this.pS_Button1);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.dateFechaVence);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toggleSwitch1);
            this.Name = "frmTipoNotaCredito";
            this.Text = "Detalle de la Nota";
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotasUNITE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaVence.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaVence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObservaciones.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txtConcepto;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private Classes.PS_Button pS_ButtonGuardar;
        private Classes.PS_Button pS_Button1;
        private dsNotasUNITE dsNotasUNITE1;
        private DevExpress.XtraGrid.Columns.GridColumn colcuenta;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_linea;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_u;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_kg;
        public DevExpress.XtraEditors.DateEdit dateFechaVence;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCuenta;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        public DevExpress.XtraEditors.MemoEdit memoObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colum;
    }
}
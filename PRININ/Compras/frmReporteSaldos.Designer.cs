namespace PRININ.Compras
{
    partial class frmReporteSaldos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteSaldos));
            this.dtFechaDesde = new DevExpress.XtraEditors.DateEdit();
            this.dtFechaHasta = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCargar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsCompras1 = new PRININ.Compras.dsCompras();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_capitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_rubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_rubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpagos_real = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpagos_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpagos_dispo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresolucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_inicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaldo_actual_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv_max = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv_actual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv_disponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacumulado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdExcel = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grResolucion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grResolucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.EditValue = new System.DateTime(2021, 6, 29, 0, 0, 0, 0);
            this.dtFechaDesde.Location = new System.Drawing.Point(147, 57);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaDesde.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesde.Size = new System.Drawing.Size(224, 26);
            this.dtFechaDesde.TabIndex = 24;
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.EditValue = new System.DateTime(2021, 6, 29, 0, 0, 0, 0);
            this.dtFechaHasta.Location = new System.Drawing.Point(147, 85);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaHasta.Properties.Appearance.Options.UseFont = true;
            this.dtFechaHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHasta.Size = new System.Drawing.Size(224, 26);
            this.dtFechaHasta.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fecha Desde:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(746, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Resolución:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha Hasta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Appearance.Options.UseFont = true;
            this.cmdCargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargar.ImageOptions.Image")));
            this.cmdCargar.Location = new System.Drawing.Point(377, 55);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(170, 56);
            this.cmdCargar.TabIndex = 29;
            this.cmdCargar.Text = "Cargar Datos";
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "saldos_rubros";
            this.gridControl1.DataSource = this.dsCompras1;
            this.gridControl1.Location = new System.Drawing.Point(2, 117);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1257, 332);
            this.gridControl1.TabIndex = 30;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_capitulo,
            this.colnombre,
            this.colid_rubro,
            this.colnom_rubro,
            this.colpagos_real,
            this.colpagos_orden,
            this.colpagos_dispo,
            this.colresolucion,
            this.colmonto_inicial,
            this.colsaldo_actual_,
            this.colDisponible,
            this.colisv_max,
            this.colisv_actual,
            this.colisv_disponible,
            this.colfecha_vence,
            this.colacumulado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_capitulo
            // 
            this.colid_capitulo.Caption = "Cod. Cap.";
            this.colid_capitulo.FieldName = "cod_capitulo";
            this.colid_capitulo.Name = "colid_capitulo";
            this.colid_capitulo.Visible = true;
            this.colid_capitulo.VisibleIndex = 0;
            this.colid_capitulo.Width = 90;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Capítulo";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 150;
            // 
            // colid_rubro
            // 
            this.colid_rubro.Caption = "Cod. Rubro";
            this.colid_rubro.FieldName = "id_rubro";
            this.colid_rubro.Name = "colid_rubro";
            this.colid_rubro.Visible = true;
            this.colid_rubro.VisibleIndex = 2;
            this.colid_rubro.Width = 90;
            // 
            // colnom_rubro
            // 
            this.colnom_rubro.Caption = "Rubro";
            this.colnom_rubro.FieldName = "nom_rubro";
            this.colnom_rubro.Name = "colnom_rubro";
            this.colnom_rubro.Visible = true;
            this.colnom_rubro.VisibleIndex = 3;
            this.colnom_rubro.Width = 150;
            // 
            // colpagos_real
            // 
            this.colpagos_real.Caption = "Cant. Pagos Real";
            this.colpagos_real.FieldName = "pagos_real";
            this.colpagos_real.Name = "colpagos_real";
            this.colpagos_real.OptionsColumn.AllowEdit = false;
            this.colpagos_real.Visible = true;
            this.colpagos_real.VisibleIndex = 11;
            this.colpagos_real.Width = 90;
            // 
            // colpagos_orden
            // 
            this.colpagos_orden.Caption = "Pagos Cons.";
            this.colpagos_orden.FieldName = "pagos_orden";
            this.colpagos_orden.Name = "colpagos_orden";
            this.colpagos_orden.OptionsColumn.AllowEdit = false;
            this.colpagos_orden.Visible = true;
            this.colpagos_orden.VisibleIndex = 12;
            this.colpagos_orden.Width = 90;
            // 
            // colpagos_dispo
            // 
            this.colpagos_dispo.Caption = "Pagos Dis.";
            this.colpagos_dispo.FieldName = "pagos_dispo";
            this.colpagos_dispo.Name = "colpagos_dispo";
            this.colpagos_dispo.OptionsColumn.AllowEdit = false;
            this.colpagos_dispo.Visible = true;
            this.colpagos_dispo.VisibleIndex = 13;
            this.colpagos_dispo.Width = 90;
            // 
            // colresolucion
            // 
            this.colresolucion.Caption = "Resolución";
            this.colresolucion.FieldName = "res";
            this.colresolucion.Name = "colresolucion";
            this.colresolucion.OptionsColumn.AllowEdit = false;
            this.colresolucion.Visible = true;
            this.colresolucion.VisibleIndex = 14;
            this.colresolucion.Width = 90;
            // 
            // colmonto_inicial
            // 
            this.colmonto_inicial.Caption = "Monto Inicial";
            this.colmonto_inicial.DisplayFormat.FormatString = "###,##0.00";
            this.colmonto_inicial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmonto_inicial.FieldName = "monto_inicial";
            this.colmonto_inicial.Name = "colmonto_inicial";
            this.colmonto_inicial.OptionsColumn.AllowEdit = false;
            this.colmonto_inicial.Visible = true;
            this.colmonto_inicial.VisibleIndex = 4;
            this.colmonto_inicial.Width = 97;
            // 
            // colsaldo_actual_
            // 
            this.colsaldo_actual_.Caption = "Monto Rango Fecha";
            this.colsaldo_actual_.DisplayFormat.FormatString = "###,##0.00";
            this.colsaldo_actual_.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsaldo_actual_.FieldName = "saldo_actual_";
            this.colsaldo_actual_.Name = "colsaldo_actual_";
            this.colsaldo_actual_.OptionsColumn.AllowEdit = false;
            this.colsaldo_actual_.Visible = true;
            this.colsaldo_actual_.VisibleIndex = 6;
            this.colsaldo_actual_.Width = 120;
            // 
            // colDisponible
            // 
            this.colDisponible.Caption = "Disponible";
            this.colDisponible.DisplayFormat.FormatString = "###,##0.00";
            this.colDisponible.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDisponible.FieldName = "Disponible";
            this.colDisponible.Name = "colDisponible";
            this.colDisponible.OptionsColumn.AllowEdit = false;
            this.colDisponible.Visible = true;
            this.colDisponible.VisibleIndex = 7;
            this.colDisponible.Width = 112;
            // 
            // colisv_max
            // 
            this.colisv_max.Caption = "ISV Inicial";
            this.colisv_max.DisplayFormat.FormatString = "###,##0.00";
            this.colisv_max.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colisv_max.FieldName = "isv_max";
            this.colisv_max.Name = "colisv_max";
            this.colisv_max.OptionsColumn.AllowEdit = false;
            this.colisv_max.Visible = true;
            this.colisv_max.VisibleIndex = 8;
            this.colisv_max.Width = 112;
            // 
            // colisv_actual
            // 
            this.colisv_actual.Caption = "ISV Usado";
            this.colisv_actual.DisplayFormat.FormatString = "###,##0.00";
            this.colisv_actual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colisv_actual.FieldName = "isv_actual";
            this.colisv_actual.Name = "colisv_actual";
            this.colisv_actual.OptionsColumn.AllowEdit = false;
            this.colisv_actual.Visible = true;
            this.colisv_actual.VisibleIndex = 9;
            this.colisv_actual.Width = 112;
            // 
            // colisv_disponible
            // 
            this.colisv_disponible.Caption = "ISV Disponible";
            this.colisv_disponible.DisplayFormat.FormatString = "###,##0.00";
            this.colisv_disponible.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colisv_disponible.FieldName = "isv_disponible";
            this.colisv_disponible.Name = "colisv_disponible";
            this.colisv_disponible.OptionsColumn.AllowEdit = false;
            this.colisv_disponible.Visible = true;
            this.colisv_disponible.VisibleIndex = 10;
            this.colisv_disponible.Width = 120;
            // 
            // colfecha_vence
            // 
            this.colfecha_vence.Caption = "Fecha Venc.";
            this.colfecha_vence.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colfecha_vence.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_vence.FieldName = "fecha_vence";
            this.colfecha_vence.Name = "colfecha_vence";
            this.colfecha_vence.OptionsColumn.AllowEdit = false;
            this.colfecha_vence.Visible = true;
            this.colfecha_vence.VisibleIndex = 15;
            this.colfecha_vence.Width = 120;
            // 
            // colacumulado
            // 
            this.colacumulado.Caption = "Monto Usado Acum.";
            this.colacumulado.DisplayFormat.FormatString = "###,##0.00";
            this.colacumulado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colacumulado.FieldName = "acumulado";
            this.colacumulado.Name = "colacumulado";
            this.colacumulado.Visible = true;
            this.colacumulado.VisibleIndex = 5;
            this.colacumulado.Width = 120;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 27;
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Width = 100;
            // 
            // cmdExcel
            // 
            this.cmdExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcel.Appearance.Options.UseFont = true;
            this.cmdExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExcel.ImageOptions.Image")));
            this.cmdExcel.Location = new System.Drawing.Point(553, 55);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(170, 56);
            this.cmdExcel.TabIndex = 31;
            this.cmdExcel.Text = "Exportar a Excel";
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(53, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1156, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Saldos por Rubro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 32;
            this.label3.Text = "Rango";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grResolucion
            // 
            this.grResolucion.EditValue = "";
            this.grResolucion.Location = new System.Drawing.Point(871, 55);
            this.grResolucion.Name = "grResolucion";
            this.grResolucion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.grResolucion.Properties.Appearance.Options.UseFont = true;
            this.grResolucion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grResolucion.Properties.DataSource = this.bindingSource3;
            this.grResolucion.Properties.DisplayMember = "descripcion";
            this.grResolucion.Properties.ValueMember = "codigo";
            this.grResolucion.Size = new System.Drawing.Size(125, 24);
            this.grResolucion.TabIndex = 8;
            this.grResolucion.TabIndexChanged += new System.EventHandler(this.cmdCargar_Click);
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "resolucion";
            this.bindingSource3.DataSource = this.dsCompras1;
            // 
            // frmReporteSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 450);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaDesde);
            this.Controls.Add(this.dtFechaHasta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grResolucion);
            this.Name = "frmReporteSaldos";
            this.Text = "Reporte Saldos";
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grResolucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtFechaDesde;
        private DevExpress.XtraEditors.DateEdit dtFechaHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton cmdCargar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsCompras dsCompras1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_capitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colid_rubro;
        private DevExpress.XtraGrid.Columns.GridColumn colpagos_real;
        private DevExpress.XtraGrid.Columns.GridColumn colresolucion; 
        private DevExpress.XtraGrid.Columns.GridColumn colpagos_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colpagos_dispo;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_rubro;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_inicial;
        private DevExpress.XtraGrid.Columns.GridColumn colsaldo_actual_;
        private DevExpress.XtraGrid.Columns.GridColumn colDisponible;
        private DevExpress.XtraGrid.Columns.GridColumn colisv_max;
        private DevExpress.XtraGrid.Columns.GridColumn colisv_actual;
        private DevExpress.XtraGrid.Columns.GridColumn colisv_disponible;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vence;
        private DevExpress.XtraEditors.SimpleButton cmdExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn colacumulado;
        private DevExpress.XtraEditors.GridLookUpEdit grResolucion;
        private System.Windows.Forms.BindingSource bindingSource3;
    }
}
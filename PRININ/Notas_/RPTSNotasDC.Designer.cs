namespace PRININ.Notas
{
    partial class RPTSNotasDC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPTSNotasDC));
            this.cmdExcel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.rptsnotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNotas = new PRININ.Notas.dsNotas();
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
            this.colid_doc_fiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdCargar = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaDesde = new DevExpress.XtraEditors.DateEdit();
            this.dtFechaHasta = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboNota = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptsnotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdExcel
            // 
            this.cmdExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcel.Appearance.Options.UseFont = true;
            this.cmdExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExcel.ImageOptions.Image")));
            this.cmdExcel.Location = new System.Drawing.Point(553, 66);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(170, 56);
            this.cmdExcel.TabIndex = 40;
            this.cmdExcel.Text = "Exportar a Excel";
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.rptsnotasBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 147);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1514, 500);
            this.gridControl1.TabIndex = 39;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // rptsnotasBindingSource
            // 
            this.rptsnotasBindingSource.DataMember = "rpts_notas";
            this.rptsnotasBindingSource.DataSource = this.dsNotas;
            // 
            // dsNotas
            // 
            this.dsNotas.DataSetName = "dsNotas";
            this.dsNotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.colid_doc_fiscal,
            this.coltasa,
            this.colnombre});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Codigo";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // coltipo_nota
            // 
            this.coltipo_nota.FieldName = "tipo_nota";
            this.coltipo_nota.Name = "coltipo_nota";
            // 
            // colfecha_cr
            // 
            this.colfecha_cr.Caption = "Creado";
            this.colfecha_cr.FieldName = "fecha_cr";
            this.colfecha_cr.Name = "colfecha_cr";
            this.colfecha_cr.Visible = true;
            this.colfecha_cr.VisibleIndex = 3;
            // 
            // colcai
            // 
            this.colcai.Caption = "CAI";
            this.colcai.FieldName = "cai";
            this.colcai.Name = "colcai";
            this.colcai.Visible = true;
            this.colcai.VisibleIndex = 9;
            // 
            // colcod_cliente
            // 
            this.colcod_cliente.Caption = "Codigo Cliente";
            this.colcod_cliente.FieldName = "cod_cliente";
            this.colcod_cliente.Name = "colcod_cliente";
            this.colcod_cliente.Visible = true;
            this.colcod_cliente.VisibleIndex = 2;
            // 
            // colcredito
            // 
            this.colcredito.Caption = "Credito ";
            this.colcredito.FieldName = "credito";
            this.colcredito.Name = "colcredito";
            this.colcredito.Visible = true;
            this.colcredito.VisibleIndex = 5;
            // 
            // coldebito
            // 
            this.coldebito.Caption = "Debito";
            this.coldebito.FieldName = "debito";
            this.coldebito.Name = "coldebito";
            this.coldebito.Visible = true;
            this.coldebito.VisibleIndex = 6;
            // 
            // colmonto_letras
            // 
            this.colmonto_letras.Caption = "Monto en Letras";
            this.colmonto_letras.FieldName = "monto_letras";
            this.colmonto_letras.Name = "colmonto_letras";
            this.colmonto_letras.Visible = true;
            this.colmonto_letras.VisibleIndex = 7;
            // 
            // colconcepto
            // 
            this.colconcepto.Caption = "Concepto";
            this.colconcepto.FieldName = "concepto";
            this.colconcepto.Name = "colconcepto";
            this.colconcepto.Visible = true;
            this.colconcepto.VisibleIndex = 8;
            // 
            // colnum_documento
            // 
            this.colnum_documento.Caption = "Num. Documento";
            this.colnum_documento.FieldName = "num_documento";
            this.colnum_documento.Name = "colnum_documento";
            this.colnum_documento.Visible = true;
            this.colnum_documento.VisibleIndex = 1;
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
            this.colrtn.Visible = true;
            this.colrtn.VisibleIndex = 10;
            // 
            // colfecha_doc
            // 
            this.colfecha_doc.Caption = "Fecha de Documento";
            this.colfecha_doc.FieldName = "fecha_doc";
            this.colfecha_doc.Name = "colfecha_doc";
            this.colfecha_doc.Visible = true;
            this.colfecha_doc.VisibleIndex = 11;
            // 
            // colid_doc_fiscal
            // 
            this.colid_doc_fiscal.FieldName = "id_doc_fiscal";
            this.colid_doc_fiscal.Name = "colid_doc_fiscal";
            // 
            // coltasa
            // 
            this.coltasa.Caption = "TASA";
            this.coltasa.FieldName = "tasa";
            this.coltasa.Name = "coltasa";
            this.coltasa.Visible = true;
            this.coltasa.VisibleIndex = 12;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Tipo de Nota";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 4;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Appearance.Options.UseFont = true;
            this.cmdCargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargar.ImageOptions.Image")));
            this.cmdCargar.Location = new System.Drawing.Point(377, 66);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(170, 56);
            this.cmdCargar.TabIndex = 38;
            this.cmdCargar.Text = "Cargar Datos";
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Fecha Hasta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.EditValue = null;
            this.dtFechaDesde.Location = new System.Drawing.Point(147, 68);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaDesde.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesde.Size = new System.Drawing.Size(224, 26);
            this.dtFechaDesde.TabIndex = 33;
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.EditValue = null;
            this.dtFechaHasta.Location = new System.Drawing.Point(147, 96);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaHasta.Properties.Appearance.Options.UseFont = true;
            this.dtFechaHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHasta.Size = new System.Drawing.Size(224, 26);
            this.dtFechaHasta.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fecha Desde:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 41;
            this.label3.Text = "Rango";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(53, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1459, 31);
            this.label2.TabIndex = 37;
            this.label2.Text = "Reporte de Notas ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1412, 20);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 54);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(827, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tipo de nota:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboNota
            // 
            this.comboNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNota.FormattingEnabled = true;
            this.comboNota.Items.AddRange(new object[] {
            "Nota de Debito",
            "Nota de Credito"});
            this.comboNota.Location = new System.Drawing.Point(941, 65);
            this.comboNota.Name = "comboNota";
            this.comboNota.Size = new System.Drawing.Size(160, 28);
            this.comboNota.TabIndex = 44;
            // 
            // RPTSNotasDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 659);
            this.Controls.Add(this.comboNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaDesde);
            this.Controls.Add(this.dtFechaHasta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "RPTSNotasDC";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptsnotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdExcel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdCargar;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtFechaDesde;
        private DevExpress.XtraEditors.DateEdit dtFechaHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private System.Windows.Forms.BindingSource rptsnotasBindingSource;
        private dsNotas dsNotas;
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
        private DevExpress.XtraGrid.Columns.GridColumn colid_doc_fiscal;
        private DevExpress.XtraGrid.Columns.GridColumn coltasa;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboNota;
    }
}
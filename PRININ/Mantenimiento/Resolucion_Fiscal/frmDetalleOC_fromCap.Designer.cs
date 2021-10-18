
namespace PRININ.Mantenimiento.Resolucion_Fiscal
{
    partial class frmDetalleOC_fromCap
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
            this.dsResolucion1 = new PRININ.Mantenimiento.Resolucion_Fiscal.dsResolucion();
            this.cmdExcel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoneda1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCerrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumOCPRININ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumOCSAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCódigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripción = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFila = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsResolucion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsResolucion1
            // 
            this.dsResolucion1.DataSetName = "dsResolucion";
            this.dsResolucion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcel.Appearance.Options.UseFont = true;
            this.cmdExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExcel.ImageOptions.Image = global::PRININ.Properties.Resources.excel64px;
            this.cmdExcel.Location = new System.Drawing.Point(700, 20);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(170, 35);
            this.cmdExcel.TabIndex = 33;
            this.cmdExcel.Text = "Exportar a Excel";
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_oc_from_cap";
            this.gridControl1.DataSource = this.dsResolucion1;
            this.gridControl1.Location = new System.Drawing.Point(0, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(870, 495);
            this.gridControl1.TabIndex = 34;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colProveedor,
            this.gridColumn1,
            this.colFecha,
            this.colmoneda,
            this.colMoneda1,
            this.colCerrada,
            this.colNumOCPRININ,
            this.colNumFact,
            this.colNumOCSAR,
            this.colCódigo,
            this.colDescripción,
            this.colCantidad,
            this.colPrecio,
            this.colTotalFila});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colProveedor
            // 
            this.colProveedor.FieldName = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.OptionsColumn.AllowEdit = false;
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 1;
            this.colProveedor.Width = 72;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Cod. Proveedor";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 58;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            this.colFecha.Width = 72;
            // 
            // colmoneda
            // 
            this.colmoneda.FieldName = "moneda";
            this.colmoneda.Name = "colmoneda";
            this.colmoneda.OptionsColumn.AllowEdit = false;
            // 
            // colMoneda1
            // 
            this.colMoneda1.Caption = "Moneda";
            this.colMoneda1.FieldName = "moneda_";
            this.colMoneda1.Name = "colMoneda1";
            this.colMoneda1.OptionsColumn.AllowEdit = false;
            this.colMoneda1.Width = 72;
            // 
            // colCerrada
            // 
            this.colCerrada.FieldName = "Cerrada";
            this.colCerrada.Name = "colCerrada";
            this.colCerrada.OptionsColumn.AllowEdit = false;
            // 
            // colNumOCPRININ
            // 
            this.colNumOCPRININ.FieldName = "Num OC PRININ";
            this.colNumOCPRININ.Name = "colNumOCPRININ";
            this.colNumOCPRININ.OptionsColumn.AllowEdit = false;
            this.colNumOCPRININ.Visible = true;
            this.colNumOCPRININ.VisibleIndex = 3;
            this.colNumOCPRININ.Width = 82;
            // 
            // colNumFact
            // 
            this.colNumFact.FieldName = "Num Fact";
            this.colNumFact.Name = "colNumFact";
            this.colNumFact.OptionsColumn.AllowEdit = false;
            this.colNumFact.Visible = true;
            this.colNumFact.VisibleIndex = 4;
            this.colNumFact.Width = 82;
            // 
            // colNumOCSAR
            // 
            this.colNumOCSAR.FieldName = "Num OC SAR";
            this.colNumOCSAR.Name = "colNumOCSAR";
            this.colNumOCSAR.OptionsColumn.AllowEdit = false;
            this.colNumOCSAR.Visible = true;
            this.colNumOCSAR.VisibleIndex = 5;
            this.colNumOCSAR.Width = 86;
            // 
            // colCódigo
            // 
            this.colCódigo.FieldName = "Codigo";
            this.colCódigo.Name = "colCódigo";
            this.colCódigo.OptionsColumn.AllowEdit = false;
            this.colCódigo.Visible = true;
            this.colCódigo.VisibleIndex = 6;
            this.colCódigo.Width = 45;
            // 
            // colDescripción
            // 
            this.colDescripción.FieldName = "Descripción";
            this.colDescripción.Name = "colDescripción";
            this.colDescripción.OptionsColumn.AllowEdit = false;
            this.colDescripción.Visible = true;
            this.colDescripción.VisibleIndex = 7;
            this.colDescripción.Width = 80;
            // 
            // colCantidad
            // 
            this.colCantidad.DisplayFormat.FormatString = "n2";
            this.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 8;
            this.colCantidad.Width = 53;
            // 
            // colPrecio
            // 
            this.colPrecio.DisplayFormat.FormatString = "n2";
            this.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.OptionsColumn.AllowEdit = false;
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 9;
            this.colPrecio.Width = 62;
            // 
            // colTotalFila
            // 
            this.colTotalFila.DisplayFormat.FormatString = "n2";
            this.colTotalFila.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalFila.FieldName = "Total Fila";
            this.colTotalFila.Name = "colTotalFila";
            this.colTotalFila.OptionsColumn.AllowEdit = false;
            this.colTotalFila.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total Fila", "SUM={0: #,###,##0.00}")});
            this.colTotalFila.Visible = true;
            this.colTotalFila.VisibleIndex = 10;
            this.colTotalFila.Width = 88;
            // 
            // frmDetalleOC_fromCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 557);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdExcel);
            this.Name = "frmDetalleOC_fromCap";
            this.Text = "Detalle de Ordenes de Compra por Capítulo";
            ((System.ComponentModel.ISupportInitialize)(this.dsResolucion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsResolucion dsResolucion1;
        private DevExpress.XtraEditors.SimpleButton cmdExcel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colMoneda1;
        private DevExpress.XtraGrid.Columns.GridColumn colCerrada;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOCPRININ;
        private DevExpress.XtraGrid.Columns.GridColumn colNumFact;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOCSAR;
        private DevExpress.XtraGrid.Columns.GridColumn colCódigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripción;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFila;
    }
}
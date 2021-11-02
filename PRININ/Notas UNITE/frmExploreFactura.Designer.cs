
namespace PRININ.Notas_UNITE
{
    partial class frmExploreFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExploreFactura));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsFacturasPRD1 = new PRININ.Factura.dsFacturasPRD();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinvoice_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinvoice_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcustomer_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcustomer_long_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcustomer_rtn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcust_po_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colshipping_addess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colshipping_country = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_currency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_factura_hn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colSource = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasPRD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "home_facturas";
            this.gridControl1.DataSource = this.dsFacturasPRD1;
            this.gridControl1.Location = new System.Drawing.Point(1, 81);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditar});
            this.gridControl1.Size = new System.Drawing.Size(1103, 484);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsFacturasPRD1
            // 
            this.dsFacturasPRD1.DataSetName = "dsFacturasPRD";
            this.dsFacturasPRD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colinvoice_number,
            this.colinvoice_date,
            this.colcustomer_code,
            this.colcustomer_long_name,
            this.colcustomer_rtn,
            this.colcust_po_number,
            this.colshipping_addess,
            this.colshipping_country,
            this.colid_currency,
            this.colnumero_factura_hn,
            this.colEdit,
            this.colSource});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colinvoice_number
            // 
            this.colinvoice_number.Caption = "Número Factura United";
            this.colinvoice_number.FieldName = "invoice_number";
            this.colinvoice_number.Name = "colinvoice_number";
            this.colinvoice_number.OptionsColumn.AllowEdit = false;
            this.colinvoice_number.Visible = true;
            this.colinvoice_number.VisibleIndex = 0;
            this.colinvoice_number.Width = 122;
            // 
            // colinvoice_date
            // 
            this.colinvoice_date.Caption = "Fecha Factura";
            this.colinvoice_date.FieldName = "invoice_date";
            this.colinvoice_date.Name = "colinvoice_date";
            this.colinvoice_date.OptionsColumn.AllowEdit = false;
            this.colinvoice_date.Visible = true;
            this.colinvoice_date.VisibleIndex = 2;
            this.colinvoice_date.Width = 84;
            // 
            // colcustomer_code
            // 
            this.colcustomer_code.Caption = "Código Cliente";
            this.colcustomer_code.FieldName = "customer_code";
            this.colcustomer_code.Name = "colcustomer_code";
            this.colcustomer_code.OptionsColumn.AllowEdit = false;
            this.colcustomer_code.Visible = true;
            this.colcustomer_code.VisibleIndex = 3;
            this.colcustomer_code.Width = 65;
            // 
            // colcustomer_long_name
            // 
            this.colcustomer_long_name.Caption = "Cliente";
            this.colcustomer_long_name.FieldName = "customer_long_name";
            this.colcustomer_long_name.Name = "colcustomer_long_name";
            this.colcustomer_long_name.OptionsColumn.AllowEdit = false;
            this.colcustomer_long_name.Visible = true;
            this.colcustomer_long_name.VisibleIndex = 4;
            this.colcustomer_long_name.Width = 134;
            // 
            // colcustomer_rtn
            // 
            this.colcustomer_rtn.Caption = "RTN";
            this.colcustomer_rtn.FieldName = "customer_rtn";
            this.colcustomer_rtn.Name = "colcustomer_rtn";
            this.colcustomer_rtn.OptionsColumn.AllowEdit = false;
            this.colcustomer_rtn.Visible = true;
            this.colcustomer_rtn.VisibleIndex = 5;
            this.colcustomer_rtn.Width = 119;
            // 
            // colcust_po_number
            // 
            this.colcust_po_number.Caption = "OC Cliente";
            this.colcust_po_number.FieldName = "cust_po_number";
            this.colcust_po_number.Name = "colcust_po_number";
            this.colcust_po_number.OptionsColumn.AllowEdit = false;
            this.colcust_po_number.Visible = true;
            this.colcust_po_number.VisibleIndex = 6;
            this.colcust_po_number.Width = 81;
            // 
            // colshipping_addess
            // 
            this.colshipping_addess.Caption = "Dirección";
            this.colshipping_addess.FieldName = "shipping_addess";
            this.colshipping_addess.Name = "colshipping_addess";
            this.colshipping_addess.OptionsColumn.AllowEdit = false;
            this.colshipping_addess.Width = 128;
            // 
            // colshipping_country
            // 
            this.colshipping_country.Caption = "País";
            this.colshipping_country.FieldName = "shipping_country";
            this.colshipping_country.Name = "colshipping_country";
            this.colshipping_country.OptionsColumn.AllowEdit = false;
            this.colshipping_country.Visible = true;
            this.colshipping_country.VisibleIndex = 8;
            this.colshipping_country.Width = 60;
            // 
            // colid_currency
            // 
            this.colid_currency.Caption = "Moneda";
            this.colid_currency.FieldName = "id_currency";
            this.colid_currency.Name = "colid_currency";
            this.colid_currency.OptionsColumn.AllowEdit = false;
            this.colid_currency.Visible = true;
            this.colid_currency.VisibleIndex = 9;
            this.colid_currency.Width = 69;
            // 
            // colnumero_factura_hn
            // 
            this.colnumero_factura_hn.Caption = "Número Factura Fiscal";
            this.colnumero_factura_hn.FieldName = "numero_factura_hn";
            this.colnumero_factura_hn.Name = "colnumero_factura_hn";
            this.colnumero_factura_hn.OptionsColumn.AllowEdit = false;
            this.colnumero_factura_hn.Visible = true;
            this.colnumero_factura_hn.VisibleIndex = 1;
            this.colnumero_factura_hn.Width = 160;
            // 
            // colEdit
            // 
            this.colEdit.Caption = "Seleccionar";
            this.colEdit.ColumnEdit = this.cmdEditar;
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 10;
            this.colEdit.Width = 92;
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdEditar_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(1, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(196, 25);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Seleccione una Factura";
            // 
            // colSource
            // 
            this.colSource.Caption = "Sistema Origen";
            this.colSource.FieldName = "Source";
            this.colSource.Name = "colSource";
            this.colSource.Visible = true;
            this.colSource.VisibleIndex = 7;
            // 
            // frmExploreFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 567);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmExploreFactura";
            this.Text = "Buscar Factura";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasPRD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colinvoice_number;
        private DevExpress.XtraGrid.Columns.GridColumn colinvoice_date;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_code;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_long_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_rtn;
        private DevExpress.XtraGrid.Columns.GridColumn colcust_po_number;
        private DevExpress.XtraGrid.Columns.GridColumn colshipping_addess;
        private DevExpress.XtraGrid.Columns.GridColumn colshipping_country;
        private DevExpress.XtraGrid.Columns.GridColumn colid_currency;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_factura_hn;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Factura.dsFacturasPRD dsFacturasPRD1;
        private DevExpress.XtraGrid.Columns.GridColumn colSource;
    }
}
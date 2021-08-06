namespace PRININ.Pedidos
{
    partial class frmAddProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProd));
            this.gridProductos = new DevExpress.XtraGrid.GridControl();
            this.dsPedidos = new PRININ.Pedidos.dsPedidos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnumero_articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheckadd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdSalir = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProductos
            // 
            this.gridProductos.DataMember = "addProducto";
            this.gridProductos.DataSource = this.dsPedidos;
            this.gridProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProductos.Location = new System.Drawing.Point(2, 2);
            this.gridProductos.MainView = this.gridView1;
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(817, 483);
            this.gridProductos.TabIndex = 0;
            this.gridProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsPedidos
            // 
            this.dsPedidos.DataSetName = "dsPedidos";
            this.dsPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnumero_articulo,
            this.coldescripcion,
            this.colcheckadd,
            this.colprecio_unit});
            this.gridView1.GridControl = this.gridProductos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // colnumero_articulo
            // 
            this.colnumero_articulo.Caption = "Numero de Articulo";
            this.colnumero_articulo.FieldName = "numero_articulo";
            this.colnumero_articulo.Name = "colnumero_articulo";
            this.colnumero_articulo.OptionsColumn.AllowEdit = false;
            this.colnumero_articulo.Visible = true;
            this.colnumero_articulo.VisibleIndex = 0;
            this.colnumero_articulo.Width = 154;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 308;
            // 
            // colcheckadd
            // 
            this.colcheckadd.Caption = "Seleccionar:";
            this.colcheckadd.FieldName = "checkadd";
            this.colcheckadd.Name = "colcheckadd";
            this.colcheckadd.Visible = true;
            this.colcheckadd.VisibleIndex = 3;
            this.colcheckadd.Width = 131;
            // 
            // colprecio_unit
            // 
            this.colprecio_unit.Caption = "Precio Unitario";
            this.colprecio_unit.FieldName = "precio_unit";
            this.colprecio_unit.Name = "colprecio_unit";
            this.colprecio_unit.OptionsColumn.AllowEdit = false;
            this.colprecio_unit.Visible = true;
            this.colprecio_unit.VisibleIndex = 2;
            this.colprecio_unit.Width = 206;
            // 
            // addProductoBindingSource
            // 
            this.addProductoBindingSource.DataMember = "addProducto";
            this.addProductoBindingSource.DataSource = this.dsPedidos;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.gridProductos);
            this.panelControl1.Location = new System.Drawing.Point(2, 94);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(821, 487);
            this.panelControl1.TabIndex = 1;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Appearance.Options.UseFont = true;
            this.cmdSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSalir.ImageOptions.Image = global::PRININ.Properties.Resources.cancel_32;
            this.cmdSalir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSalir.Location = new System.Drawing.Point(768, 45);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(47, 43);
            this.cmdSalir.TabIndex = 99;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 19);
            this.label1.TabIndex = 101;
            this.label1.Text = "Seleccione los Productos";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Appearance.Options.UseFont = true;
            this.cmdAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAdd.ImageOptions.Image = global::PRININ.Properties.Resources.ok_32;
            this.cmdAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdAdd.Location = new System.Drawing.Point(12, 45);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(47, 43);
            this.cmdAdd.TabIndex = 102;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // frmAddProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 591);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddProd";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdSalir;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton cmdAdd;
        private dsPedidos dsPedidos;
        private System.Windows.Forms.BindingSource addProductoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_articulo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcheckadd;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio_unit;
    }
}
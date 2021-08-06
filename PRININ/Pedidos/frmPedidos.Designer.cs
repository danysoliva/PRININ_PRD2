namespace PRININ.Pedidos
{
    partial class frmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos));
            this.gridPedidos = new DevExpress.XtraGrid.GridControl();
            this.dsPedidos = new PRININ.Pedidos.dsPedidos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_pedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente_direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion_entrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_pedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_entrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSunumero_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcond_entrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmetood_entrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colntra_ref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSalir = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPedidos
            // 
            this.gridPedidos.DataMember = "resumenpedidos";
            this.gridPedidos.DataSource = this.dsPedidos;
            this.gridPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPedidos.Location = new System.Drawing.Point(2, 2);
            this.gridPedidos.MainView = this.gridView1;
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPrint});
            this.gridPedidos.Size = new System.Drawing.Size(1194, 502);
            this.gridPedidos.TabIndex = 5;
            this.gridPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colid,
            this.colnumero_pedido,
            this.colcod_cliente,
            this.colcliente,
            this.colcliente_direccion,
            this.coldireccion_entrega,
            this.colfecha_pedido,
            this.colfecha_entrega,
            this.colcontacto,
            this.colSunumero_orden,
            this.colcond_entrega,
            this.colmetood_entrega,
            this.colmoneda,
            this.colnumero_orden,
            this.colntra_ref,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridPedidos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colnumero_pedido
            // 
            this.colnumero_pedido.Caption = "Numero de Pedido";
            this.colnumero_pedido.FieldName = "numero_pedido";
            this.colnumero_pedido.Name = "colnumero_pedido";
            this.colnumero_pedido.OptionsColumn.AllowEdit = false;
            this.colnumero_pedido.Visible = true;
            this.colnumero_pedido.VisibleIndex = 0;
            // 
            // colcod_cliente
            // 
            this.colcod_cliente.FieldName = "cod_cliente";
            this.colcod_cliente.Name = "colcod_cliente";
            this.colcod_cliente.OptionsColumn.AllowEdit = false;
            // 
            // colcliente
            // 
            this.colcliente.Caption = "Cliente";
            this.colcliente.FieldName = "cliente";
            this.colcliente.Name = "colcliente";
            this.colcliente.OptionsColumn.AllowEdit = false;
            this.colcliente.Visible = true;
            this.colcliente.VisibleIndex = 1;
            // 
            // colcliente_direccion
            // 
            this.colcliente_direccion.FieldName = "cliente_direccion";
            this.colcliente_direccion.Name = "colcliente_direccion";
            this.colcliente_direccion.OptionsColumn.AllowEdit = false;
            // 
            // coldireccion_entrega
            // 
            this.coldireccion_entrega.Caption = "Direccion de Entrega";
            this.coldireccion_entrega.FieldName = "direccion_entrega";
            this.coldireccion_entrega.Name = "coldireccion_entrega";
            this.coldireccion_entrega.OptionsColumn.AllowEdit = false;
            this.coldireccion_entrega.Visible = true;
            this.coldireccion_entrega.VisibleIndex = 2;
            // 
            // colfecha_pedido
            // 
            this.colfecha_pedido.Caption = "Fecha Pedido";
            this.colfecha_pedido.FieldName = "fecha_pedido";
            this.colfecha_pedido.Name = "colfecha_pedido";
            this.colfecha_pedido.OptionsColumn.AllowEdit = false;
            this.colfecha_pedido.Visible = true;
            this.colfecha_pedido.VisibleIndex = 3;
            // 
            // colfecha_entrega
            // 
            this.colfecha_entrega.Caption = "Fecha Entrega";
            this.colfecha_entrega.FieldName = "fecha_entrega";
            this.colfecha_entrega.Name = "colfecha_entrega";
            this.colfecha_entrega.OptionsColumn.AllowEdit = false;
            this.colfecha_entrega.Visible = true;
            this.colfecha_entrega.VisibleIndex = 4;
            // 
            // colcontacto
            // 
            this.colcontacto.FieldName = "contacto";
            this.colcontacto.Name = "colcontacto";
            this.colcontacto.OptionsColumn.AllowEdit = false;
            // 
            // colSunumero_orden
            // 
            this.colSunumero_orden.FieldName = "Sunumero_orden";
            this.colSunumero_orden.Name = "colSunumero_orden";
            this.colSunumero_orden.OptionsColumn.AllowEdit = false;
            // 
            // colcond_entrega
            // 
            this.colcond_entrega.FieldName = "cond_entrega";
            this.colcond_entrega.Name = "colcond_entrega";
            this.colcond_entrega.OptionsColumn.AllowEdit = false;
            // 
            // colmetood_entrega
            // 
            this.colmetood_entrega.Caption = "Metodo de Entrega";
            this.colmetood_entrega.FieldName = "metood_entrega";
            this.colmetood_entrega.Name = "colmetood_entrega";
            this.colmetood_entrega.OptionsColumn.AllowEdit = false;
            this.colmetood_entrega.Visible = true;
            this.colmetood_entrega.VisibleIndex = 5;
            // 
            // colmoneda
            // 
            this.colmoneda.Caption = "Moneda";
            this.colmoneda.FieldName = "moneda";
            this.colmoneda.Name = "colmoneda";
            this.colmoneda.OptionsColumn.AllowEdit = false;
            this.colmoneda.Visible = true;
            this.colmoneda.VisibleIndex = 6;
            // 
            // colnumero_orden
            // 
            this.colnumero_orden.FieldName = "numero_orden";
            this.colnumero_orden.Name = "colnumero_orden";
            this.colnumero_orden.OptionsColumn.AllowEdit = false;
            // 
            // colntra_ref
            // 
            this.colntra_ref.FieldName = "ntra_ref";
            this.colntra_ref.Name = "colntra_ref";
            this.colntra_ref.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Imprimir";
            this.gridColumn1.ColumnEdit = this.repositoryItemPrint;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // repositoryItemPrint
            // 
            this.repositoryItemPrint.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repositoryItemPrint.Name = "repositoryItemPrint";
            this.repositoryItemPrint.ReadOnly = true;
            this.repositoryItemPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemPrint.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemPrint_ButtonClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridPedidos);
            this.panelControl1.Location = new System.Drawing.Point(0, 75);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1198, 506);
            this.panelControl1.TabIndex = 6;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1198, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 593);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1198, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 593);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1198, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 593);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Confirmacion de Pedidos";
            // 
            // cmdSalir
            // 
            this.cmdSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.ImageOptions.Image")));
            this.cmdSalir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSalir.Location = new System.Drawing.Point(1128, 24);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(58, 45);
            this.cmdSalir.TabIndex = 14;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.ImageOptions.Image")));
            this.cmdAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdAdd.Location = new System.Drawing.Point(12, 24);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(61, 45);
            this.cmdAdd.TabIndex = 15;
            this.cmdAdd.Text = "New";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 593);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridPedidos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton cmdAdd;
        private DevExpress.XtraEditors.SimpleButton cmdSalir;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_pedido;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente_direccion;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion_entrega;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_pedido;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_entrega;
        private DevExpress.XtraGrid.Columns.GridColumn colcontacto;
        private DevExpress.XtraGrid.Columns.GridColumn colSunumero_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colcond_entrega;
        private DevExpress.XtraGrid.Columns.GridColumn colmetood_entrega;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colntra_ref;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemPrint;
        private dsPedidos dsPedidos;
    }
}
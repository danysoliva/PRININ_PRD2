namespace PRININ.Compras
{
    partial class frmOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenCompra));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoProveedor = new DevExpress.XtraEditors.TextEdit();
            this.cmdAbrirBusqueda = new DevExpress.XtraEditors.SimpleButton();
            this.txtRTN = new DevExpress.XtraEditors.TextEdit();
            this.cmdSincronizarProveedores = new DevExpress.XtraEditors.SimpleButton();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContacto = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.dtFechaVence = new DevExpress.XtraEditors.DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReferencia = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.grMoneda = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCompras1 = new PRININ.Compras.dsCompras();
            this.grResolucion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.txtObservaciones = new DevExpress.XtraEditors.TextEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_orden_compra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coltotal_f = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_rubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_rubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookupEditCapitulos = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bindingSourceCapitulos = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpagos_d = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_capitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcapitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVence.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grResolucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookupEditCapitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCapitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(290, 69);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtProveedor.Properties.NullValuePrompt = "Nombre del Proveedor";
            this.txtProveedor.Size = new System.Drawing.Size(276, 24);
            this.txtProveedor.TabIndex = 0;
            this.txtProveedor.EditValueChanged += new System.EventHandler(this.txtProveedor_EditValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Proveedor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ordenes de Compra Exoneradas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.Enabled = false;
            this.txtCodigoProveedor.Location = new System.Drawing.Point(190, 69);
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoProveedor.Properties.NullValuePrompt = "Código";
            this.txtCodigoProveedor.Size = new System.Drawing.Size(94, 24);
            this.txtCodigoProveedor.TabIndex = 25;
            this.txtCodigoProveedor.EditValueChanged += new System.EventHandler(this.txtCodigoProveedor_EditValueChanged);
            // 
            // cmdAbrirBusqueda
            // 
            this.cmdAbrirBusqueda.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbrirBusqueda.Appearance.Options.UseFont = true;
            this.cmdAbrirBusqueda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAbrirBusqueda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAbrirBusqueda.ImageOptions.Image")));
            this.cmdAbrirBusqueda.Location = new System.Drawing.Point(771, 63);
            this.cmdAbrirBusqueda.Name = "cmdAbrirBusqueda";
            this.cmdAbrirBusqueda.Size = new System.Drawing.Size(44, 35);
            this.cmdAbrirBusqueda.TabIndex = 2;
            this.cmdAbrirBusqueda.Click += new System.EventHandler(this.cmdAbrirBusqueda_Click);
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(572, 69);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTN.Properties.Appearance.Options.UseFont = true;
            this.txtRTN.Properties.NullValuePrompt = "RTN";
            this.txtRTN.Size = new System.Drawing.Size(193, 24);
            this.txtRTN.TabIndex = 1;
            this.txtRTN.EditValueChanged += new System.EventHandler(this.txtRTN_EditValueChanged);
            // 
            // cmdSincronizarProveedores
            // 
            this.cmdSincronizarProveedores.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSincronizarProveedores.Appearance.Options.UseFont = true;
            this.cmdSincronizarProveedores.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSincronizarProveedores.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSincronizarProveedores.ImageOptions.Image")));
            this.cmdSincronizarProveedores.Location = new System.Drawing.Point(615, 12);
            this.cmdSincronizarProveedores.Name = "cmdSincronizarProveedores";
            this.cmdSincronizarProveedores.Size = new System.Drawing.Size(200, 35);
            this.cmdSincronizarProveedores.TabIndex = 17;
            this.cmdSincronizarProveedores.Text = "Sincronizar Proveedores";
            this.cmdSincronizarProveedores.Click += new System.EventHandler(this.cmdSincronizarProveedores_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(190, 99);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion.Properties.NullValuePrompt = "Direccion del proveedor";
            this.txtDireccion.Size = new System.Drawing.Size(575, 24);
            this.txtDireccion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dirección";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(190, 129);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.Properties.Appearance.Options.UseFont = true;
            this.txtContacto.Properties.NullValuePrompt = "Nombre del Contacto";
            this.txtContacto.Size = new System.Drawing.Size(299, 24);
            this.txtContacto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contacto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(572, 129);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono.Properties.NullValuePrompt = "Telefono";
            this.txtTelefono.Size = new System.Drawing.Size(193, 24);
            this.txtTelefono.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Telefono";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = new System.DateTime(2021, 5, 11, 0, 0, 0, 0);
            this.dtFecha.Location = new System.Drawing.Point(190, 159);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFecha.Properties.Appearance.Options.UseFont = true;
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Size = new System.Drawing.Size(224, 26);
            this.dtFecha.TabIndex = 6;
            // 
            // dtFechaVence
            // 
            this.dtFechaVence.EditValue = new System.DateTime(2021, 5, 11, 0, 0, 0, 0);
            this.dtFechaVence.Location = new System.Drawing.Point(572, 159);
            this.dtFechaVence.Name = "dtFechaVence";
            this.dtFechaVence.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaVence.Properties.Appearance.Options.UseFont = true;
            this.dtFechaVence.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaVence.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaVence.Size = new System.Drawing.Size(193, 26);
            this.dtFechaVence.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha Vencimiento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Moneda";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(414, 194);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Properties.Appearance.Options.UseFont = true;
            this.txtReferencia.Properties.NullValuePrompt = "#Referencia";
            this.txtReferencia.Size = new System.Drawing.Size(152, 24);
            this.txtReferencia.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(321, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Referencia";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(572, 188);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(193, 35);
            this.cmdCerrar.TabIndex = 22;
            this.cmdCerrar.Text = "Marcar como Cerrada";
            this.cmdCerrar.Visible = false;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.Location = new System.Drawing.Point(289, 642);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(125, 35);
            this.cmdGuardar.TabIndex = 14;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.ImageOptions.Image")));
            this.cmdCancelar.Location = new System.Drawing.Point(499, 642);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(125, 35);
            this.cmdCancelar.TabIndex = 15;
            this.cmdCancelar.Text = "Salir";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Appearance.Options.UseFont = true;
            this.cmdAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.ImageOptions.Image")));
            this.cmdAgregar.Location = new System.Drawing.Point(2, 288);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(125, 34);
            this.cmdAgregar.TabIndex = 12;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // grMoneda
            // 
            this.grMoneda.EditValue = "";
            this.grMoneda.Location = new System.Drawing.Point(190, 193);
            this.grMoneda.Name = "grMoneda";
            this.grMoneda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.grMoneda.Properties.Appearance.Options.UseFont = true;
            this.grMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grMoneda.Properties.DataSource = this.bindingSource1;
            this.grMoneda.Properties.DisplayMember = "descripcion";
            this.grMoneda.Properties.ValueMember = "id";
            this.grMoneda.Size = new System.Drawing.Size(125, 24);
            this.grMoneda.TabIndex = 8;
            this.grMoneda.EditValueChanged += new System.EventHandler(this.grMoneda_EditValueChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "monedas";
            this.bindingSource1.DataSource = this.dsCompras1;
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grResolucion
            // 
            this.grResolucion.EditValue = "";
            this.grResolucion.Location = new System.Drawing.Point(190, 260);
            this.grResolucion.Name = "grResolucion";
            this.grResolucion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.grResolucion.Properties.Appearance.Options.UseFont = true;
            this.grResolucion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grResolucion.Properties.DataSource = this.bindingSource3;
            this.grResolucion.Properties.DisplayMember = "descripcion";
            this.grResolucion.Properties.ValueMember = "id";
            this.grResolucion.Size = new System.Drawing.Size(125, 24);
            this.grResolucion.TabIndex = 8;
            this.grResolucion.TextChanged += new System.EventHandler(this.grResolucion_TextChanged);
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "resolucion";
            this.bindingSource3.DataSource = this.dsCompras1;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(65, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Observaciones";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(190, 229);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Properties.Appearance.Options.UseFont = true;
            this.txtObservaciones.Properties.MaxLength = 70;
            this.txtObservaciones.Properties.NullValuePrompt = "Nombre del Contacto";
            this.txtObservaciones.Size = new System.Drawing.Size(575, 24);
            this.txtObservaciones.TabIndex = 10;
            this.txtObservaciones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtObservaciones_KeyDown);
            this.txtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservaciones_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(65, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "Resolución";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colid1
            // 
            this.colid1.Caption = "Codigo";
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.Visible = true;
            this.colid1.VisibleIndex = 0;
            this.colid1.Width = 63;
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.Caption = "Descripcion";
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 1;
            this.coldescripcion1.Width = 428;
            // 
            // gridMain
            // 
            this.gridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMain.DataMember = "oc_detalle";
            this.gridMain.DataSource = this.dsCompras1;
            this.gridMain.Location = new System.Drawing.Point(0, 325);
            this.gridMain.MainView = this.gridView1;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemGridLookUpEdit1,
            this.gridLookupEditCapitulos,
            this.repositoryItemButtonDelete});
            this.gridMain.Size = new System.Drawing.Size(1014, 311);
            this.gridMain.TabIndex = 13;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_orden_compra,
            this.colcodigo,
            this.coldescripcion,
            this.colcantidad,
            this.colprecio,
            this.col_delete,
            this.coltotal_f,
            this.colid_rubro,
            this.colnombre_rubro,
            this.colCap,
            this.col_saldo,
            this.colpagos_d,
            this.colid_capitulo,
            this.colcapitulo});
            this.gridView1.GridControl = this.gridMain;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colid_rubro, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_orden_compra
            // 
            this.colid_orden_compra.FieldName = "id_orden_compra";
            this.colid_orden_compra.Name = "colid_orden_compra";
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 61;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 217;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 6;
            this.colcantidad.Width = 67;
            // 
            // colprecio
            // 
            this.colprecio.Caption = "Precio";
            this.colprecio.DisplayFormat.FormatString = "###,##0.00";
            this.colprecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 7;
            this.colprecio.Width = 91;
            // 
            // col_delete
            // 
            this.col_delete.Caption = "Eliminar";
            this.col_delete.ColumnEdit = this.repositoryItemButtonDelete;
            this.col_delete.Name = "col_delete";
            this.col_delete.Visible = true;
            this.col_delete.VisibleIndex = 9;
            this.col_delete.Width = 57;
            // 
            // repositoryItemButtonDelete
            // 
            this.repositoryItemButtonDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonDelete.Name = "repositoryItemButtonDelete";
            this.repositoryItemButtonDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonDelete_ButtonClick);
            // 
            // coltotal_f
            // 
            this.coltotal_f.Caption = "Total Fila";
            this.coltotal_f.FieldName = "total_f";
            this.coltotal_f.Name = "coltotal_f";
            this.coltotal_f.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_f", "SUM={0:0.##}")});
            this.coltotal_f.Visible = true;
            this.coltotal_f.VisibleIndex = 8;
            this.coltotal_f.Width = 90;
            // 
            // colid_rubro
            // 
            this.colid_rubro.Caption = "Rubro #";
            this.colid_rubro.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colid_rubro.FieldName = "id_rubro";
            this.colid_rubro.Name = "colid_rubro";
            this.colid_rubro.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colid_rubro.Visible = true;
            this.colid_rubro.VisibleIndex = 2;
            this.colid_rubro.Width = 158;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.bindingSource2;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "descripcion";
            this.repositoryItemGridLookUpEdit1.KeyMember = "id;descripcion";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.gridView2;
            this.repositoryItemGridLookUpEdit1.ValueMember = "id";
            this.repositoryItemGridLookUpEdit1.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
            this.repositoryItemGridLookUpEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemGridLookUpEdit1_EditValueChanged);
            this.repositoryItemGridLookUpEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryItemGridLookUpEdit1_EditValueChanging);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "rubros";
            this.bindingSource2.DataSource = this.dsCompras1;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colnombre_rubro
            // 
            this.colnombre_rubro.Caption = "Rubro";
            this.colnombre_rubro.FieldName = "nombre_rubro";
            this.colnombre_rubro.Name = "colnombre_rubro";
            this.colnombre_rubro.Width = 133;
            // 
            // colCap
            // 
            this.colCap.Caption = "Capitulo";
            this.colCap.ColumnEdit = this.gridLookupEditCapitulos;
            this.colCap.FieldName = "id_capitulo";
            this.colCap.Name = "colCap";
            this.colCap.Width = 96;
            // 
            // gridLookupEditCapitulos
            // 
            this.gridLookupEditCapitulos.AutoHeight = false;
            this.gridLookupEditCapitulos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookupEditCapitulos.DataSource = this.bindingSourceCapitulos;
            this.gridLookupEditCapitulos.DisplayMember = "descripcion";
            this.gridLookupEditCapitulos.KeyMember = "id;descripcion";
            this.gridLookupEditCapitulos.Name = "gridLookupEditCapitulos";
            this.gridLookupEditCapitulos.PopupView = this.repositoryItemGridLookUpEdit2View;
            this.gridLookupEditCapitulos.ValueMember = "id";
            this.gridLookupEditCapitulos.EditValueChanged += new System.EventHandler(this.repositoryItemGridLookUpEdit1_EditValueChanged);
            this.gridLookupEditCapitulos.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryItemGridLookUpEdit1_EditValueChanging);
            // 
            // bindingSourceCapitulos
            // 
            this.bindingSourceCapitulos.DataMember = "capitulos";
            this.bindingSourceCapitulos.DataSource = this.dsCompras1;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.coldescripcion2});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // coldescripcion2
            // 
            this.coldescripcion2.Caption = "Seleccione el Capitulo";
            this.coldescripcion2.FieldName = "descripcion";
            this.coldescripcion2.Name = "coldescripcion2";
            this.coldescripcion2.Visible = true;
            this.coldescripcion2.VisibleIndex = 0;
            // 
            // col_saldo
            // 
            this.col_saldo.AppearanceCell.Options.UseTextOptions = true;
            this.col_saldo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.col_saldo.Caption = "Saldo Disp.";
            this.col_saldo.DisplayFormat.FormatString = "###,##0.00";
            this.col_saldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_saldo.FieldName = "saldo";
            this.col_saldo.Name = "col_saldo";
            this.col_saldo.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_saldo.Visible = true;
            this.col_saldo.VisibleIndex = 3;
            this.col_saldo.Width = 82;
            // 
            // colpagos_d
            // 
            this.colpagos_d.Caption = "Pagos Disp.";
            this.colpagos_d.FieldName = "pagos_d";
            this.colpagos_d.Name = "colpagos_d";
            this.colpagos_d.Visible = true;
            this.colpagos_d.VisibleIndex = 5;
            this.colpagos_d.Width = 77;
            // 
            // colid_capitulo
            // 
            this.colid_capitulo.FieldName = "id_capitulo";
            this.colid_capitulo.Name = "colid_capitulo";
            // 
            // colcapitulo
            // 
            this.colcapitulo.Caption = "Capitulo";
            this.colcapitulo.FieldName = "capitulo";
            this.colcapitulo.Name = "colcapitulo";
            this.colcapitulo.Visible = true;
            this.colcapitulo.VisibleIndex = 4;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick_1);
            // 
            // frmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 680);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.grMoneda);
            this.Controls.Add(this.grResolucion);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCodigoProveedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtFechaVence);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdSincronizarProveedores);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.cmdAbrirBusqueda);
            this.Controls.Add(this.label1);
            this.Name = "frmOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVence.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grResolucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookupEditCapitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCapitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraEditors.SimpleButton cmdAbrirBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtCodigoProveedor;
        private DevExpress.XtraEditors.TextEdit txtRTN;
        private DevExpress.XtraEditors.SimpleButton cmdSincronizarProveedores;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtContacto;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.DateEdit dtFechaVence;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtReferencia;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsCompras dsCompras1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden_compra;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn col_delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_f;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_rubro;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_rubro;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private DevExpress.XtraEditors.SimpleButton cmdAgregar;
        private DevExpress.XtraEditors.GridLookUpEdit grMoneda;
        private DevExpress.XtraEditors.GridLookUpEdit grResolucion;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn col_saldo;
        private System.Windows.Forms.BindingSource bindingSourceCapitulos;
        private DevExpress.XtraGrid.Columns.GridColumn colCap;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gridLookupEditCapitulos;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private System.Windows.Forms.BindingSource bindingSource3;
        private DevExpress.XtraGrid.Columns.GridColumn colpagos_d;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colid_capitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colcapitulo;
    }
}
namespace PRININ.Notas
{
    partial class frmSelectCAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectCAI));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.selectCaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNotas = new PRININ.Notas.dsNotas();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_emision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_ini = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.cmdImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.cmdBack = new DevExpress.XtraEditors.SimpleButton();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxFAC = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.selectCaiBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(547, 163);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // selectCaiBindingSource
            // 
            this.selectCaiBindingSource.DataMember = "selectCai";
            this.selectCaiBindingSource.DataSource = this.dsNotas;
            // 
            // dsNotas
            // 
            this.dsNotas.DataSetName = "dsNotas";
            this.dsNotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcai,
            this.colfecha_emision,
            this.colfecha_vence,
            this.colnum_ini,
            this.colnum_fin,
            this.colestado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcai
            // 
            this.colcai.Caption = "CAI";
            this.colcai.FieldName = "cai";
            this.colcai.Name = "colcai";
            this.colcai.Visible = true;
            this.colcai.VisibleIndex = 0;
            this.colcai.Width = 172;
            // 
            // colfecha_emision
            // 
            this.colfecha_emision.Caption = "Fecha de emision";
            this.colfecha_emision.FieldName = "fecha_emision";
            this.colfecha_emision.Name = "colfecha_emision";
            this.colfecha_emision.Visible = true;
            this.colfecha_emision.VisibleIndex = 1;
            this.colfecha_emision.Width = 119;
            // 
            // colfecha_vence
            // 
            this.colfecha_vence.Caption = "Fecha de Vencimiento";
            this.colfecha_vence.FieldName = "fecha_vence";
            this.colfecha_vence.Name = "colfecha_vence";
            this.colfecha_vence.Visible = true;
            this.colfecha_vence.VisibleIndex = 2;
            this.colfecha_vence.Width = 140;
            // 
            // colnum_ini
            // 
            this.colnum_ini.FieldName = "num_ini";
            this.colnum_ini.Name = "colnum_ini";
            // 
            // colnum_fin
            // 
            this.colnum_fin.FieldName = "num_fin";
            this.colnum_fin.Name = "colnum_fin";
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 3;
            this.colestado.Width = 98;
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCorrelativo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrelativo.Location = new System.Drawing.Point(249, 170);
            this.txtCorrelativo.MaxLength = 8;
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(100, 25);
            this.txtCorrelativo.TabIndex = 2;
            this.txtCorrelativo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorrelativo_KeyPress);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdImprimir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.ImageOptions.Image")));
            this.cmdImprimir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdImprimir.Location = new System.Drawing.Point(12, 173);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(84, 48);
            this.cmdImprimir.TabIndex = 3;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdBack.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdBack.ImageOptions.Image")));
            this.cmdBack.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdBack.Location = new System.Drawing.Point(450, 173);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(84, 48);
            this.cmdBack.TabIndex = 4;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // txtFactura
            // 
            this.txtFactura.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFactura.Enabled = false;
            this.txtFactura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(121, 227);
            this.txtFactura.MaxLength = 200;
            this.txtFactura.Multiline = true;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(320, 52);
            this.txtFactura.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "000-001-01-";
            // 
            // checkBoxFAC
            // 
            this.checkBoxFAC.AutoSize = true;
            this.checkBoxFAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFAC.Location = new System.Drawing.Point(191, 201);
            this.checkBoxFAC.Name = "checkBoxFAC";
            this.checkBoxFAC.Size = new System.Drawing.Size(175, 20);
            this.checkBoxFAC.TabIndex = 8;
            this.checkBoxFAC.Text = "Agregar mas facturas";
            this.checkBoxFAC.UseVisualStyleBackColor = true;
            this.checkBoxFAC.CheckedChanged += new System.EventHandler(this.checkBoxFAC_CheckedChanged);
            // 
            // frmSelectCAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 285);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxFAC);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.txtCorrelativo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmSelectCAI";
            this.Text = "Seleccione un CAI";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtCorrelativo;
        private DevExpress.XtraEditors.SimpleButton cmdImprimir;
        private System.Windows.Forms.BindingSource selectCaiBindingSource;
        private dsNotas dsNotas;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcai;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_emision;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vence;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_ini;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_fin;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraEditors.SimpleButton cmdBack;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxFAC;
    }
}

namespace PRININ.Numeracion_Fiscal
{
    partial class frmNumeracionFiscalCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumeracionFiscalCRUD));
            this.txtCAI = new DevExpress.XtraEditors.TextEdit();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaEmision = new DevExpress.XtraEditors.DateEdit();
            this.deFechaVence = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumIni = new DevExpress.XtraEditors.TextEdit();
            this.txtNumFin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.luEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbxTipoDocumento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tsSecuencia = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNumeracionFiscal = new PRININ.Numeracion_Fiscal.dsNumeracionFiscal();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEmision.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEmision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaVence.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaVence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipoDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsSecuencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNumeracionFiscal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCAI
            // 
            this.txtCAI.Location = new System.Drawing.Point(186, 71);
            this.txtCAI.Name = "txtCAI";
            this.txtCAI.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCAI.Properties.Appearance.Options.UseFont = true;
            this.txtCAI.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCAI.Properties.Mask.EditMask = resources.GetString("txtCAI.Properties.Mask.EditMask");
            this.txtCAI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCAI.Size = new System.Drawing.Size(398, 26);
            this.txtCAI.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Appearance.Options.UseTextOptions = true;
            this.btnGuardar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
            this.btnGuardar.Location = new System.Drawing.Point(195, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 58);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(144, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "CAI:";
            // 
            // deFechaEmision
            // 
            this.deFechaEmision.EditValue = null;
            this.deFechaEmision.Location = new System.Drawing.Point(186, 106);
            this.deFechaEmision.Name = "deFechaEmision";
            this.deFechaEmision.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deFechaEmision.Properties.Appearance.Options.UseFont = true;
            this.deFechaEmision.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaEmision.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaEmision.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.deFechaEmision.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.deFechaEmision.Size = new System.Drawing.Size(157, 26);
            this.deFechaEmision.TabIndex = 1;
            // 
            // deFechaVence
            // 
            this.deFechaVence.EditValue = null;
            this.deFechaVence.Location = new System.Drawing.Point(186, 141);
            this.deFechaVence.Name = "deFechaVence";
            this.deFechaVence.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deFechaVence.Properties.Appearance.Options.UseFont = true;
            this.deFechaVence.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaVence.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaVence.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.deFechaVence.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.deFechaVence.Size = new System.Drawing.Size(157, 26);
            this.deFechaVence.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(73, 142);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Fecha Vence:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(59, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(121, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Fecha Emisión:";
            // 
            // txtNumIni
            // 
            this.txtNumIni.Location = new System.Drawing.Point(186, 176);
            this.txtNumIni.Name = "txtNumIni";
            this.txtNumIni.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumIni.Properties.Appearance.Options.UseFont = true;
            this.txtNumIni.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumIni.Properties.Mask.EditMask = "000-000-00-00000000";
            this.txtNumIni.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtNumIni.Size = new System.Drawing.Size(302, 26);
            this.txtNumIni.TabIndex = 3;
            // 
            // txtNumFin
            // 
            this.txtNumFin.Location = new System.Drawing.Point(186, 211);
            this.txtNumFin.Name = "txtNumFin";
            this.txtNumFin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFin.Properties.Appearance.Options.UseFont = true;
            this.txtNumFin.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumFin.Properties.Mask.EditMask = "000-000-00-00000000";
            this.txtNumFin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtNumFin.Size = new System.Drawing.Size(302, 26);
            this.txtNumFin.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(22, 176);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(158, 19);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Numeración Inicial:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(33, 210);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(147, 19);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Numeración Final:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Appearance.Options.UseTextOptions = true;
            this.btnCancelar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelar.ImageOptions.SvgImage")));
            this.btnCancelar.Location = new System.Drawing.Point(316, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 58);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // luEstado
            // 
            this.luEstado.Location = new System.Drawing.Point(186, 246);
            this.luEstado.Name = "luEstado";
            this.luEstado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.luEstado.Properties.Appearance.Options.UseFont = true;
            this.luEstado.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luEstado.Properties.AppearanceDropDown.Options.UseFont = true;
            this.luEstado.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luEstado.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.luEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_estado", "id_estado", 91, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Descripción", 89, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luEstado.Properties.DataSource = this.estadoBindingSource;
            this.luEstado.Properties.DisplayMember = "descripcion";
            this.luEstado.Properties.NullText = "";
            this.luEstado.Properties.ValueMember = "id_estado";
            this.luEstado.Size = new System.Drawing.Size(153, 26);
            this.luEstado.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(119, 244);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(61, 19);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Estado:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(41, 278);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(139, 19);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Tipo Documento:";
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.Location = new System.Drawing.Point(186, 281);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoDocumento.Properties.Appearance.Options.UseFont = true;
            this.cbxTipoDocumento.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoDocumento.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxTipoDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTipoDocumento.Properties.Items.AddRange(new object[] {
            "FAC",
            "NC",
            "ND"});
            this.cbxTipoDocumento.Size = new System.Drawing.Size(153, 26);
            this.cbxTipoDocumento.TabIndex = 6;
            // 
            // tsSecuencia
            // 
            this.tsSecuencia.Location = new System.Drawing.Point(186, 316);
            this.tsSecuencia.Name = "tsSecuencia";
            this.tsSecuencia.Properties.OffText = "No";
            this.tsSecuencia.Properties.OnText = "Si";
            this.tsSecuencia.Size = new System.Drawing.Size(95, 24);
            this.tsSecuencia.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(42, 316);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(138, 19);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Tiene Secuencia:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(214, 12);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(175, 23);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "Numeración Fiscal";
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this.dsNumeracionFiscal;
            // 
            // dsNumeracionFiscal
            // 
            this.dsNumeracionFiscal.DataSetName = "dsNumeracionFiscal";
            this.dsNumeracionFiscal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmNumeracionFiscalCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 457);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.tsSecuencia);
            this.Controls.Add(this.cbxTipoDocumento);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.luEstado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtNumFin);
            this.Controls.Add(this.txtNumIni);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.deFechaVence);
            this.Controls.Add(this.deFechaEmision);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNumeracionFiscalCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numeración Fiscal";
            this.Load += new System.EventHandler(this.frmNumeracionFiscalCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEmision.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEmision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaVence.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaVence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipoDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsSecuencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNumeracionFiscal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCAI;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deFechaEmision;
        private DevExpress.XtraEditors.DateEdit deFechaVence;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNumIni;
        private DevExpress.XtraEditors.TextEdit txtNumFin;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.LookUpEdit luEstado;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private dsNumeracionFiscal dsNumeracionFiscal;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cbxTipoDocumento;
        private DevExpress.XtraEditors.ToggleSwitch tsSecuencia;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}
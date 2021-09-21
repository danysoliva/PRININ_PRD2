namespace PRININ.Mantenimiento
{
    partial class frmMant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMant));
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPermisos = new DevExpress.XtraEditors.SimpleButton();
            this.cmdUsuarios = new DevExpress.XtraEditors.SimpleButton();
            this.cmdMantCAI = new DevExpress.XtraEditors.SimpleButton();
            this.btnNumeracionFiscal = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ImageOptions.Image = global::PRININ.Properties.Resources.close_32;
            this.cmdClose.Location = new System.Drawing.Point(14, 307);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(236, 44);
            this.cmdClose.TabIndex = 10;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdPermisos
            // 
            this.cmdPermisos.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPermisos.Appearance.Options.UseFont = true;
            this.cmdPermisos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdPermisos.ImageOptions.Image")));
            this.cmdPermisos.Location = new System.Drawing.Point(14, 174);
            this.cmdPermisos.Name = "cmdPermisos";
            this.cmdPermisos.Size = new System.Drawing.Size(236, 44);
            this.cmdPermisos.TabIndex = 9;
            this.cmdPermisos.Text = "Gestion de Permisos";
            this.cmdPermisos.Click += new System.EventHandler(this.cmdPermisos_Click);
            // 
            // cmdUsuarios
            // 
            this.cmdUsuarios.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUsuarios.Appearance.Options.UseFont = true;
            this.cmdUsuarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdUsuarios.ImageOptions.Image")));
            this.cmdUsuarios.Location = new System.Drawing.Point(14, 103);
            this.cmdUsuarios.Name = "cmdUsuarios";
            this.cmdUsuarios.Size = new System.Drawing.Size(236, 44);
            this.cmdUsuarios.TabIndex = 8;
            this.cmdUsuarios.Text = "Gestion de Usuarios";
            this.cmdUsuarios.Click += new System.EventHandler(this.cmdUsuarios_Click);
            // 
            // cmdMantCAI
            // 
            this.cmdMantCAI.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMantCAI.Appearance.Options.UseFont = true;
            this.cmdMantCAI.Enabled = false;
            this.cmdMantCAI.ImageOptions.Image = global::PRININ.Properties.Resources.creditnote_32;
            this.cmdMantCAI.Location = new System.Drawing.Point(14, 29);
            this.cmdMantCAI.Name = "cmdMantCAI";
            this.cmdMantCAI.Size = new System.Drawing.Size(236, 44);
            this.cmdMantCAI.TabIndex = 7;
            this.cmdMantCAI.Text = "Mant. CAI Proveedor";
            this.cmdMantCAI.Click += new System.EventHandler(this.cmdMantCAI_Click);
            // 
            // btnNumeracionFiscal
            // 
            this.btnNumeracionFiscal.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeracionFiscal.Appearance.Options.UseFont = true;
            this.btnNumeracionFiscal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNumeracionFiscal.ImageOptions.Image")));
            this.btnNumeracionFiscal.Location = new System.Drawing.Point(14, 239);
            this.btnNumeracionFiscal.Name = "btnNumeracionFiscal";
            this.btnNumeracionFiscal.Size = new System.Drawing.Size(236, 44);
            this.btnNumeracionFiscal.TabIndex = 12;
            this.btnNumeracionFiscal.Text = "Numeración Fiscal";
            this.btnNumeracionFiscal.Click += new System.EventHandler(this.btnNumeracionFiscal_Click);
            // 
            // frmMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 524);
            this.Controls.Add(this.btnNumeracionFiscal);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdPermisos);
            this.Controls.Add(this.cmdUsuarios);
            this.Controls.Add(this.cmdMantCAI);
            this.Name = "frmMant";
            this.Text = "Mantenimiento";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SimpleButton cmdPermisos;
        private DevExpress.XtraEditors.SimpleButton cmdUsuarios;
        private DevExpress.XtraEditors.SimpleButton cmdMantCAI;
        private DevExpress.XtraEditors.SimpleButton btnNumeracionFiscal;
    }
}
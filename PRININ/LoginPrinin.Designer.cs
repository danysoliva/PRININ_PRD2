namespace PRININ
{
    partial class LoginPrinin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPrinin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_password = new DevExpress.XtraEditors.TextEdit();
            this.lbl_User = new DevExpress.XtraEditors.LabelControl();
            this.txt_usuario = new DevExpress.XtraEditors.TextEdit();
            this.lblVersion = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pS_Button2 = new PRININ.Classes.PS_Button();
            this.pS_Button1 = new PRININ.Classes.PS_Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(63, 213);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 23);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.EditValue = "";
            this.txt_password.Location = new System.Drawing.Point(168, 210);
            this.txt_password.Name = "txt_password";
            this.txt_password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Properties.Appearance.Options.UseFont = true;
            this.txt_password.Properties.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(238, 30);
            this.txt_password.TabIndex = 7;
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // lbl_User
            // 
            this.lbl_User.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Appearance.Options.UseFont = true;
            this.lbl_User.Location = new System.Drawing.Point(63, 165);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(50, 23);
            this.lbl_User.TabIndex = 8;
            this.lbl_User.Text = "User:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.EditValue = "";
            this.txt_usuario.Location = new System.Drawing.Point(168, 162);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Properties.Appearance.Options.UseFont = true;
            this.txt_usuario.Size = new System.Drawing.Size(238, 30);
            this.txt_usuario.TabIndex = 6;
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_usuario_KeyDown);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // lblVersion
            // 
            this.lblVersion.Appearance.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Appearance.Options.UseFont = true;
            this.lblVersion.Location = new System.Drawing.Point(3, 351);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(49, 15);
            this.lblVersion.TabIndex = 15;
            this.lblVersion.Text = "0.0.0.0";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(248, 81);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 75);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(307, 36);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(132, 109);
            this.pictureEdit2.TabIndex = 13;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::PRININ.Properties.Resources.PromixLogo_Trans;
            this.pictureEdit1.Location = new System.Drawing.Point(45, 24);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomPercent = 20D;
            this.pictureEdit1.Size = new System.Drawing.Size(232, 121);
            this.pictureEdit1.TabIndex = 12;
            // 
            // pS_Button2
            // 
            this.pS_Button2.BackColor = System.Drawing.Color.IndianRed;
            this.pS_Button2.BackColorButton = System.Drawing.Color.IndianRed;
            this.pS_Button2.BorderColorButton = System.Drawing.Color.PaleVioletRed;
            this.pS_Button2.BorderRadius = 40;
            this.pS_Button2.BorderSize = 0;
            this.pS_Button2.FlatAppearance.BorderSize = 0;
            this.pS_Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pS_Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pS_Button2.ForeColor = System.Drawing.Color.White;
            this.pS_Button2.Image = global::PRININ.Properties.Resources.cross32px;
            this.pS_Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pS_Button2.Location = new System.Drawing.Point(63, 298);
            this.pS_Button2.Name = "pS_Button2";
            this.pS_Button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pS_Button2.Size = new System.Drawing.Size(343, 40);
            this.pS_Button2.TabIndex = 21;
            this.pS_Button2.Text = "Cerrar";
            this.pS_Button2.TextButton = "Cerrar";
            this.pS_Button2.TextColorButton = System.Drawing.Color.White;
            this.pS_Button2.UseVisualStyleBackColor = false;
            this.pS_Button2.Click += new System.EventHandler(this.pS_Button2_Click);
            // 
            // pS_Button1
            // 
            this.pS_Button1.BackColor = System.Drawing.Color.SteelBlue;
            this.pS_Button1.BackColorButton = System.Drawing.Color.SteelBlue;
            this.pS_Button1.BorderColorButton = System.Drawing.Color.PaleVioletRed;
            this.pS_Button1.BorderRadius = 40;
            this.pS_Button1.BorderSize = 0;
            this.pS_Button1.FlatAppearance.BorderSize = 0;
            this.pS_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pS_Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pS_Button1.ForeColor = System.Drawing.Color.White;
            this.pS_Button1.Image = global::PRININ.Properties.Resources.user32px;
            this.pS_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pS_Button1.Location = new System.Drawing.Point(63, 252);
            this.pS_Button1.Name = "pS_Button1";
            this.pS_Button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pS_Button1.Size = new System.Drawing.Size(343, 40);
            this.pS_Button1.TabIndex = 20;
            this.pS_Button1.Text = "Iniciar Sesión";
            this.pS_Button1.TextButton = "Iniciar Sesión";
            this.pS_Button1.TextColorButton = System.Drawing.Color.White;
            this.pS_Button1.UseVisualStyleBackColor = false;
            this.pS_Button1.Click += new System.EventHandler(this.pS_Button1_Click);
            // 
            // LoginPrinin
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 368);
            this.Controls.Add(this.pS_Button2);
            this.Controls.Add(this.pS_Button1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.txt_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPrinin";
            this.Text = "PROMIX - Prinin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginPrinin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_password;
        private DevExpress.XtraEditors.LabelControl lbl_User;
        private DevExpress.XtraEditors.TextEdit txt_usuario;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl lblVersion;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Classes.PS_Button pS_Button1;
        private Classes.PS_Button pS_Button2;
    }
}
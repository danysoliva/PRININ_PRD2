
namespace PRININ.DEV
{
    partial class frmDEV
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
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.vGridControl2 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // vGridControl1
            // 
            this.vGridControl1.Location = new System.Drawing.Point(12, 29);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.Size = new System.Drawing.Size(657, 344);
            this.vGridControl1.TabIndex = 0;
            // 
            // vGridControl2
            // 
            this.vGridControl2.Location = new System.Drawing.Point(12, 404);
            this.vGridControl2.Name = "vGridControl2";
            this.vGridControl2.Size = new System.Drawing.Size(657, 266);
            this.vGridControl2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(281, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Invoice Header - Table: [INV_HEADER]";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 379);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(261, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Invoice Lines - Table: [INV_DETAIL]";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "5C0000000";
            this.textEdit1.Location = new System.Drawing.Point(419, 6);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(64, 20);
            this.textEdit1.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(531, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Load";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "";
            this.textEdit2.Location = new System.Drawing.Point(489, 6);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(36, 20);
            this.textEdit2.TabIndex = 6;
            // 
            // frmDEV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 673);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.vGridControl2);
            this.Controls.Add(this.vGridControl1);
            this.Name = "frmDEV";
            this.Text = "DEV Table Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
    }
}
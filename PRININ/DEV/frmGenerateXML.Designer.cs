
namespace PRININ.DEV
{
    partial class frmGenerateXML
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
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.dsNotasUNITE1 = new PRININ.Notas_UNITE.dsNotasUNITE();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotasUNITE1)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(12, 106);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(606, 397);
            this.memoEdit1.TabIndex = 0;
            // 
            // dsNotasUNITE1
            // 
            this.dsNotasUNITE1.DataSetName = "dsNotasUNITE";
            this.dsNotasUNITE1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmGenerateXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 515);
            this.Controls.Add(this.memoEdit1);
            this.Name = "frmGenerateXML";
            this.Text = "frmGenerateXML";
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotasUNITE1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Notas_UNITE.dsNotasUNITE dsNotasUNITE1;
        public DevExpress.XtraEditors.MemoEdit memoEdit1;
    }
}
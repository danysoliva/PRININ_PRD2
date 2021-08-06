namespace PRININ.Compras
{
    partial class frmOrdenesC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenesC));
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdOrdeneExoneradas = new DevExpress.XtraEditors.SimpleButton();
            this.cmdOrdenesNormales = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton3.ImageOptions.Image = global::PRININ.Properties.Resources.cancel_32;
            this.simpleButton3.Location = new System.Drawing.Point(238, 170);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(169, 64);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Cancelar";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // cmdOrdeneExoneradas
            // 
            this.cmdOrdeneExoneradas.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOrdeneExoneradas.Appearance.Options.UseFont = true;
            this.cmdOrdeneExoneradas.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdOrdeneExoneradas.ImageOptions.Image = global::PRININ.Properties.Resources.document_48;
            this.cmdOrdeneExoneradas.Location = new System.Drawing.Point(69, 75);
            this.cmdOrdeneExoneradas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdOrdeneExoneradas.Name = "cmdOrdeneExoneradas";
            this.cmdOrdeneExoneradas.Size = new System.Drawing.Size(233, 70);
            this.cmdOrdeneExoneradas.TabIndex = 1;
            this.cmdOrdeneExoneradas.Text = "Exoneradas";
            this.cmdOrdeneExoneradas.Click += new System.EventHandler(this.cmdOrdeneExoneradas_Click);
            // 
            // cmdOrdenesNormales
            // 
            this.cmdOrdenesNormales.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOrdenesNormales.Appearance.Options.UseFont = true;
            this.cmdOrdenesNormales.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdOrdenesNormales.ImageOptions.Image = global::PRININ.Properties.Resources.rp_invoice_48;
            this.cmdOrdenesNormales.Location = new System.Drawing.Point(392, 75);
            this.cmdOrdenesNormales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdOrdenesNormales.Name = "cmdOrdenesNormales";
            this.cmdOrdenesNormales.Size = new System.Drawing.Size(206, 70);
            this.cmdOrdenesNormales.TabIndex = 0;
            this.cmdOrdenesNormales.Text = "Normal";
            this.cmdOrdenesNormales.Click += new System.EventHandler(this.cmdOrdeneExenta_Click);
            // 
            // frmOrdenesC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(662, 284);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.cmdOrdeneExoneradas);
            this.Controls.Add(this.cmdOrdenesNormales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrdenesC";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdOrdenesNormales;
        private DevExpress.XtraEditors.SimpleButton cmdOrdeneExoneradas;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}
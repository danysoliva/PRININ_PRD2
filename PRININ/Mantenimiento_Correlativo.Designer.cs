namespace PRININ
{
    partial class Mantenimiento_Correlativo
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
            this.textSiguiente = new DevExpress.XtraEditors.TextEdit();
            this.labelSiguiente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNuevo = new DevExpress.XtraEditors.TextEdit();
            this.butCerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.togMoneda = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.textSiguiente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNuevo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.togMoneda.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textSiguiente
            // 
            this.textSiguiente.Enabled = false;
            this.textSiguiente.Location = new System.Drawing.Point(174, 23);
            this.textSiguiente.Name = "textSiguiente";
            this.textSiguiente.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.textSiguiente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSiguiente.Properties.Appearance.Options.UseBackColor = true;
            this.textSiguiente.Properties.Appearance.Options.UseFont = true;
            this.textSiguiente.Size = new System.Drawing.Size(100, 24);
            this.textSiguiente.TabIndex = 0;
            // 
            // labelSiguiente
            // 
            this.labelSiguiente.AutoSize = true;
            this.labelSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiguiente.Location = new System.Drawing.Point(12, 26);
            this.labelSiguiente.Name = "labelSiguiente";
            this.labelSiguiente.Size = new System.Drawing.Size(124, 18);
            this.labelSiguiente.TabIndex = 1;
            this.labelSiguiente.Text = "Codigo Siguiente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo Nuevo:";
            // 
            // textNuevo
            // 
            this.textNuevo.Location = new System.Drawing.Point(174, 60);
            this.textNuevo.Name = "textNuevo";
            this.textNuevo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNuevo.Properties.Appearance.Options.UseFont = true;
            this.textNuevo.Size = new System.Drawing.Size(100, 24);
            this.textNuevo.TabIndex = 2;
            // 
            // butCerrar
            // 
            this.butCerrar.Image = global::PRININ.Properties.Resources.cancel_32;
            this.butCerrar.Location = new System.Drawing.Point(233, 119);
            this.butCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.butCerrar.Name = "butCerrar";
            this.butCerrar.Size = new System.Drawing.Size(40, 39);
            this.butCerrar.TabIndex = 4;
            this.butCerrar.UseVisualStyleBackColor = true;
            this.butCerrar.Click += new System.EventHandler(this.butCerrar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Image = global::PRININ.Properties.Resources.ok_32;
            this.button1.Location = new System.Drawing.Point(273, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 39);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // togMoneda
            // 
            this.togMoneda.Location = new System.Drawing.Point(15, 127);
            this.togMoneda.Name = "togMoneda";
            this.togMoneda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.togMoneda.Properties.Appearance.Options.UseFont = true;
            this.togMoneda.Properties.OffText = "Lempiras";
            this.togMoneda.Properties.OnText = "Dolares";
            this.togMoneda.Size = new System.Drawing.Size(161, 29);
            this.togMoneda.TabIndex = 6;
            this.togMoneda.Toggled += new System.EventHandler(this.togMoneda_Toggled);
            // 
            // Mantenimiento_Correlativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 167);
            this.Controls.Add(this.togMoneda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNuevo);
            this.Controls.Add(this.labelSiguiente);
            this.Controls.Add(this.textSiguiente);
            this.Name = "Mantenimiento_Correlativo";
            this.Text = "Mantenimiento de Codigo";
            ((System.ComponentModel.ISupportInitialize)(this.textSiguiente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNuevo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.togMoneda.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textSiguiente;
        private System.Windows.Forms.Label labelSiguiente;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textNuevo;
        private System.Windows.Forms.Button butCerrar;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.ToggleSwitch togMoneda;
    }
}
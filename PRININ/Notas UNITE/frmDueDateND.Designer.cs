
namespace PRININ.Notas_UNITE
{
    partial class frmDueDateND
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
            this.pS_ButtonGuardar = new PRININ.Classes.PS_Button();
            this.pS_Button1 = new PRININ.Classes.PS_Button();
            this.dateFechaVence = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaVence.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaVence.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pS_ButtonGuardar
            // 
            this.pS_ButtonGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.pS_ButtonGuardar.BackColorButton = System.Drawing.Color.Gainsboro;
            this.pS_ButtonGuardar.BorderColorButton = System.Drawing.Color.Transparent;
            this.pS_ButtonGuardar.BorderRadius = 40;
            this.pS_ButtonGuardar.BorderSize = 0;
            this.pS_ButtonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.pS_ButtonGuardar.FlatAppearance.BorderSize = 0;
            this.pS_ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pS_ButtonGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pS_ButtonGuardar.ForeColor = System.Drawing.Color.Black;
            this.pS_ButtonGuardar.Location = new System.Drawing.Point(20, 109);
            this.pS_ButtonGuardar.Name = "pS_ButtonGuardar";
            this.pS_ButtonGuardar.Size = new System.Drawing.Size(150, 40);
            this.pS_ButtonGuardar.TabIndex = 52;
            this.pS_ButtonGuardar.Text = "Guardar";
            this.pS_ButtonGuardar.TextButton = "Guardar";
            this.pS_ButtonGuardar.TextColorButton = System.Drawing.Color.Black;
            this.pS_ButtonGuardar.UseVisualStyleBackColor = false;
            this.pS_ButtonGuardar.Click += new System.EventHandler(this.pS_ButtonGuardar_Click);
            // 
            // pS_Button1
            // 
            this.pS_Button1.BackColor = System.Drawing.Color.Black;
            this.pS_Button1.BackColorButton = System.Drawing.Color.Black;
            this.pS_Button1.BorderColorButton = System.Drawing.Color.PaleVioletRed;
            this.pS_Button1.BorderRadius = 40;
            this.pS_Button1.BorderSize = 0;
            this.pS_Button1.FlatAppearance.BorderSize = 0;
            this.pS_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pS_Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pS_Button1.ForeColor = System.Drawing.Color.White;
            this.pS_Button1.Location = new System.Drawing.Point(176, 109);
            this.pS_Button1.Name = "pS_Button1";
            this.pS_Button1.Size = new System.Drawing.Size(150, 40);
            this.pS_Button1.TabIndex = 51;
            this.pS_Button1.Text = "Cerrar";
            this.pS_Button1.TextButton = "Cerrar";
            this.pS_Button1.TextColorButton = System.Drawing.Color.White;
            this.pS_Button1.UseVisualStyleBackColor = false;
            this.pS_Button1.Click += new System.EventHandler(this.pS_Button1_Click);
            // 
            // dateFechaVence
            // 
            this.dateFechaVence.EditValue = null;
            this.dateFechaVence.Location = new System.Drawing.Point(165, 59);
            this.dateFechaVence.Name = "dateFechaVence";
            this.dateFechaVence.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaVence.Properties.Appearance.Options.UseFont = true;
            this.dateFechaVence.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaVence.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaVence.Size = new System.Drawing.Size(133, 22);
            this.dateFechaVence.TabIndex = 50;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(18, 62);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(128, 20);
            this.labelControl4.TabIndex = 49;
            this.labelControl4.Text = "Fecha Vencimiento:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(257, 25);
            this.labelControl2.TabIndex = 48;
            this.labelControl2.Text = "Datos Adicionales Nota Débito";
            // 
            // frmDueDateND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 166);
            this.Controls.Add(this.pS_ButtonGuardar);
            this.Controls.Add(this.pS_Button1);
            this.Controls.Add(this.dateFechaVence);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Name = "frmDueDateND";
            this.Text = "Due Date";
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaVence.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaVence.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Classes.PS_Button pS_ButtonGuardar;
        private Classes.PS_Button pS_Button1;
        public DevExpress.XtraEditors.DateEdit dateFechaVence;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
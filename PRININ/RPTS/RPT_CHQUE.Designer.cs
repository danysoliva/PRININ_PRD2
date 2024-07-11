namespace PRININ.RPTS
{
    partial class RPT_CHQUE
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lblValor = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFecha = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLetras = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLeyenda = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNombre = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 32.29167F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblValor,
            this.lblFecha,
            this.lblLetras,
            this.lblLeyenda,
            this.lblNombre});
            this.TopMargin.HeightF = 194.7916F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblValor
            // 
            this.lblValor.Font = new DevExpress.Drawing.DXFont("Arial", 12F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblValor.LocationFloat = new DevExpress.Utils.PointFloat(451.0417F, 122.9583F);
            this.lblValor.Name = "lblValor";
            this.lblValor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblValor.SizeF = new System.Drawing.SizeF(123.9583F, 16.75F);
            this.lblValor.StylePriority.UseFont = false;
            this.lblValor.StylePriority.UseTextAlignment = false;
            this.lblValor.Text = "0.00";
            this.lblValor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblFecha.LocationFloat = new DevExpress.Utils.PointFloat(395.7917F, 86.95834F);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFecha.SizeF = new System.Drawing.SizeF(228.125F, 16.75F);
            this.lblFecha.StylePriority.UseFont = false;
            this.lblFecha.Text = "Fecha";
            // 
            // lblLetras
            // 
            this.lblLetras.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblLetras.LocationFloat = new DevExpress.Utils.PointFloat(0F, 166.7084F);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLetras.SizeF = new System.Drawing.SizeF(575F, 16.74998F);
            this.lblLetras.StylePriority.UseFont = false;
            this.lblLetras.Text = "Letras";
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblLeyenda.LocationFloat = new DevExpress.Utils.PointFloat(50F, 58.66668F);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLeyenda.SizeF = new System.Drawing.SizeF(228.125F, 16.75F);
            this.lblLeyenda.StylePriority.UseFont = false;
            this.lblLeyenda.Text = "Leyenda";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblNombre.LocationFloat = new DevExpress.Utils.PointFloat(0F, 127.9584F);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNombre.SizeF = new System.Drawing.SizeF(450F, 16.75F);
            this.lblNombre.StylePriority.UseFont = false;
            this.lblNombre.Text = "lblNombre";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 33.33333F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // RPT_CHQUE
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new DevExpress.Drawing.DXMargins(100, 100, 195, 33);
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel lblLeyenda;
        private DevExpress.XtraReports.UI.XRLabel lblNombre;
        private DevExpress.XtraReports.UI.XRLabel lblValor;
        private DevExpress.XtraReports.UI.XRLabel lblFecha;
        private DevExpress.XtraReports.UI.XRLabel lblLetras;
    }
}

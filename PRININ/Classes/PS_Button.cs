using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace PRININ.Classes
{

    public class PS_Button : Button
    {
        int borderSize = 0;
        int borderRaius = 40;
        Color borderColor = Color.PaleVioletRed;

        [Category("PS Code Advance")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("PS Code Advance")]
        public int BorderRadius
        {
            get
            {
                return borderRaius;
            }
            set
            {
                if (value <= this.Height)
                    borderRaius = value;
                else
                    borderRaius = this.Height;
                this.Invalidate();
            }
        }

        [Category("PS Code Advance")]
        public Color BackColorButton
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("PS Code Advance")]
        public string TextButton
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        [Category("PS Code Advance")]
        public Color TextColorButton
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        [Category("PS Code Advance")]
        public Color BorderColorButton
        {
            get { return this.borderColor; }
            set { this.borderColor = value; }
        }


        //Constructor
        public PS_Button()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRaius > this.Height)
                borderRaius = this.Height;
        }

        //Methods
        GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);
            if (borderRaius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRaius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRaius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, BorderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;

                    this.Region = new Region(pathSurface);
                    //Draw
                    e.Graphics.DrawPath(penSurface, pathSurface);
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if (BorderSize >= 1)
                {
                    using (Pen penborder = new Pen(borderColor, BorderSize))
                    {
                        penborder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penborder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}

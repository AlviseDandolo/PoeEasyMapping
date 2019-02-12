using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace PoE_Easy_Mapping
{
    public class AlphaLabel : Label
    {
        public float WidthCoefficient = 0f;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = this.ClientRectangle;
            StringFormat fmt = new StringFormat(StringFormat.GenericTypographic);
            GraphicsPath graphicsPath = new GraphicsPath();
            float emsize = this.Font.Height * this.Font.FontFamily.GetCellAscent(this.Font.Style) / this.Font.FontFamily.GetEmHeight(this.Font.Style);
            graphicsPath.AddString(this.Text, this.Font.FontFamily, (int)this.Font.Style, emsize, this.ClientRectangle, StringFormat.GenericDefault);
            RectangleF textSize = graphicsPath.GetBounds();

            if(textSize.Width / this.Font.Size > WidthCoefficient)
            {
                WidthCoefficient = textSize.Width / this.Font.Size;
            }

            using (var br = new SolidBrush(this.ForeColor))
            {
                rc = new Rectangle((int)(e.ClipRectangle.Width - textSize.Width * 1.02f)/2, (int)(e.ClipRectangle.Height - textSize.Height * 1.5f)/2, (int)(textSize.Width * 1.2f), (int)(textSize.Height * 1.8f));
                e.Graphics.DrawString(this.Text, this.Font, br, rc, fmt);
                //e.Graphics.DrawRectangle(new Pen(Color.Black, 1), rc);
            }
        }
    }
}

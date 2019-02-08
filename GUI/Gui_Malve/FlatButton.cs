using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace Gui_Malve
{
    public class FlatButton : Button
    {
        public FlatButton()
        {
            Initialize(Color.DodgerBlue, Color.White);
        }
        public FlatButton(Color newBackColor, Color newForeColor)
        {
            Initialize(newBackColor, newForeColor);
        }

        private void Initialize(Color newBackColor, Color newForeColor)
        {
            BackColor = newBackColor;
            ForeColor = newForeColor;
            CurrentBackColor = BackColor;
        }

        private Color backColor;
        public override Color BackColor
        {
            get { return backColor; }
            set { backColor = value; CurrentBackColor = backColor; Invalidate(); }
        }

        private Color CurrentBackColor = Color.DodgerBlue;

        private Color onHoverBackColor = Color.DarkOrchid;
        public Color OnHoverBackColor
        {
            get { return onHoverBackColor; }
            set { onHoverBackColor = value; Invalidate(); }
        }

        private Color onClickBackColor = Color.DarkOrchid;
        public Color OnClickBackColor
        {
            get { return onClickBackColor; }
            set { onClickBackColor = value; Invalidate(); }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            CurrentBackColor = onHoverBackColor;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            CurrentBackColor = BackColor;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            CurrentBackColor = onClickBackColor;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            CurrentBackColor = BackColor;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(CurrentBackColor), 0, 0, Width, Height);
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
        }
    }
}
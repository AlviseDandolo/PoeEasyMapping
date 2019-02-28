using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace PoE_Easy_Mapping
{
    public class FlatButton : Button
    {
        public FlatButton()
        {
            BackColor = Color.DodgerBlue;
            ForeColor = Color.White;
            NormalBackColor = BackColor;
            DisabledBackColor = Color.Gray;
        }

        private Color currentBackColor = Color.DodgerBlue;
        public Color CurrentBackColor
        {
            get { return currentBackColor; }
            set { currentBackColor = value; if (!this.Enabled) currentBackColor = DisabledBackColor; Invalidate(); }
        }

        private Color normalBackColor = Color.DodgerBlue;
        public Color NormalBackColor
        {
            get { return normalBackColor; }
            set { normalBackColor = value; CurrentBackColor = normalBackColor; BackColor = normalBackColor; Invalidate(); }
        }

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

        private Color disabledColor = Color.Gray;
        public Color DisabledBackColor
        {
            get { return disabledColor; }
            set { disabledColor = value; Invalidate(); }
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

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (this.Enabled)
            {
                CurrentBackColor = NormalBackColor;
            }
            else
            {
                CurrentBackColor = DisabledBackColor;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (FlatAppearance.BorderSize > 0)
            {
                pevent.Graphics.FillRectangle(new SolidBrush(FlatAppearance.BorderColor), 0, 0, Width, Height);
                pevent.Graphics.FillRectangle(new SolidBrush(CurrentBackColor), FlatAppearance.BorderSize, FlatAppearance.BorderSize, Width - FlatAppearance.BorderSize*2, Height - FlatAppearance.BorderSize*2);
            } else {
                pevent.Graphics.FillRectangle(new SolidBrush(CurrentBackColor), 0, 0, Width, Height);
            }
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
        }
    }
}
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
    public class FlatTab : Button
    {
        public FlatTab()
        {

        }

        private bool IsActive = false;
        
        private Color activeBackColor = Color.DodgerBlue;
        public Color ActiveBackColor
        {
            get { return activeBackColor; }
            set { activeBackColor = value; SetActive(IsActive); Invalidate(); }
        }
        private Color activeBorderColor = Color.DodgerBlue;
        public Color ActiveBorderColor
        {
            get { return activeBorderColor; }
            set { activeBorderColor = value; SetActive(IsActive); Invalidate(); }
        }

        private Color inactiveBackColor = Color.DarkBlue;
        public Color InactiveBackColor
        {
            get { return inactiveBackColor; }
            set { inactiveBackColor = value; SetActive(IsActive); Invalidate(); }
        }
        private Color inactiveBorderColor = Color.DarkBlue;
        public Color InactiveBorderColor
        {
            get { return inactiveBorderColor; }
            set { inactiveBorderColor = value; SetActive(IsActive); Invalidate(); }
        }

        public Color DisabledBackColor { get; set; } = Color.Gray;
        public Color DisabledBorderColor { get; set; } = Color.Gray;

        private Color onHoverBackColor = Color.DarkOrchid;
        public Color OnHoverBackColor
        {
            get { return onHoverBackColor; }
            set { onHoverBackColor = value; Invalidate(); }
        }
        private Color onHoverBorderColor = Color.DarkOrchid;
        public Color OnHoverBorderColor
        {
            get { return onHoverBorderColor; }
            set { onHoverBorderColor = value; Invalidate(); }
        }

        private Color onClickBackColor = Color.DarkOrchid;
        public Color OnClickBackColor
        {
            get { return onClickBackColor; }
            set { onClickBackColor = value; Invalidate(); }
        }
        private Color onClickBorderColor = Color.DarkOrchid;
        public Color OnClickBorderColor
        {
            get { return onClickBorderColor; }
            set { onClickBorderColor = value; Invalidate(); }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = OnHoverBackColor;
            FlatAppearance.BorderColor = OnHoverBorderColor;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = IsActive ? ActiveBackColor : InactiveBackColor;
            FlatAppearance.BorderColor = IsActive ? ActiveBorderColor : InactiveBorderColor;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            BackColor = OnClickBackColor;
            FlatAppearance.BorderColor = OnClickBorderColor;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            BackColor = IsActive ? ActiveBackColor : InactiveBackColor;
            FlatAppearance.BorderColor = IsActive ? ActiveBorderColor : InactiveBorderColor;
            Invalidate();
        }

        public void SetActive(bool isActive)
        {
            IsActive = isActive;
            if (IsActive)
            {
                BackColor = ActiveBackColor;
                FlatAppearance.BorderColor = ActiveBorderColor;
            }
            else
            {
                BackColor = InactiveBackColor;
                FlatAppearance.BorderColor = InactiveBorderColor;
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (FlatAppearance.BorderSize > 0)
            {
                pevent.Graphics.FillRectangle(new SolidBrush(FlatAppearance.BorderColor), 0, 0, Width, Height);
                pevent.Graphics.FillRectangle(new SolidBrush(BackColor), FlatAppearance.BorderSize, FlatAppearance.BorderSize, Width - FlatAppearance.BorderSize * 2, Height - FlatAppearance.BorderSize * 2);
            }
            else
            {
                pevent.Graphics.FillRectangle(new SolidBrush(BackColor), 0, 0, Width, Height);
            }
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
        }
    }
}
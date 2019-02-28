using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoE_Easy_Mapping
{
    public partial class MapIconPanel : UserControl
    {
        MainWindow mw;
        bool ShowIcon = true;
        int IconSize = 1;
        string IconColor = "blue";
        string IconShape = "sphere";

        public MapIconPanel(MainWindow mwref)
        {
            this.mw = mwref;
            InitializeComponent();
        }

        public void Init(int size, string color, string shape)
        {
            IconSize = size;
            SetIconSize(IconSize);
            IconColor = color;
            SetIconColor(IconColor);
            IconShape = shape;
            SetIconShape(IconShape);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
        }

        private void OutsidePanel_Click(object sender, EventArgs e)
        {
            mw.RemoveMapIconPanel();
        }

        private void SetIconSize(int size)
        {
            IconSize = size;
            SetSmall.SetActive(false);
            SetMedium.SetActive(false);
            SetBig.SetActive(false);

            switch (size)
            {
                case 1:
                    SetSmall.SetActive(true);
                    break;
                case 2:
                    SetMedium.SetActive(true);
                    break;
                case 3:
                    SetBig.SetActive(true);
                    break;
                default:
                    break;
            }
        }

        private void SetSmall_Click(object sender, EventArgs e)
        {
            SetIconSize(1);
        }

        private void SetMedium_Click(object sender, EventArgs e)
        {
            SetIconSize(2);
        }

        private void SetBig_Click(object sender, EventArgs e)
        {
            SetIconSize(3);
        }

        private void SetIconColor(string color)
        {
            IconColor = color;
            SetIconColor1.SetActive(false);
            SetIconColor2.SetActive(false);
            SetIconColor3.SetActive(false);
            SetIconColor4.SetActive(false);
            SetIconColor5.SetActive(false);
            SetIconColor6.SetActive(false);
            switch (color)
            {
                case "blue":
                    SetIconShape1.Image = Properties.Resources.IconSphereBlue;
                    SetIconShape2.Image = Properties.Resources.IconDiamondBlue;
                    SetIconShape3.Image = Properties.Resources.IconHexaBlue;
                    SetIconShape4.Image = Properties.Resources.IconSquareBlue;
                    SetIconShape5.Image = Properties.Resources.IconStarBlue;
                    SetIconShape6.Image = Properties.Resources.IconTriangleBlue;
                    SetIconColor1.SetActive(true);
                    break;
                case "brown":
                    SetIconShape1.Image = Properties.Resources.IconSphereBrown;
                    SetIconShape2.Image = Properties.Resources.IconDiamondBrown;
                    SetIconShape3.Image = Properties.Resources.IconHexaBrown;
                    SetIconShape4.Image = Properties.Resources.IconSquareBrown;
                    SetIconShape5.Image = Properties.Resources.IconStarBrown;
                    SetIconShape6.Image = Properties.Resources.IconTriangleBrown;
                    SetIconColor2.SetActive(true);
                    break;
                case "green":
                    SetIconShape1.Image = Properties.Resources.IconSphereGreen;
                    SetIconShape2.Image = Properties.Resources.IconDiamondGreen;
                    SetIconShape3.Image = Properties.Resources.IconHexaGreen;
                    SetIconShape4.Image = Properties.Resources.IconSquareGreen;
                    SetIconShape5.Image = Properties.Resources.IconStarGreen;
                    SetIconShape6.Image = Properties.Resources.IconTriangleGreen;
                    SetIconColor3.SetActive(true);
                    break;
                case "red":
                    SetIconShape1.Image = Properties.Resources.IconSphereRed;
                    SetIconShape2.Image = Properties.Resources.IconDiamondRed;
                    SetIconShape3.Image = Properties.Resources.IconHexaRed;
                    SetIconShape4.Image = Properties.Resources.IconSquareRed;
                    SetIconShape5.Image = Properties.Resources.IconStarRed;
                    SetIconShape6.Image = Properties.Resources.IconTriangleRed;
                    SetIconColor4.SetActive(true);
                    break;
                case "white":
                    SetIconShape1.Image = Properties.Resources.IconSphereWhite;
                    SetIconShape2.Image = Properties.Resources.IconDiamondWhite;
                    SetIconShape3.Image = Properties.Resources.IconHexaWhite;
                    SetIconShape4.Image = Properties.Resources.IconSquareWhite;
                    SetIconShape5.Image = Properties.Resources.IconStarWhite;
                    SetIconShape6.Image = Properties.Resources.IconTriangleWhite;
                    SetIconColor5.SetActive(true);
                    break;
                case "yellow":
                    SetIconShape1.Image = Properties.Resources.IconSphereYellow;
                    SetIconShape2.Image = Properties.Resources.IconDiamondYellow;
                    SetIconShape3.Image = Properties.Resources.IconHexaYellow;
                    SetIconShape4.Image = Properties.Resources.IconSquareYellow;
                    SetIconShape5.Image = Properties.Resources.IconStarYellow;
                    SetIconShape6.Image = Properties.Resources.IconTriangleYellow;
                    SetIconColor6.SetActive(true);
                    break;
                default:
                    break;
            }
        }

        private void SetIconColor1_Click(object sender, EventArgs e)
        {
            SetIconColor("blue");
        }

        private void SetIconColor2_Click(object sender, EventArgs e)
        {
            SetIconColor("brown");
        }

        private void SetIconColor3_Click(object sender, EventArgs e)
        {
            SetIconColor("green");
        }

        private void SetIconColor4_Click(object sender, EventArgs e)
        {
            SetIconColor("red");
        }

        private void SetIconColor5_Click(object sender, EventArgs e)
        {
            SetIconColor("white");
        }

        private void SetIconColor6_Click(object sender, EventArgs e)
        {
            SetIconColor("yellow");
        }

        private void SetIconShape(string shape)
        {
            IconShape = shape;
        }

        private void SetIconShape1_Click(object sender, EventArgs e)
        {
            ShowIcon = true;
            SetIconShape("sphere");
            mw.UpdateMapIcon(ShowIcon, IconSize, IconColor, IconShape);
            mw.RemoveMapIconPanel();
        }

        private void SetIconShape2_Click(object sender, EventArgs e)
        {
            ShowIcon = true;
            SetIconShape("diamond");
            mw.UpdateMapIcon(ShowIcon, IconSize, IconColor, IconShape);
            mw.RemoveMapIconPanel();
        }

        private void SetIconShape3_Click(object sender, EventArgs e)
        {
            ShowIcon = true;
            SetIconShape("hexa");
            mw.UpdateMapIcon(ShowIcon, IconSize, IconColor, IconShape);
            mw.RemoveMapIconPanel();
        }

        private void SetIconShape4_Click(object sender, EventArgs e)
        {
            ShowIcon = true;
            SetIconShape("square");
            mw.UpdateMapIcon(ShowIcon, IconSize, IconColor, IconShape);
            mw.RemoveMapIconPanel();
        }

        private void SetIconShape5_Click(object sender, EventArgs e)
        {
            ShowIcon = true;
            SetIconShape("star");
            mw.UpdateMapIcon(ShowIcon, IconSize, IconColor, IconShape);
            mw.RemoveMapIconPanel();
        }

        private void SetIconShape6_Click(object sender, EventArgs e)
        {
            ShowIcon = true;
            SetIconShape("triangle");
            mw.UpdateMapIcon(ShowIcon, IconSize, IconColor, IconShape);
            mw.RemoveMapIconPanel();
        }

        private void HideIcon_Click(object sender, EventArgs e)
        {
            ShowIcon = false;
            mw.UpdateMapIcon(ShowIcon, IconSize, IconColor, IconShape);
            mw.RemoveMapIconPanel();
        }
    }
}

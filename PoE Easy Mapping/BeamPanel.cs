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
    public partial class BeamPanel : UserControl
    {
        MainWindow mw;
        bool ShowBeam = true;
        string BeamColor = "blue";

        public BeamPanel(MainWindow mwref)
        {
            this.mw = mwref;
            InitializeComponent();
        }

        public void Init(string color)
        {
            BeamColor = color;
            SetBeamColor(BeamColor);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
        }

        private void OutsidePanel_Click(object sender, EventArgs e)
        {
            mw.RemoveBeamPanel();
        }

        private void SetBeamColor(string color)
        {
            ShowBeam = true;
            BeamColor = color;
            mw.UpdateBeamIcon(ShowBeam, BeamColor);
            mw.RemoveBeamPanel();
        }

        private void SetBeamColor1_Click(object sender, EventArgs e)
        {
            SetBeamColor("blue");
        }

        private void SetBeamColor2_Click(object sender, EventArgs e)
        {
            SetBeamColor("brown");
        }

        private void SetBeamColor3_Click(object sender, EventArgs e)
        {
            SetBeamColor("green");
        }

        private void SetBeamColor4_Click(object sender, EventArgs e)
        {
            SetBeamColor("red");
        }

        private void SetBeamColor5_Click(object sender, EventArgs e)
        {
            SetBeamColor("white");
        }

        private void SetBeamColor6_Click(object sender, EventArgs e)
        {
            SetBeamColor("yellow");
        }

        private void HideBeam_Click(object sender, EventArgs e)
        {
            ShowBeam = false;
            mw.UpdateBeamIcon(ShowBeam, BeamColor);
            mw.RemoveBeamPanel();
        }
    }
}

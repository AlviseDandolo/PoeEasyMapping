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
    public partial class SaveStylePanel : UserControl
    {
        MainWindow mw;

        public SaveStylePanel()
        {
            InitializeComponent();
        }

        public SaveStylePanel(MainWindow mwref)
        {
            this.mw = mwref;
            InitializeComponent();
        }

        public void Init()
        {

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
        }

        private void OutsidePanel_Click(object sender, EventArgs e)
        {
            mw.RemoveSaveStylePanel();
        }

        private void SaveNewStyleAs_Click(object sender, EventArgs e)
        {
            if (mw.ValidNewStyleName(NewStyleName.Text))
            {
                ErrorRect.Visible = false;
                mw.SaveStyleAsNew(NewStyleName.Text);
                mw.RemoveSaveStylePanel();
            }
            else
            {
                ErrorRect.Visible = true;
            }
        }

        private void NewStyleName_Enter(object sender, EventArgs e)
        {
            Form.ActiveForm.AcceptButton = SaveNewStyleAs; // Button1 will be 'clicked' when user presses return
        }

        private void NewStyleName_Leave(object sender, EventArgs e)
        {
            Form.ActiveForm.AcceptButton = null; // remove "return" button behavior
        }
    }
}

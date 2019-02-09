using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Drawing.Imaging;

namespace PoE_Easy_Mapping
{
    public partial class MainWindow : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        PrivateFontCollection Pfc = new PrivateFontCollection();

        static FlatTab SettingsTabRef, StylesTabRef;
        static Panel SettingsContentRef, StylesContentRef;
        static List<TabContentPair> TabList;

        static Bitmap SampleOriginalBgImage;

        public MainWindow()
        {
            AddFontFromResource(Pfc, Properties.Resources.Fontin_SmallCaps);
            InitializeComponent();
            NormalizeFont();

            SettingsTabRef = SettingsTab;
            SettingsContentRef = SettingsContent;
            StylesTabRef = StylesTab;
            StylesContentRef = StylesContent;
            
            TabList = new List<TabContentPair>
            {
                new TabContentPair{ Tab = SettingsTabRef, Content = SettingsContentRef },
                new TabContentPair{ Tab = StylesTabRef, Content = StylesContentRef }
            };
            SetActiveTab(StylesTab);

            SampleOriginalBgImage = (Bitmap)SamplePicture.Image.Clone();

            TabClicked += ClickedOnTab;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Size = new Size(800, 600);
        }

        private void MainWindowTitle_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
            this.ShowInTaskbar = false;
        }

        private void ReduceButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TrayBarIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void TrayMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Close();
        }

        private static void AddFontFromResource(PrivateFontCollection privateFontCollection, byte[] fontResource)
        {
            string fonttmpfile = string.Concat(Path.GetTempPath(), "TmpFont");

            File.WriteAllBytes(fonttmpfile, fontResource);
            privateFontCollection.AddFontFile(fonttmpfile);
        }

        // Tab Event Handling
        public event EventHandler<TabClickEventArgs> TabClicked;
        public class TabClickEventArgs : EventArgs
        {
            public TabClickEventArgs(FlatTab source)
            {
                ClickSource = source;
            }
            public FlatTab ClickSource { get; set; }
        }
        protected virtual void OnTabClicked(TabClickEventArgs e)
        {
            TabClicked?.Invoke(this, e);
        }

        // Tab Event Tab Bindings
        private void SettingsTab_Click(object sender, EventArgs e)
        {
            OnTabClicked(new TabClickEventArgs(SettingsTab));
        }
        private void StylesTab_Click(object sender, EventArgs e)
        {
            OnTabClicked(new TabClickEventArgs(StylesTab));
        }

        private struct TabContentPair
        {
            public FlatTab Tab;
            public Panel Content;
        }

        // Tab OnClick Event
        static void ClickedOnTab(object sender, TabClickEventArgs e)
        {
            SetActiveTab(e.ClickSource);
        }

        private void TrackBarAlpha_Scroll(object sender, EventArgs e)
        {
            SamplePicture.Image = SetAlpha(SampleOriginalBgImage, TrackBarAlpha.Value);
        }

        private static void SetActiveTab(FlatTab tab)
        {
            foreach (TabContentPair tbc in TabList)
            {
                if (tbc.Tab.Name == tab.Name)
                {
                    tbc.Tab.SetActive(true);
                    tbc.Content.Show();
                }
                else
                {
                    tbc.Tab.SetActive(false);
                    tbc.Content.Hide();
                }
            }
        }

        static Bitmap SetAlpha(Bitmap bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha / 255f;
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float[][] matrixItems = {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, a, 0},
                new float[] {0, 0, 0, 0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(bmpOut))
                g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }
    }
}

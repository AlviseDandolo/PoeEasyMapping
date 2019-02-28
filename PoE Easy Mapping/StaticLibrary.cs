using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PoE_Easy_Mapping
{
    public class Library
    {
        public struct TabContentPair
        {
            public FlatTab Tab;
            public Panel Content;
        }
    }

    public class TabClickEventArgs : EventArgs
    {
        public TabClickEventArgs(List<Library.TabContentPair> tabList, FlatTab source)
        {
            FullTabList = tabList;
            ClickSource = source;
        }
        public FlatTab ClickSource { get; set; }
        public List<Library.TabContentPair> FullTabList { get; set; }
    }

    static class StaticLibrary
    {
        // Window drag start
        public static int WM_NCLBUTTONDOWN = 0xA1;
        public static int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // Window drag end

        // Load timer start
        private static System.Timers.Timer LoadedTimer;
        public static void StartLoadingTimer(int loadingTime, Action<object, EventArgs> callback){
            LoadedTimer = new System.Timers.Timer(loadingTime);
            LoadedTimer.Elapsed += new ElapsedEventHandler(new ElapsedEventHandler(DisposeLoadingTimer));
            LoadedTimer.Elapsed += new ElapsedEventHandler(new ElapsedEventHandler(callback));
            LoadedTimer.Start();
        }
        private static void DisposeLoadingTimer(object sender, EventArgs e)
        {
            LoadedTimer.Dispose();
        }
        // Load timer end
        
        // Default config data start
        public static void CreateData(string path)
        {
            XDocument config =
            new XDocument(
                new XElement("Configuration",
                    new XElement("Styles")
                )
            );
            config.Save(path);
        }
        // Default config data end

        // Tab start
        public static void SetActiveTab(List<Library.TabContentPair> tabList, FlatTab tab)
        {
            foreach (Library.TabContentPair tbc in tabList)
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
        // Tab end

        // Dynamic font start
        private static PrivateFontCollection Pfc = new PrivateFontCollection();
        public static void AddFontFromResource(byte[] fontResource)
        {
            string fonttmpfile = string.Concat(Path.GetTempPath(), "TmpFont");

            File.WriteAllBytes(fonttmpfile, fontResource);
            Pfc.AddFontFile(fonttmpfile);
        }
        public static FontFamily GetMainFont()
        {
            return Pfc.Families[0];
        }
        // Dynamic font end
        
        // Utility start
        public static string ToHexValue(Color color)
        {
            return "#" + color.R.ToString("X2") +
                         color.G.ToString("X2") +
                         color.B.ToString("X2");
        }

        // Usage: SamplePicture.Image = SetAlpha(SampleOriginalBgImage, TrackBarAlpha.Value);
        public static Bitmap SetAlpha(Bitmap bmpIn, int alpha)
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
        // Utility end

        public static void ReloadSoundOptions(ComboBox select)
        {
            select.Items.Clear();
            select.Items.AddRange(new object[] {
                new ComboBoxItem("None", "0"),
                new ComboBoxItem("Sound 1", "1"),
                new ComboBoxItem("Sound 2", "2"),
                new ComboBoxItem("Sound 3", "3"),
                new ComboBoxItem("Sound 4", "4"),
                new ComboBoxItem("Sound 5", "5"),
                new ComboBoxItem("Sound 6", "6"),
                new ComboBoxItem("Sound 7", "7"),
                new ComboBoxItem("Sound 8", "8"),
                new ComboBoxItem("Sound 9", "9"),
                new ComboBoxItem("Sound 10", "10"),
                new ComboBoxItem("Sound 11", "11"),
                new ComboBoxItem("Sound 12", "12"),
                new ComboBoxItem("Sound 13", "13"),
                new ComboBoxItem("Sound 14", "14"),
                new ComboBoxItem("Sound 15", "15"),
                new ComboBoxItem("Sound 16", "16"),
                new ComboBoxItem("Orb of Alchemy", "shAlchemy"),
                new ComboBoxItem("Blessed Orb", "shBlessed"),
                new ComboBoxItem("Chaos Orb", "shChaos"),
                new ComboBoxItem("Orb of Fusing", "shFusing"),
                new ComboBoxItem("Orb of immense power", "shGeneral"),
                new ComboBoxItem("Regal Orb", "shRegal"),
                new ComboBoxItem("Vaal Orb", "shVaal"),
                new ComboBoxItem("Divine Orb", "shDivine"),
                new ComboBoxItem("Exalted Orb", "shExalted"),
                new ComboBoxItem("Mirror of Kalandra", "shMirror")
            });
            select.SelectedItem = select.Items[0];
        }
        
        public static void InitAppFiles(string TempPath)
        {
            var path = Path.Combine(TempPath, @"Sounds\");
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            File.WriteAllBytes(Path.Combine(path, "AlertSound1.mp3"), Properties.Resources.AlertSound1);
            File.WriteAllBytes(Path.Combine(path, "AlertSound2.mp3"), Properties.Resources.AlertSound2);
            File.WriteAllBytes(Path.Combine(path, "AlertSound3.mp3"), Properties.Resources.AlertSound3);
            File.WriteAllBytes(Path.Combine(path, "AlertSound4.mp3"), Properties.Resources.AlertSound4);
            File.WriteAllBytes(Path.Combine(path, "AlertSound5.mp3"), Properties.Resources.AlertSound5);
            File.WriteAllBytes(Path.Combine(path, "AlertSound6.mp3"), Properties.Resources.AlertSound6);
            File.WriteAllBytes(Path.Combine(path, "AlertSound7.mp3"), Properties.Resources.AlertSound7);
            File.WriteAllBytes(Path.Combine(path, "AlertSound8.mp3"), Properties.Resources.AlertSound8);
            File.WriteAllBytes(Path.Combine(path, "AlertSound9.mp3"), Properties.Resources.AlertSound9);
            File.WriteAllBytes(Path.Combine(path, "AlertSound10.mp3"), Properties.Resources.AlertSound10);
            File.WriteAllBytes(Path.Combine(path, "AlertSound11.mp3"), Properties.Resources.AlertSound11);
            File.WriteAllBytes(Path.Combine(path, "AlertSound12.mp3"), Properties.Resources.AlertSound12);
            File.WriteAllBytes(Path.Combine(path, "AlertSound13.mp3"), Properties.Resources.AlertSound13);
            File.WriteAllBytes(Path.Combine(path, "AlertSound14.mp3"), Properties.Resources.AlertSound14);
            File.WriteAllBytes(Path.Combine(path, "AlertSound15.mp3"), Properties.Resources.AlertSound15);
            File.WriteAllBytes(Path.Combine(path, "AlertSound16.mp3"), Properties.Resources.AlertSound16);
            File.WriteAllBytes(Path.Combine(path, "AlertSoundShAlchemy.mp3"), Properties.Resources.AlertSoundShAlchemy);
            File.WriteAllBytes(Path.Combine(path, "AlertSoundShBlessed.mp3"), Properties.Resources.AlertSoundShBlessed);
            File.WriteAllBytes(Path.Combine(path, "AlertSoundShChaos.mp3"), Properties.Resources.AlertSoundShChaos);
            File.WriteAllBytes(Path.Combine(path, "AlertSoundShFusing.mp3"), Properties.Resources.AlertSoundShFusing);
            File.WriteAllBytes(Path.Combine(path, "AlertSoundShGeneral.mp3"), Properties.Resources.AlertSoundShGeneral);
            File.WriteAllBytes(Path.Combine(path, "AlertSoundShRegal.mp3"), Properties.Resources.AlertSoundShRegal);
            File.WriteAllBytes(Path.Combine(path, "AlertSoundShVaal.mp3"), Properties.Resources.AlertSoundShVaal);
            File.WriteAllBytes(Path.Combine(path, "AlertSoundShDivine.mp3"), Properties.Resources.AlertSoundShDivine);
            File.WriteAllBytes(Path.Combine(path, "AlertSoundShExalted.mp3"), Properties.Resources.AlertSoundShExalted);
            File.WriteAllBytes(Path.Combine(path, "AlertSoundShMirror.mp3"), Properties.Resources.AlertSoundShMirror);
        }
    }
}

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
                    new XElement("Styles",
                        new XElement("Style",
                            new XAttribute("Name", "Fallback"),
                            new XElement("Params",
                                new XAttribute("FontSize", 30),
                                new XAttribute("FontColor", "#CC0000"),
                                new XAttribute("FontAlpha", 200),
                                new XAttribute("BackgroundColor", "#000000"),
                                new XAttribute("BackgroundAlpha", 100),
                                new XAttribute("BorderColor", "#CC0000"),
                                new XAttribute("BorderAlpha", 200),
                                new XAttribute("MinimapIconSize", "0"),
                                new XAttribute("MinimapIconColor", "Blue"),
                                new XAttribute("MinimapIconShape", "Circle"),
                                new XAttribute("LightBeamColor", "Blue"),
                                new XAttribute("LightBeamTemp", false),
                                new XAttribute("AlertSound", "1"),
                                new XAttribute("AlertSoundVolume", "300"),
                                new XAttribute("DropSound", false)
                            )
                        )
                    )
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
    }
}

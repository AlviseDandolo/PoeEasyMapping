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
using System.Xml.Linq;
using System.Xml;
using System.Timers;
using System.Text.RegularExpressions;
using PoE_Easy_Mapping;

namespace PoE_Easy_Mapping
{
    public partial class MainWindow : Form
    {
        delegate void ReturningVoidDelegate();

        static FlatTab SettingsTabRef, StylesTabRef;
        static Panel SettingsContentRef, StylesContentRef;
        static List<Library.TabContentPair> MainTabList;

        private XElement GlobalConfig;
        private IEnumerable<XElement> Themes;

        static Bitmap SampleOriginalBgImage;

        public event EventHandler<TabClickEventArgs> MainTabClicked;

        public MainWindow()
        {
            LoadData();

            StaticLibrary.AddFontFromResource(Properties.Resources.Fontin_SmallCaps);
            InitializeComponent();
            NormalizeFont();

            // Main tabs start
            SettingsTabRef = SettingsTab;
            SettingsContentRef = SettingsContent;
            StylesTabRef = StylesTab;
            StylesContentRef = StylesContent;
            MainTabList = new List<Library.TabContentPair>
            {
                new Library.TabContentPair{ Tab = SettingsTabRef, Content = SettingsContentRef },
                new Library.TabContentPair{ Tab = StylesTabRef, Content = StylesContentRef }
            };
            StaticLibrary.SetActiveTab(MainTabList, StylesTab);
            MainTabClicked += ClickedOnTab;
            // Main tabs end

            SampleOriginalBgImage = (Bitmap)SamplePicture.Image.Clone();
            SampleText.Parent = SamplePicture;
            SampleSockets.Parent = SamplePicture;

            StaticLibrary.StartLoadingTimer(300, AfterLoaded);
        }

        private void AfterLoaded(object sender, EventArgs e)
        {
            PopulateComponents();
        }

        private void PopulateComponents()
        {
            if (ThemeSelectBox.InvokeRequired)
            {
                ReturningVoidDelegate d = new ReturningVoidDelegate(PopulateComponents);
                this.Invoke(d, new object[] {});
            }
            else
            {
                foreach (XElement Theme in Themes)
                {
                    ThemeSelectBox.Items.Add(new ComboBoxItem(Theme.Attribute("Name").Value, Theme.Attribute("Name").Value));
                }
                ThemeSelectBox.SelectedItem = ThemeSelectBox.Items[0];
            }
        }

        private void LoadData()
        {
            // Load the XML file from our project directory containing the purchase orders
            var filename = "config.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var configFilepath = Path.Combine(currentDirectory, filename);

            //if (!File.Exists(configFilepath))
            {
                StaticLibrary.CreateData(configFilepath);
            }

            GlobalConfig = XElement.Load($"{configFilepath}");
            
            Themes = from theme in GlobalConfig.Descendants("Theme") select theme;
        }

        // Main Tab Event Handling
        protected virtual void OnTabClicked(TabClickEventArgs e)
        {
            MainTabClicked?.Invoke(this, e);
        }
        // Tab OnClick Event
        static void ClickedOnTab(object sender, TabClickEventArgs e)
        {
            StaticLibrary.SetActiveTab(e.FullTabList, e.ClickSource);
        }
        

        // Alpha: int between 0 and 255
        private void ReloadSampleAlpha()
        {
            int BackgroundAlpha = (int)BackgroundAlphaTextBox.Value, FontAlpha = (int)FontAlphaTextBox.Value, BorderAlpha = (int)BorderAlphaTextBox.Value;

            if (BackgroundAlpha < 0) BackgroundAlpha = 0; if (BackgroundAlpha > 255) BackgroundAlpha = 255;
            SampleRect.BackColor = SampleText.BackColor = SampleSockets.BackColor = Color.FromArgb(BackgroundAlpha, SampleRect.BackColor);

            if (FontAlpha < 0) FontAlpha = 0; if (FontAlpha > 255) FontAlpha = 255;
            SampleText.ForeColor = Color.FromArgb(FontAlpha, SampleText.ForeColor);

            if (BorderAlpha < 0) BorderAlpha = 0; if (BorderAlpha > 255) BorderAlpha = 255;
            SampleRect.BorderColor = Color.FromArgb(BorderAlpha, SampleRect.BorderColor);
        }

        // Size: int between 18 and 45
        private void ReloadSampleSize(int Size)
        {
            if (Size < 18) Size = 18;
            if (Size > 45) Size = 45;
            // Text height
            SampleText.Font = new Font(SampleText.Font.FontFamily, (Size * 2 / 3), SampleText.Font.Style, SampleText.Font.Unit);
            SampleText.Height = Size - 4;
            // Rect height
            SampleRect.Height = (Size * 2 / 3) + 15;
            // Rect width
            SampleRect.Width = (int)(SampleText.WidthCoefficient * SampleText.Font.Size * 1.1f) + 20;
            // Text width
            SampleText.Width = SampleRect.Width - 4 - 20;
            
            // Rect position
            SampleRect.Location = new Point((SampleContent.Width - SampleRect.Width) / 2, (SampleContent.Height - SampleRect.Height) / 2);
            // Text position
            SampleText.Location = new Point(SampleRect.Location.X + 4, SampleRect.Location.Y + 2 + ((SampleRect.Height - 4) - SampleText.Height)/2);
            // Sockets position
            SampleSockets.Location = new Point(SampleRect.Location.X + (SampleRect.Width - 20), SampleRect.Location.Y + (SampleRect.Height-16) / 2);
            SampleSockets.Visible = true;

            SampleText.Parent = SampleContent;
            SampleText.Refresh();
            SampleRect.Refresh();
            SampleText.Parent = SamplePicture;
            ReloadSampleAlpha();
        }

        // ############### Interface Events START ###############
        private void StyleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            XElement SelectedTheme = (from Themes in GlobalConfig.Descendants("Theme") where Themes.Attribute("Name").Value == ThemeSelectBox.SelectedItem.ToString() select Themes).First<XElement>();
            IEnumerable<XElement> SelectedThemeBlockList = from Blocks in SelectedTheme.Descendants("Block") select Blocks;

            IEnumerable<XElement> BlockStyle = (from Blocks in SelectedThemeBlockList where Blocks.Attribute("Name").Value == StyleList.SelectedItem.ToString() select Blocks.Descendants("Style")).First();

            FontSizeTextBox.Value = Decimal.Parse(BlockStyle.First().Attribute("FontSize").Value);
            FontColorTextBox.Text = BlockStyle.First().Attribute("FontColor").Value;
            FontAlphaTextBox.Value = Decimal.Parse(BlockStyle.First().Attribute("FontAlpha").Value);
            BorderColorTextBox.Text = BlockStyle.First().Attribute("BorderColor").Value;
            BorderAlphaTextBox.Value = Decimal.Parse(BlockStyle.First().Attribute("BorderAlpha").Value);
            BackgroundColorTextBox.Text = BlockStyle.First().Attribute("BackgroundColor").Value;
            BackgroundAlphaTextBox.Value = Decimal.Parse(BlockStyle.First().Attribute("BackgroundAlpha").Value);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Size = new Size(800, 600);
        }

        private void MainWindowTitle_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                StaticLibrary.ReleaseCapture();
                StaticLibrary.SendMessage(Handle, StaticLibrary.WM_NCLBUTTONDOWN, StaticLibrary.HT_CAPTION, 0);
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

        // Tab Click Bindings
        private void SettingsTab_Click(object sender, EventArgs e)
        {
            OnTabClicked(new TabClickEventArgs(MainTabList, SettingsTab));
        }
        private void StylesTab_Click(object sender, EventArgs e)
        {
            OnTabClicked(new TabClickEventArgs(MainTabList, StylesTab));
        }

        private void FontAlphaTextBox_ValueChanged(object sender, EventArgs e)
        {
            int newValue = (int)((NumericUpDown)sender).Value;
            if (newValue < ((NumericUpDown)sender).Minimum) newValue = (int)((NumericUpDown)sender).Minimum;
            if (newValue > ((NumericUpDown)sender).Maximum) newValue = (int)((NumericUpDown)sender).Maximum;
            if (newValue != TrackBarFontAlpha.Value)
            {
                TrackBarFontAlpha.Value = newValue;
            }

            ReloadSampleAlpha();
        }

        private void BorderAlphaTextBox_ValueChanged(object sender, EventArgs e)
        {
            int newValue = (int)((NumericUpDown)sender).Value;
            if (newValue < ((NumericUpDown)sender).Minimum) newValue = (int)((NumericUpDown)sender).Minimum;
            if (newValue > ((NumericUpDown)sender).Maximum) newValue = (int)((NumericUpDown)sender).Maximum;
            if (newValue != TrackBarBorderAlpha.Value)
            {
                TrackBarBorderAlpha.Value = newValue;
            }

            ReloadSampleAlpha();
        }

        private void BackgroundAlphaTextBox_ValueChanged(object sender, EventArgs e)
        {
            int newValue = (int)((NumericUpDown)sender).Value;
            if (newValue < ((NumericUpDown)sender).Minimum) newValue = (int)((NumericUpDown)sender).Minimum;
            if (newValue > ((NumericUpDown)sender).Maximum) newValue = (int)((NumericUpDown)sender).Maximum;
            if (newValue != TrackBarBackgroundAlpha.Value)
            {
                TrackBarBackgroundAlpha.Value = newValue;
            }

            ReloadSampleAlpha();
        }

        private void TrackBarFontSize_ValueChanged(object sender, EventArgs e)
        {
            int newValue = ((Slider)sender).Value;
            if (newValue < ((Slider)sender).Minimum) newValue = ((Slider)sender).Minimum;
            if (newValue > ((Slider)sender).Maximum) newValue = ((Slider)sender).Maximum;
            if ((int)FontSizeTextBox.Value != newValue)
            {
                FontSizeTextBox.Text = newValue.ToString();
            }
        }

        private void FontSizeTextBox_ValueChanged(object sender, EventArgs e)
        {
            int newValue = (int)((NumericUpDown)sender).Value;
            if (newValue < ((NumericUpDown)sender).Minimum) newValue = (int)((NumericUpDown)sender).Minimum;
            if (newValue > ((NumericUpDown)sender).Maximum) newValue = (int)((NumericUpDown)sender).Maximum;
            if (newValue != TrackBarFontSize.Value)
            {
                TrackBarFontSize.Value = newValue;
            }

            ReloadSampleSize(newValue);
        }

        private void SetTextColor1_Click(object sender, EventArgs e)
        {
            FontColorTextBox.Text = "FFFFFF";
        }

        private void SetTextColor2_Click(object sender, EventArgs e)
        {
            FontColorTextBox.Text = "000000";
        }

        private void SetTextColor3_Click(object sender, EventArgs e)
        {
            FontColorTextBox.Text = "8B0000";
        }

        private void SetTextColor4_Click(object sender, EventArgs e)
        {
            FontColorTextBox.Text = "006400";
        }

        private void SetTextColor5_Click(object sender, EventArgs e)
        {
            FontColorTextBox.Text = "4682B4";
        }

        private void SetTextColor6_Click(object sender, EventArgs e)
        {
            FontColorTextBox.Text = "DAA520";
        }

        private void SetTextColor7_Click(object sender, EventArgs e)
        {
            FontColorTextBox.Text = "696969";
        }

        private void TrackBarFontAlpha_ValueChanged(object sender, EventArgs e)
        {
            int newValue = ((Slider)sender).Value;
            if (newValue < ((Slider)sender).Minimum) newValue = ((Slider)sender).Minimum;
            if (newValue > ((Slider)sender).Maximum) newValue = ((Slider)sender).Maximum;
            if ((int)FontSizeTextBox.Value != newValue)
            {
                FontAlphaTextBox.Text = newValue.ToString();
            }
        }

        private void TrackBarBorderAlpha_ValueChanged(object sender, EventArgs e)
        {
            int newValue = ((Slider)sender).Value;
            if (newValue < ((Slider)sender).Minimum) newValue = ((Slider)sender).Minimum;
            if (newValue > ((Slider)sender).Maximum) newValue = ((Slider)sender).Maximum;
            if ((int)BorderAlphaTextBox.Value != newValue)
            {
                BorderAlphaTextBox.Text = newValue.ToString();
            }
        }

        private void TrackBarBackgroundAlpha_ValueChanged(object sender, EventArgs e)
        {
            int newValue = ((Slider)sender).Value;
            if (newValue < ((Slider)sender).Minimum) newValue = ((Slider)sender).Minimum;
            if (newValue > ((Slider)sender).Maximum) newValue = ((Slider)sender).Maximum;
            if ((int)BackgroundAlphaTextBox.Value != newValue)
            {
                BackgroundAlphaTextBox.Text = newValue.ToString();
            }
        }

        private void FontColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string newValue = Regex.Replace(((TextBox)sender).Text, @"[^0-9A-Fa-f]", "");
            if (newValue.Length == 3 || newValue.Length == 6)
            {
                FontColorTextBox.Text = newValue;
                SampleText.ForeColor = ColorTranslator.FromHtml(string.Concat("#", newValue));
                ReloadSampleAlpha();
            }
        }

        private void BorderColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string newValue = Regex.Replace(((TextBox)sender).Text, @"[^0-9A-Fa-f]", "");
            if (newValue.Length == 3 || newValue.Length == 6)
            {
                BorderColorTextBox.Text = newValue;
                SampleRect.BorderColor = ColorTranslator.FromHtml(string.Concat("#", newValue));
                ReloadSampleAlpha();
            }
        }

        private void BackgroundColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string newValue = Regex.Replace(((TextBox)sender).Text, @"[^0-9A-Fa-f]", "");
            if (newValue.Length == 3 || newValue.Length == 6)
            {
                BackgroundColorTextBox.Text = newValue;
                SampleText.BackColor = SampleRect.BackColor = ColorTranslator.FromHtml(string.Concat("#", newValue));
                ReloadSampleAlpha();
            }
        }

        private void TextColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog CDialog = new ColorDialog();

            // Show the color dialog.
            DialogResult result = CDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                Color newValue = CDialog.Color;
                string newHexValue = StaticLibrary.ToHexValue(newValue);
                SampleText.ForeColor = newValue;
                FontColorTextBox.Text = newHexValue.Replace("#", "");
            }
        }

        private void SetBorderColor1_Click(object sender, EventArgs e)
        {
            BorderColorTextBox.Text = "FFFFFF";
        }

        private void SetBorderColor2_Click(object sender, EventArgs e)
        {
            BorderColorTextBox.Text = "000000";
        }

        private void SetBorderColor3_Click(object sender, EventArgs e)
        {
            BorderColorTextBox.Text = "8B0000";
        }

        private void SetBorderColor4_Click(object sender, EventArgs e)
        {
            BorderColorTextBox.Text = "006400";
        }

        private void SetBorderColor5_Click(object sender, EventArgs e)
        {
            BorderColorTextBox.Text = "4682B4";
        }

        private void SetBorderColor6_Click(object sender, EventArgs e)
        {
            BorderColorTextBox.Text = "DAA520";
        }

        private void SetBorderColor7_Click(object sender, EventArgs e)
        {
            BorderColorTextBox.Text = "696969";
        }

        private void BorderColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog CDialog = new ColorDialog();

            // Show the color dialog.
            DialogResult result = CDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                Color newValue = CDialog.Color;
                string newHexValue = StaticLibrary.ToHexValue(newValue);
                SampleRect.BorderColor = newValue;
                FontColorTextBox.Text = newHexValue.Replace("#", "");
            }
        }

        private void SetBackgroundColor1_Click(object sender, EventArgs e)
        {
            BackgroundColorTextBox.Text = "FFFFFF";
        }

        private void SetBackgroundColor2_Click(object sender, EventArgs e)
        {
            BackgroundColorTextBox.Text = "000000";
        }

        private void SetBackgroundColor3_Click(object sender, EventArgs e)
        {
            BackgroundColorTextBox.Text = "8B0000";
        }

        private void SetBackgroundColor4_Click(object sender, EventArgs e)
        {
            BackgroundColorTextBox.Text = "006400";
        }

        private void SetBackgroundColor5_Click(object sender, EventArgs e)
        {
            BackgroundColorTextBox.Text = "4682B4";
        }

        private void SetBackgroundColor6_Click(object sender, EventArgs e)
        {
            BackgroundColorTextBox.Text = "DAA520";
        }

        private void SetBackgroundColor7_Click(object sender, EventArgs e)
        {
            BackgroundColorTextBox.Text = "696969";
        }

        private void BackgroundColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog CDialog = new ColorDialog();

            // Show the color dialog.
            DialogResult result = CDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                Color newValue = CDialog.Color;
                string newHexValue = StaticLibrary.ToHexValue(newValue);
                SampleText.BackColor = SampleRect.BackColor = SampleSockets.BackColor = newValue;
                FontColorTextBox.Text = newHexValue.Replace("#", "");
            }
        }
        // ############### Interface Events END   ###############

    }
}

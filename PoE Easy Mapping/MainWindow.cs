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
using System.Resources;
using WMPLib;

namespace PoE_Easy_Mapping
{
    public partial class MainWindow : Form
    {
        delegate void ReturningVoidDelegate();

        static FlatTab SettingsTabRef, StylesTabRef;
        static Panel SettingsContentRef, StylesContentRef;
        static List<Library.TabContentPair> MainTabList;

        // Load the XML file from our project directory containing the purchase orders
        private string configFilepath = Path.Combine(Directory.GetCurrentDirectory(), "config.xml");
        private XElement GlobalConfig;
        private IEnumerable<XElement> Styles;
        private XElement CopiedStyle;

        static Bitmap SampleOriginalBgImage;

        public event EventHandler<TabClickEventArgs> MainTabClicked;

        MapIconPanel mip;
        BeamPanel bp;
        SaveStylePanel ssp;

        private string TempPath = Path.Combine(Path.GetTempPath(), @"PoEM\");
        private string FilterPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Path of Exile\\EasyMapping.filter";
        private string FilterSoundsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Path of Exile\\EasyMappingSounds\\";
        private List<string> SoundList;
        System.Media.SoundPlayer wavplayer;
        WMPLib.WindowsMediaPlayer mp3player;

        // Style info
        private int Volume = 300;
        private bool PlaySounds = true;

        // Subpanel info
        private bool ShowMapIcon = false;
        private int MapIconSize = 1;
        private string MapIconShape = "sphere";
        private string MapIconColor = "blue";
        private bool ShowBeam = false;
        private string BeamColor = "blue";
        private bool BeamTemporary = false;

        public MainWindow()
        {
            StaticLibrary.InitAppFiles(TempPath);
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
            StaticLibrary.SetActiveTab(MainTabList, SettingsTab);
            MainTabClicked += ClickedOnTab;
            // Main tabs end

            SampleOriginalBgImage = (Bitmap)SamplePicture.Image.Clone();
            SampleRect.Parent.Parent = SamplePicture;
            SampleRect.Location = new Point(SampleText.Location.X-4, SampleText.Location.Y-2);
            SampleText.Parent = SamplePicture;
            SampleText.BringToFront();
            SampleSockets.Parent = SamplePicture;
            SampleSockets.BringToFront();

            StaticLibrary.ReloadSoundOptions(ChangeSoundDropdown);

            // Loading filter sound files start
            if (!Directory.Exists(FilterSoundsFolder))
            {
                Directory.CreateDirectory(FilterSoundsFolder);
            }
            DirectoryInfo dir = new DirectoryInfo(FilterSoundsFolder);
            var extensions = new[] { "*.mp3", "*.wav" };
            IEnumerable<FileInfo> Files = extensions.SelectMany(ext => dir.GetFiles(ext));
            SoundList = new List<string>();
            foreach (FileInfo file in Files)
            {
                SoundList.Add(file.Name);
                ChangeSoundDropdown.Items.Add(new ComboBoxItem(file.Name, FilterSoundsFolder+file.Name));
            }
            // Loading filter sound files end
            
            StaticLibrary.StartLoadingTimer(1000, AfterLoaded);
        }

        private void AfterLoaded(object sender, EventArgs e)
        {
            PopulateStyleList();
        }

        private void RefreshSample()
        {
            if (FontSizeTextBox.InvokeRequired)
            {
                ReturningVoidDelegate d = new ReturningVoidDelegate(RefreshSample);
                this.Invoke(d, new object[] { });
            }
            else
            {
                ReloadSampleSize((int)FontSizeTextBox.Value);
                ReloadSampleAlpha();
            }
        }

        private void PopulateStyleList()
        {
            if (StyleList.InvokeRequired)
            {
                ReturningVoidDelegate d = new ReturningVoidDelegate(PopulateStyleList);
                this.Invoke(d, new object[] {});
            }
            else
            {
                StyleList.Items.Clear();
                if (Styles.Count<XElement>() > 0)
                {
                    foreach (XElement Style in Styles)
                    {
                        StyleList.Items.Add(new ComboBoxItem(Style.Attribute("Name").Value, Style.Attribute("Name").Value));
                    }
                }
            }
        }

        private void LoadData()
        {
            if (!File.Exists(configFilepath))
            {
                StaticLibrary.CreateData(configFilepath);
            }

            GlobalConfig = XElement.Load($"{configFilepath}");
            
            Styles = from style in GlobalConfig.Descendants("Style") select style;
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
            
            SampleRect.Refresh();
            //SampleRect.BringToFront();
            SampleText.Refresh();
            //SampleText.BringToFront();
            SampleSockets.Refresh();
            //SampleSockets.BringToFront();
            /*
            SampleText.Parent = SampleContent;
            SampleText.Parent = SamplePicture;
            SampleSockets.Refresh();
            SampleSockets.Parent = SamplePicture;
            SampleSockets.BringToFront();
            */
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
            SampleRect.Width = (int)(7.96986 * SampleText.Font.Size * 1.1f) + 20;
            // Text width
            SampleText.Width = SampleRect.Width - 4 - 20;
            
            // Rect position
            SampleRect.Location = new Point((SampleContent.Width - SampleRect.Width) / 2, (SampleContent.Height - SampleRect.Height) / 2);
            // Text position
            SampleText.Location = new Point(SampleRect.Location.X + 4, SampleRect.Location.Y + 2 + ((SampleRect.Height - 4) - SampleText.Height)/2);
            // Sockets position
            SampleSockets.Location = new Point(SampleRect.Location.X + (SampleRect.Width - 20), SampleRect.Location.Y + (SampleRect.Height-16) / 2);
            SampleSockets.Visible = true;
        }

        // ############### Interface Events START ###############
        private void StyleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((ListBox)sender).SelectedItem != null)
            {
                XElement SelectedStyle = (from Styles in GlobalConfig.Descendants("Style") where Styles.Attribute("Name").Value == ((ListBox)sender).SelectedItem.ToString() select Styles).First().Element("Params");

                SelectedStyleEditor.Visible = true;

                FontSizeTextBox.Text = SelectedStyle.Attribute("FontSize").Value;
                FontColorTextBox.Text = SelectedStyle.Attribute("FontColor").Value;
                TrackBarFontAlpha.Value = 0;
                TrackBarFontAlpha.Value = 255;
                TrackBarFontAlpha.Value = Int32.Parse(SelectedStyle.Attribute("FontAlpha").Value);
                BorderColorTextBox.Text = SelectedStyle.Attribute("BorderColor").Value;
                TrackBarBorderAlpha.Value = 0;
                TrackBarBorderAlpha.Value = 255;
                TrackBarBorderAlpha.Value = Int32.Parse(SelectedStyle.Attribute("BorderAlpha").Value);
                BackgroundColorTextBox.Text = SelectedStyle.Attribute("BackgroundColor").Value;
                TrackBarBackgroundAlpha.Value = 0;
                TrackBarBackgroundAlpha.Value = 255;
                TrackBarBackgroundAlpha.Value = Int32.Parse(SelectedStyle.Attribute("BackgroundAlpha").Value);
                UpdateMapIcon(Int32.Parse(SelectedStyle.Attribute("MinimapIconSize").Value) != 0, Int32.Parse(SelectedStyle.Attribute("MinimapIconSize").Value), SelectedStyle.Attribute("MinimapIconColor").Value, SelectedStyle.Attribute("MinimapIconShape").Value);
                UpdateBeamIcon(bool.Parse(SelectedStyle.Attribute("LightBeamVisible").Value), SelectedStyle.Attribute("LightBeamColor").Value);
                SetSoundWithoutPlaying(SelectedStyle.Attribute("AlertSound").Value, Int32.Parse(SelectedStyle.Attribute("AlertSoundVolume").Value));

                SaveStyleButton.Enabled = true;
                RevertStyleButton.Enabled = true;
                CopyStyleButton.Enabled = true;
                DeleteStyleButton.Enabled = true;
            }
        }

        private void SetSoundWithoutPlaying(string sound, int volume)
        {
            PlaySounds = false;
            Volume = volume;
            var soundIndex = -1;
            foreach (ComboBoxItem item in ChangeSoundDropdown.Items)
            {
                if( item.Value.ToString() == sound)
                {
                    soundIndex = ChangeSoundDropdown.Items.IndexOf(item);
                }
            }
            if( soundIndex != -1 )
            {
                ChangeSoundDropdown.SelectedIndex = soundIndex;
            }
            else
            {
                ChangeSoundDropdown.SelectedIndex = 0;
            }
            PlaySounds = true;
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
            
            RefreshSample();
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

            RefreshSample();
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

            RefreshSample();
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
            
            RefreshSample();
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
            }
        }

        private void BorderColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string newValue = Regex.Replace(((TextBox)sender).Text, @"[^0-9A-Fa-f]", "");
            if (newValue.Length == 3 || newValue.Length == 6)
            {
                BorderColorTextBox.Text = newValue;
                SampleRect.BorderColor = ColorTranslator.FromHtml(string.Concat("#", newValue));
            }
        }

        private void BackgroundColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string newValue = Regex.Replace(((TextBox)sender).Text, @"[^0-9A-Fa-f]", "");
            if (newValue.Length == 3 || newValue.Length == 6)
            {
                BackgroundColorTextBox.Text = newValue;
                SampleText.BackColor = SampleRect.BackColor = ColorTranslator.FromHtml(string.Concat("#", newValue));
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

        private void ChangeIconButton_Click(object sender, EventArgs e)
        {
            mip = new MapIconPanel(this);
            mip.Location = new Point();
            mip.Size = StylesContent.Size;
            mip.Init(MapIconSize, MapIconColor, MapIconShape);

            StylesContent.Controls.Add(mip);
            mip.BringToFront();
            Panel actionPanel = (Panel)mip.Controls.Find("ActionPanel", true)[0];
            actionPanel.Visible = true;
        }

        private void ChangeBeamButton_Click(object sender, EventArgs e)
        {
            bp = new BeamPanel(this);
            bp.Location = new Point();
            bp.Size = StylesContent.Size;
            bp.Init(BeamColor);

            StylesContent.Controls.Add(bp);
            bp.BringToFront();
            Panel actionPanel = (Panel)bp.Controls.Find("ActionPanel", true)[0];
            actionPanel.Visible = true;
        }

        public void RemoveMapIconPanel()
        {
            StylesContent.Controls.Remove(mip);
        }

        public void RemoveBeamPanel()
        {
            StylesContent.Controls.Remove(bp);
        }

        public void RemoveSaveStylePanel()
        {
            StylesContent.Controls.Remove(ssp);
        }

        private void ChangeSoundDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedValue = ((ComboBoxItem)((ComboBox)sender).SelectedItem).Value.ToString();

            if (PlaySounds)
            {
                PlaySound(SelectedValue);
            }
        }

        private void PlaySound(string sound)
        {
            var SoundPath = "";

            switch (sound)
            {
                case "0":
                    return;
                case "1":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound1.mp3");
                    break;
                case "2":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound2.mp3");
                    break;
                case "3":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound3.mp3");
                    break;
                case "4":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound4.mp3");
                    break;
                case "5":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound5.mp3");
                    break;
                case "6":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound6.mp3");
                    break;
                case "7":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound7.mp3");
                    break;
                case "8":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound8.mp3");
                    break;
                case "9":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound9.mp3");
                    break;
                case "10":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound10.mp3");
                    break;
                case "11":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound11.mp3");
                    break;
                case "12":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound12.mp3");
                    break;
                case "13":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound13.mp3");
                    break;
                case "14":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound14.mp3");
                    break;
                case "15":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound15.mp3");
                    break;
                case "16":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSound16.mp3");
                    break;
                case "shAlchemy":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSoundShAlchemy.mp3");
                    break;
                case "shBlessed":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSoundShBlessed.mp3");
                    break;
                case "shChaos":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSoundShChaos.mp3");
                    break;
                case "shFusing":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSoundShFusing.mp3");
                    break;
                case "shGeneral":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSoundShGeneral.mp3");
                    break;
                case "shRegal":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSoundShRegal.mp3");
                    break;
                case "shVaal":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSoundShVaal.mp3");
                    break;
                case "shDivine":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSoundShDivine.mp3");
                    break;
                case "shExalted":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSoundShExalted.mp3");
                    break;
                case "shMirror":
                    SoundPath = Path.Combine(TempPath, @"Sounds\AlertSoundShMirror.mp3");
                    break;
                default:
                    SoundPath = sound;
                    break;
            }
            
            if (File.Exists(SoundPath))
            {
                if (SoundPath.EndsWith(".wav"))
                {
                    if(wavplayer == null) wavplayer = new System.Media.SoundPlayer();
                    wavplayer.Stop();
                    wavplayer.SoundLocation = SoundPath;
                    wavplayer.Play();
                }

                if (SoundPath.EndsWith(".mp3"))
                {
                    if(mp3player == null) mp3player = new WMPLib.WindowsMediaPlayer();
                    mp3player.controls.stop();
                    mp3player.URL = SoundPath;
                    mp3player.settings.volume = Volume / 12;
                    mp3player.controls.play();
                }
            }
        }

        private void ChangeVolume_Click(object sender, EventArgs e)
        {
            switch (Volume)
            {
                case 0:
                    SetVolume(40);
                    break;
                case 40:
                    SetVolume(100);
                    break;
                case 100:
                    SetVolume(200);
                    break;
                case 200:
                    SetVolume(300);
                    break;
                case 300:
                    SetVolume(0);
                    break;
            }

            PlaySound( ((ComboBoxItem)(ChangeSoundDropdown.SelectedItem)).Value.ToString() );
        }

        private void SetVolume(int volume)
        {
            Volume = volume;
            switch (Volume)
            {
                case 0:
                    ChangeVolume.Image = Properties.Resources.VolumeMute;
                    break;
                case 40:
                    ChangeVolume.Image = Properties.Resources.VolumeVeryLow;
                    break;
                case 100:
                    ChangeVolume.Image = Properties.Resources.VolumeLow;
                    break;
                case 200:
                    ChangeVolume.Image = Properties.Resources.VolumeMid;
                    break;
                case 300:
                    ChangeVolume.Image = Properties.Resources.VolumeHigh;
                    break;
            }
        }

        public void UpdateMapIcon(bool visible, int size, string color, string shape)
        {
            ShowMapIcon = visible;
            MapIconSize = size;
            MapIconColor = color;
            MapIconShape = shape;
            if (ShowMapIcon)
            {
                ChangeIconButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("Icon" + (MapIconShape.First().ToString().ToUpper() + MapIconShape.Substring(1)) + (MapIconColor.First().ToString().ToUpper() + MapIconColor.Substring(1)));
            }
            else
            {
                ChangeIconButton.Image = (Image)Properties.Resources.NoIcon;
            }
        }

        public void UpdateBeamIcon(bool visible, string color, bool temporary = false)
        {
            ShowBeam = visible;
            BeamColor = color;
            BeamTemporary = temporary;
            if (ShowBeam)
            {
                ChangeBeamButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("IconBeam" + (BeamColor.First().ToString().ToUpper() + BeamColor.Substring(1)));
            }
            else
            {
                ChangeBeamButton.Image = (Image)Properties.Resources.NoIcon;
            }
        }

        private void SaveStyleButton_Click(object sender, EventArgs e)
        {
            SaveStyle(StyleList.SelectedItem.ToString());
        }

        private void NewStyleButton_Click(object sender, EventArgs e)
        {
            ssp = new SaveStylePanel(this);
            ssp.Location = new Point();
            ssp.Size = StylesContent.Size;
            ssp.Init();

            StylesContent.Controls.Add(ssp);
            ssp.BringToFront();
            Panel actionPanel = (Panel)ssp.Controls.Find("ActionPanel", true)[0];
            actionPanel.Visible = true;
        }

        private void StylesContent_VisibleChanged(object sender, System.EventArgs e)
        {
            SelectedStyleEditor.Visible = false;

            SaveStyleButton.Enabled = false;
            RevertStyleButton.Enabled = false;
            CopyStyleButton.Enabled = false;
            DeleteStyleButton.Enabled = false;

            StyleList.ClearSelected();
        }

        public bool ValidNewStyleName(string styleName)
        {
            if( styleName != "")
            {
                foreach (XElement Style in Styles)
                {
                    if(Style.Attribute("Name").Value == styleName)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private void RevertStyleButton_Click(object sender, EventArgs e)
        {
            var index = StyleList.SelectedIndex;
            StyleList.SelectedItem = null;
            StyleList.SelectedItem = StyleList.Items[index];
        }

        private void CopyStyleButton_Click(object sender, EventArgs e)
        {
            CopiedStyle = GlobalConfig.Descendants("Style").FirstOrDefault(m => m.Attribute("Name").Value == StyleList.SelectedItem.ToString()).Element("Params");
            PasteStyleButton.Enabled = true;
        }

        private void PasteStyleButton_Click(object sender, EventArgs e)
        {
            if( CopiedStyle != null)
            {
                FontSizeTextBox.Text = CopiedStyle.Attribute("FontSize").Value;
                FontColorTextBox.Text = CopiedStyle.Attribute("FontColor").Value;
                TrackBarFontAlpha.Value = 0;
                TrackBarFontAlpha.Value = 255;
                TrackBarFontAlpha.Value = Int32.Parse(CopiedStyle.Attribute("FontAlpha").Value);
                BorderColorTextBox.Text = CopiedStyle.Attribute("BorderColor").Value;
                TrackBarBorderAlpha.Value = 0;
                TrackBarBorderAlpha.Value = 255;
                TrackBarBorderAlpha.Value = Int32.Parse(CopiedStyle.Attribute("BorderAlpha").Value);
                BackgroundColorTextBox.Text = CopiedStyle.Attribute("BackgroundColor").Value;
                TrackBarBackgroundAlpha.Value = 0;
                TrackBarBackgroundAlpha.Value = 255;
                TrackBarBackgroundAlpha.Value = Int32.Parse(CopiedStyle.Attribute("BackgroundAlpha").Value);
                UpdateMapIcon(Int32.Parse(CopiedStyle.Attribute("MinimapIconSize").Value) != 0, Int32.Parse(CopiedStyle.Attribute("MinimapIconSize").Value), CopiedStyle.Attribute("MinimapIconColor").Value, CopiedStyle.Attribute("MinimapIconShape").Value);
                UpdateBeamIcon(bool.Parse(CopiedStyle.Attribute("LightBeamVisible").Value), CopiedStyle.Attribute("LightBeamColor").Value);
            }
        }

        private void DeleteStyleButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.Descendants("Style").FirstOrDefault(m => m.Attribute("Name").Value == StyleList.SelectedItem.ToString()).Remove();
            GlobalConfig.Save(configFilepath);

            SelectedStyleEditor.Visible = false;

            SaveStyleButton.Enabled = false;
            RevertStyleButton.Enabled = false;
            CopyStyleButton.Enabled = false;
            DeleteStyleButton.Enabled = false;

            Styles = from style in GlobalConfig.Descendants("Style") select style;
            PopulateStyleList();
        }

        public void SaveStyleAsNew(string styleName)
        {
            XElement StylesContainer = (from stylesContainer in GlobalConfig.Descendants("Styles") select stylesContainer).First<XElement>();
            StylesContainer.Add(new XElement("Style",
                new XAttribute("Name", styleName),
                new XElement("Params",
                    new XAttribute("FontSize", 36),
                    new XAttribute("FontColor", "#4682B4"),
                    new XAttribute("FontAlpha", 255),
                    new XAttribute("BackgroundColor", "#FFFFFF"),
                    new XAttribute("BackgroundAlpha", 200),
                    new XAttribute("BorderColor", "#4682B4"),
                    new XAttribute("BorderAlpha", 255),
                    new XAttribute("MinimapIconSize", 1),
                    new XAttribute("MinimapIconColor", "Blue"),
                    new XAttribute("MinimapIconShape", "Sphere"),
                    new XAttribute("LightBeamVisible", false),
                    new XAttribute("LightBeamColor", "Blue"),
                    new XAttribute("LightBeamTemp", false),
                    new XAttribute("AlertSound", "None"),
                    new XAttribute("AlertSoundVolume", 300),
                    new XAttribute("DropSound", false)
                )
            ));
            GlobalConfig.Save(configFilepath);

            Styles = from style in GlobalConfig.Descendants("Style") select style;
            PopulateStyleList();
        }

        public void SaveStyle(string styleName)
        {
            XElement Style = GlobalConfig.Descendants("Style").FirstOrDefault(m => m.Attribute("Name").Value == styleName);
            XElement StyleParams = Style.Element("Params");
            StyleParams.Attribute("FontSize").Value = FontSizeTextBox.Value.ToString();
            StyleParams.Attribute("FontColor").Value = "#" + FontColorTextBox.Text;
            StyleParams.Attribute("FontAlpha").Value = FontAlphaTextBox.Value.ToString();
            StyleParams.Attribute("BackgroundColor").Value = "#" + BackgroundColorTextBox.Text;
            StyleParams.Attribute("BackgroundAlpha").Value = BackgroundAlphaTextBox.Value.ToString();
            StyleParams.Attribute("BorderColor").Value = "#" + BorderColorTextBox.Text;
            StyleParams.Attribute("BorderAlpha").Value = BorderAlphaTextBox.Value.ToString();
            StyleParams.Attribute("MinimapIconSize").Value = MapIconSize.ToString();
            StyleParams.Attribute("MinimapIconColor").Value = MapIconColor.Substring(0, 1).ToUpper() + MapIconColor.Substring(1);
            StyleParams.Attribute("MinimapIconShape").Value = MapIconShape.Substring(0, 1).ToUpper() + MapIconShape.Substring(1);
            StyleParams.Attribute("LightBeamVisible").Value = ShowBeam.ToString();
            StyleParams.Attribute("LightBeamColor").Value = BeamColor.Substring(0, 1).ToUpper() + BeamColor.Substring(1);
            StyleParams.Attribute("LightBeamTemp").Value = false.ToString();
            StyleParams.Attribute("AlertSound").Value = ((ComboBoxItem)ChangeSoundDropdown.SelectedItem).Value.ToString();
            StyleParams.Attribute("AlertSoundVolume").Value = Volume.ToString();
            StyleParams.Attribute("DropSound").Value = false.ToString();
            GlobalConfig.Save(configFilepath);
        }
        // ############### Interface Events END   ###############
    }
}

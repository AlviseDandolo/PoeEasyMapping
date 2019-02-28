using System.Diagnostics;
using System.Drawing;

namespace PoE_Easy_Mapping
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainWindowTitleBar = new System.Windows.Forms.Panel();
            this.BackgroundPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.MainWindowTitle = new System.Windows.Forms.Label();
            this.TrayBarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TrayMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainWindowContainer = new System.Windows.Forms.Panel();
            this.TabsContainer = new System.Windows.Forms.Panel();
            this.SettingsTab = new PoE_Easy_Mapping.FlatTab();
            this.StylesTab = new PoE_Easy_Mapping.FlatTab();
            this.TabsRectangle = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.TabsRectangleShape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.TabContentContainer = new System.Windows.Forms.Panel();
            this.StylesContent = new System.Windows.Forms.Panel();
            this.SelectedStyleEditor = new System.Windows.Forms.Panel();
            this.SampleContent = new System.Windows.Forms.Panel();
            this.SampleSockets = new System.Windows.Forms.PictureBox();
            this.SampleText = new PoE_Easy_Mapping.AlphaLabel();
            this.SampleRectContainer = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SampleRect = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SamplePicture = new System.Windows.Forms.PictureBox();
            this.BackgroundGroup = new System.Windows.Forms.GroupBox();
            this.SetBackgroundColor8 = new PoE_Easy_Mapping.FlatButton();
            this.BackgroundColorLabel = new System.Windows.Forms.Label();
            this.BackgroundColor = new System.Windows.Forms.Panel();
            this.BackgroundColorHashtag = new PoE_Easy_Mapping.AlphaLabel();
            this.BackgroundColorTextBox = new System.Windows.Forms.TextBox();
            this.SetBackgroundColor1 = new PoE_Easy_Mapping.FlatButton();
            this.SetBackgroundColor2 = new PoE_Easy_Mapping.FlatButton();
            this.SetBackgroundColor3 = new PoE_Easy_Mapping.FlatButton();
            this.SetBackgroundColor4 = new PoE_Easy_Mapping.FlatButton();
            this.SetBackgroundColor5 = new PoE_Easy_Mapping.FlatButton();
            this.SetBackgroundColor6 = new PoE_Easy_Mapping.FlatButton();
            this.SetBackgroundColor7 = new PoE_Easy_Mapping.FlatButton();
            this.BackgroundColorPicker = new PoE_Easy_Mapping.FlatButton();
            this.BackgroundAlphaLabel = new System.Windows.Forms.Label();
            this.BackgroundAlphaTextBox = new System.Windows.Forms.NumericUpDown();
            this.TrackBarBackgroundAlpha = new PoE_Easy_Mapping.Slider();
            this.BorderGroup = new System.Windows.Forms.GroupBox();
            this.SetBorderColor8 = new PoE_Easy_Mapping.FlatButton();
            this.BorderColorLabel = new System.Windows.Forms.Label();
            this.BorderColor = new System.Windows.Forms.Panel();
            this.BorderColorHashtag = new PoE_Easy_Mapping.AlphaLabel();
            this.BorderColorTextBox = new System.Windows.Forms.TextBox();
            this.SetBorderColor1 = new PoE_Easy_Mapping.FlatButton();
            this.SetBorderColor2 = new PoE_Easy_Mapping.FlatButton();
            this.SetBorderColor3 = new PoE_Easy_Mapping.FlatButton();
            this.SetBorderColor4 = new PoE_Easy_Mapping.FlatButton();
            this.SetBorderColor5 = new PoE_Easy_Mapping.FlatButton();
            this.SetBorderColor6 = new PoE_Easy_Mapping.FlatButton();
            this.SetBorderColor7 = new PoE_Easy_Mapping.FlatButton();
            this.BorderColorPicker = new PoE_Easy_Mapping.FlatButton();
            this.BorderAlphaLabel = new System.Windows.Forms.Label();
            this.BorderAlphaTextBox = new System.Windows.Forms.NumericUpDown();
            this.TrackBarBorderAlpha = new PoE_Easy_Mapping.Slider();
            this.TextGroup = new System.Windows.Forms.GroupBox();
            this.SetTextColor8 = new PoE_Easy_Mapping.FlatButton();
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.FontSizeTextBox = new System.Windows.Forms.NumericUpDown();
            this.TrackBarFontSize = new PoE_Easy_Mapping.Slider();
            this.FontColorLabel = new System.Windows.Forms.Label();
            this.FontColor = new System.Windows.Forms.Panel();
            this.FontColorHashtag = new PoE_Easy_Mapping.AlphaLabel();
            this.FontColorTextBox = new System.Windows.Forms.TextBox();
            this.SetTextColor1 = new PoE_Easy_Mapping.FlatButton();
            this.SetTextColor2 = new PoE_Easy_Mapping.FlatButton();
            this.SetTextColor3 = new PoE_Easy_Mapping.FlatButton();
            this.SetTextColor4 = new PoE_Easy_Mapping.FlatButton();
            this.SetTextColor5 = new PoE_Easy_Mapping.FlatButton();
            this.SetTextColor6 = new PoE_Easy_Mapping.FlatButton();
            this.SetTextColor7 = new PoE_Easy_Mapping.FlatButton();
            this.TextColorPicker = new PoE_Easy_Mapping.FlatButton();
            this.FontAlphaLabel = new System.Windows.Forms.Label();
            this.FontAlphaTextBox = new System.Windows.Forms.NumericUpDown();
            this.TrackBarFontAlpha = new PoE_Easy_Mapping.Slider();
            this.OtherGroup = new System.Windows.Forms.GroupBox();
            this.ChangeVolume = new System.Windows.Forms.PictureBox();
            this.ChangeSoundDropdown = new System.Windows.Forms.ComboBox();
            this.ChangeBeamButton = new System.Windows.Forms.PictureBox();
            this.ChangeIconButton = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StyleListGroup = new System.Windows.Forms.GroupBox();
            this.DeleteStyleButton = new PoE_Easy_Mapping.FlatButton();
            this.NewStyleButton = new PoE_Easy_Mapping.FlatButton();
            this.PasteStyleButton = new PoE_Easy_Mapping.FlatButton();
            this.CopyStyleButton = new PoE_Easy_Mapping.FlatButton();
            this.RevertStyleButton = new PoE_Easy_Mapping.FlatButton();
            this.StyleList = new System.Windows.Forms.ListBox();
            this.SaveStyleButton = new PoE_Easy_Mapping.FlatButton();
            this.SettingsContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ReduceButton = new PoE_Easy_Mapping.FlatButton();
            this.CloseButton = new PoE_Easy_Mapping.FlatButton();
            this.MainWindowTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPlayer)).BeginInit();
            this.TrayMenuStrip.SuspendLayout();
            this.MainWindowContainer.SuspendLayout();
            this.TabsContainer.SuspendLayout();
            this.TabContentContainer.SuspendLayout();
            this.StylesContent.SuspendLayout();
            this.SelectedStyleEditor.SuspendLayout();
            this.SampleContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleSockets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePicture)).BeginInit();
            this.BackgroundGroup.SuspendLayout();
            this.BackgroundColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundAlphaTextBox)).BeginInit();
            this.BorderGroup.SuspendLayout();
            this.BorderColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorderAlphaTextBox)).BeginInit();
            this.TextGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeTextBox)).BeginInit();
            this.FontColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontAlphaTextBox)).BeginInit();
            this.OtherGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeBeamButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeIconButton)).BeginInit();
            this.StyleListGroup.SuspendLayout();
            this.SettingsContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindowTitleBar
            // 
            this.MainWindowTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.MainWindowTitleBar.Controls.Add(this.BackgroundPlayer);
            this.MainWindowTitleBar.Controls.Add(this.MainWindowTitle);
            this.MainWindowTitleBar.Location = new System.Drawing.Point(0, 0);
            this.MainWindowTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.MainWindowTitleBar.Name = "MainWindowTitleBar";
            this.MainWindowTitleBar.Size = new System.Drawing.Size(800, 200);
            this.MainWindowTitleBar.TabIndex = 3;
            // 
            // BackgroundPlayer
            // 
            this.BackgroundPlayer.Enabled = true;
            this.BackgroundPlayer.Location = new System.Drawing.Point(700, 30);
            this.BackgroundPlayer.Name = "BackgroundPlayer";
            this.BackgroundPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BackgroundPlayer.OcxState")));
            this.BackgroundPlayer.Size = new System.Drawing.Size(100, 23);
            this.BackgroundPlayer.TabIndex = 2;
            this.BackgroundPlayer.TabStop = false;
            this.BackgroundPlayer.Visible = false;
            // 
            // MainWindowTitle
            // 
            this.MainWindowTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MainWindowTitle.BackColor = System.Drawing.Color.Transparent;
            this.MainWindowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.MainWindowTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.MainWindowTitle.Location = new System.Drawing.Point(0, 0);
            this.MainWindowTitle.Margin = new System.Windows.Forms.Padding(0);
            this.MainWindowTitle.Name = "MainWindowTitle";
            this.MainWindowTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.MainWindowTitle.Size = new System.Drawing.Size(800, 60);
            this.MainWindowTitle.TabIndex = 1;
            this.MainWindowTitle.Text = "PoE Easy Mapping";
            this.MainWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainWindowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindowTitle_MouseDown);
            // 
            // TrayBarIcon
            // 
            this.TrayBarIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TrayBarIcon.BalloonTipText = "asd";
            this.TrayBarIcon.BalloonTipTitle = "rofl";
            this.TrayBarIcon.ContextMenuStrip = this.TrayMenuStrip;
            this.TrayBarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayBarIcon.Icon")));
            this.TrayBarIcon.Text = "PoE Easy Mapping";
            this.TrayBarIcon.Visible = true;
            this.TrayBarIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayBarIcon_MouseDoubleClick);
            // 
            // TrayMenuStrip
            // 
            this.TrayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayMenuItem_Exit});
            this.TrayMenuStrip.Name = "contextMenuStrip1";
            this.TrayMenuStrip.Size = new System.Drawing.Size(93, 26);
            // 
            // TrayMenuItem_Exit
            // 
            this.TrayMenuItem_Exit.Name = "TrayMenuItem_Exit";
            this.TrayMenuItem_Exit.Size = new System.Drawing.Size(92, 22);
            this.TrayMenuItem_Exit.Text = "Exit";
            this.TrayMenuItem_Exit.Click += new System.EventHandler(this.TrayMenuItem_Exit_Click);
            // 
            // MainWindowContainer
            // 
            this.MainWindowContainer.BackColor = System.Drawing.Color.DodgerBlue;
            this.MainWindowContainer.Controls.Add(this.TabsContainer);
            this.MainWindowContainer.Controls.Add(this.TabContentContainer);
            this.MainWindowContainer.Location = new System.Drawing.Point(12, 63);
            this.MainWindowContainer.Name = "MainWindowContainer";
            this.MainWindowContainer.Size = new System.Drawing.Size(776, 525);
            this.MainWindowContainer.TabIndex = 7;
            // 
            // TabsContainer
            // 
            this.TabsContainer.Controls.Add(this.SettingsTab);
            this.TabsContainer.Controls.Add(this.StylesTab);
            this.TabsContainer.Controls.Add(this.TabsRectangle);
            this.TabsContainer.Location = new System.Drawing.Point(0, 0);
            this.TabsContainer.Name = "TabsContainer";
            this.TabsContainer.Size = new System.Drawing.Size(776, 35);
            this.TabsContainer.TabIndex = 2;
            // 
            // SettingsTab
            // 
            this.SettingsTab.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.SettingsTab.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.SettingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.SettingsTab.DisabledBackColor = System.Drawing.Color.Gray;
            this.SettingsTab.DisabledBorderColor = System.Drawing.Color.Gray;
            this.SettingsTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.SettingsTab.FlatAppearance.BorderSize = 0;
            this.SettingsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SettingsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.SettingsTab.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.SettingsTab.InactiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.SettingsTab.Location = new System.Drawing.Point(10, 0);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.OnClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.SettingsTab.OnClickBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.SettingsTab.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.SettingsTab.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.SettingsTab.Size = new System.Drawing.Size(120, 35);
            this.SettingsTab.TabIndex = 0;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = false;
            this.SettingsTab.Click += new System.EventHandler(this.SettingsTab_Click);
            // 
            // StylesTab
            // 
            this.StylesTab.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.StylesTab.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.StylesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.StylesTab.DisabledBackColor = System.Drawing.Color.Gray;
            this.StylesTab.DisabledBorderColor = System.Drawing.Color.Gray;
            this.StylesTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.StylesTab.FlatAppearance.BorderSize = 0;
            this.StylesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.StylesTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StylesTab.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.StylesTab.InactiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.StylesTab.Location = new System.Drawing.Point(135, 0);
            this.StylesTab.Name = "StylesTab";
            this.StylesTab.OnClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.StylesTab.OnClickBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.StylesTab.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.StylesTab.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.StylesTab.Size = new System.Drawing.Size(120, 35);
            this.StylesTab.TabIndex = 2;
            this.StylesTab.Text = "Styles";
            this.StylesTab.UseVisualStyleBackColor = false;
            this.StylesTab.Click += new System.EventHandler(this.StylesTab_Click);
            // 
            // TabsRectangle
            // 
            this.TabsRectangle.Location = new System.Drawing.Point(0, 0);
            this.TabsRectangle.Margin = new System.Windows.Forms.Padding(0);
            this.TabsRectangle.Name = "TabsRectangle";
            this.TabsRectangle.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.TabsRectangleShape});
            this.TabsRectangle.Size = new System.Drawing.Size(776, 35);
            this.TabsRectangle.TabIndex = 1;
            this.TabsRectangle.TabStop = false;
            // 
            // TabsRectangleShape
            // 
            this.TabsRectangleShape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.TabsRectangleShape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TabsRectangleShape.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.TabsRectangleShape.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.TabsRectangleShape.Location = new System.Drawing.Point(0, 15);
            this.TabsRectangleShape.Name = "TabsRectangleShape";
            this.TabsRectangleShape.Size = new System.Drawing.Size(776, 20);
            // 
            // TabContentContainer
            // 
            this.TabContentContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.TabContentContainer.Controls.Add(this.StylesContent);
            this.TabContentContainer.Controls.Add(this.SettingsContent);
            this.TabContentContainer.Location = new System.Drawing.Point(0, 35);
            this.TabContentContainer.Name = "TabContentContainer";
            this.TabContentContainer.Size = new System.Drawing.Size(776, 490);
            this.TabContentContainer.TabIndex = 1;
            // 
            // StylesContent
            // 
            this.StylesContent.BackColor = System.Drawing.Color.Transparent;
            this.StylesContent.Controls.Add(this.SelectedStyleEditor);
            this.StylesContent.Controls.Add(this.StyleListGroup);
            this.StylesContent.Location = new System.Drawing.Point(0, 0);
            this.StylesContent.Margin = new System.Windows.Forms.Padding(0);
            this.StylesContent.Name = "StylesContent";
            this.StylesContent.Size = new System.Drawing.Size(776, 490);
            this.StylesContent.TabIndex = 0;
            this.StylesContent.Visible = false;
            this.StylesContent.VisibleChanged += new System.EventHandler(this.StylesContent_VisibleChanged);
            // 
            // SelectedStyleEditor
            // 
            this.SelectedStyleEditor.Controls.Add(this.SampleContent);
            this.SelectedStyleEditor.Controls.Add(this.BackgroundGroup);
            this.SelectedStyleEditor.Controls.Add(this.BorderGroup);
            this.SelectedStyleEditor.Controls.Add(this.TextGroup);
            this.SelectedStyleEditor.Controls.Add(this.OtherGroup);
            this.SelectedStyleEditor.Location = new System.Drawing.Point(345, 0);
            this.SelectedStyleEditor.Name = "SelectedStyleEditor";
            this.SelectedStyleEditor.Size = new System.Drawing.Size(431, 490);
            this.SelectedStyleEditor.TabIndex = 30;
            this.SelectedStyleEditor.Visible = false;
            // 
            // SampleContent
            // 
            this.SampleContent.Controls.Add(this.SampleSockets);
            this.SampleContent.Controls.Add(this.SampleText);
            this.SampleContent.Controls.Add(this.SampleRectContainer);
            this.SampleContent.Controls.Add(this.SamplePicture);
            this.SampleContent.Location = new System.Drawing.Point(0, 12);
            this.SampleContent.Name = "SampleContent";
            this.SampleContent.Size = new System.Drawing.Size(422, 87);
            this.SampleContent.TabIndex = 3;
            // 
            // SampleSockets
            // 
            this.SampleSockets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SampleSockets.Image = global::PoE_Easy_Mapping.Properties.Resources.SocketSample;
            this.SampleSockets.InitialImage = global::PoE_Easy_Mapping.Properties.Resources.SocketSample;
            this.SampleSockets.Location = new System.Drawing.Point(325, 67);
            this.SampleSockets.Name = "SampleSockets";
            this.SampleSockets.Size = new System.Drawing.Size(16, 16);
            this.SampleSockets.TabIndex = 5;
            this.SampleSockets.TabStop = false;
            this.SampleSockets.Visible = false;
            // 
            // SampleText
            // 
            this.SampleText.BackColor = System.Drawing.Color.SteelBlue;
            this.SampleText.Font = new System.Drawing.Font("Fontin SmallCaps", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SampleText.ForeColor = System.Drawing.Color.White;
            this.SampleText.Location = new System.Drawing.Point(56, 23);
            this.SampleText.Margin = new System.Windows.Forms.Padding(0);
            this.SampleText.Name = "SampleText";
            this.SampleText.Size = new System.Drawing.Size(333, 41);
            this.SampleText.TabIndex = 4;
            this.SampleText.Text = "Hydrascale Boots";
            this.SampleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SampleRectContainer
            // 
            this.SampleRectContainer.Location = new System.Drawing.Point(0, 0);
            this.SampleRectContainer.Margin = new System.Windows.Forms.Padding(0);
            this.SampleRectContainer.Name = "SampleRectContainer";
            this.SampleRectContainer.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.SampleRect});
            this.SampleRectContainer.Size = new System.Drawing.Size(422, 87);
            this.SampleRectContainer.TabIndex = 2;
            this.SampleRectContainer.TabStop = false;
            // 
            // SampleRect
            // 
            this.SampleRect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SampleRect.BackColor = System.Drawing.Color.SteelBlue;
            this.SampleRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SampleRect.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.SampleRect.BorderColor = System.Drawing.Color.Red;
            this.SampleRect.Enabled = false;
            this.SampleRect.FillColor = System.Drawing.Color.Transparent;
            this.SampleRect.Location = new System.Drawing.Point(52, 21);
            this.SampleRect.Name = "SampleRect";
            this.SampleRect.Size = new System.Drawing.Size(339, 45);
            // 
            // SamplePicture
            // 
            this.SamplePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SamplePicture.Image = global::PoE_Easy_Mapping.Properties.Resources.PoEGround;
            this.SamplePicture.InitialImage = null;
            this.SamplePicture.Location = new System.Drawing.Point(0, 0);
            this.SamplePicture.Name = "SamplePicture";
            this.SamplePicture.Size = new System.Drawing.Size(430, 150);
            this.SamplePicture.TabIndex = 0;
            this.SamplePicture.TabStop = false;
            // 
            // BackgroundGroup
            // 
            this.BackgroundGroup.Controls.Add(this.SetBackgroundColor8);
            this.BackgroundGroup.Controls.Add(this.BackgroundColorLabel);
            this.BackgroundGroup.Controls.Add(this.BackgroundColor);
            this.BackgroundGroup.Controls.Add(this.SetBackgroundColor1);
            this.BackgroundGroup.Controls.Add(this.SetBackgroundColor2);
            this.BackgroundGroup.Controls.Add(this.SetBackgroundColor3);
            this.BackgroundGroup.Controls.Add(this.SetBackgroundColor4);
            this.BackgroundGroup.Controls.Add(this.SetBackgroundColor5);
            this.BackgroundGroup.Controls.Add(this.SetBackgroundColor6);
            this.BackgroundGroup.Controls.Add(this.SetBackgroundColor7);
            this.BackgroundGroup.Controls.Add(this.BackgroundColorPicker);
            this.BackgroundGroup.Controls.Add(this.BackgroundAlphaLabel);
            this.BackgroundGroup.Controls.Add(this.BackgroundAlphaTextBox);
            this.BackgroundGroup.Controls.Add(this.TrackBarBackgroundAlpha);
            this.BackgroundGroup.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BackgroundGroup.Location = new System.Drawing.Point(0, 233);
            this.BackgroundGroup.Name = "BackgroundGroup";
            this.BackgroundGroup.Size = new System.Drawing.Size(422, 91);
            this.BackgroundGroup.TabIndex = 26;
            this.BackgroundGroup.TabStop = false;
            this.BackgroundGroup.Text = "Background";
            // 
            // SetBackgroundColor8
            // 
            this.SetBackgroundColor8.BackColor = System.Drawing.Color.DimGray;
            this.SetBackgroundColor8.CurrentBackColor = System.Drawing.Color.DimGray;
            this.SetBackgroundColor8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBackgroundColor8.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBackgroundColor8.FlatAppearance.BorderSize = 0;
            this.SetBackgroundColor8.ForeColor = System.Drawing.Color.White;
            this.SetBackgroundColor8.Location = new System.Drawing.Point(354, 21);
            this.SetBackgroundColor8.Margin = new System.Windows.Forms.Padding(0);
            this.SetBackgroundColor8.Name = "SetBackgroundColor8";
            this.SetBackgroundColor8.NormalBackColor = System.Drawing.Color.DimGray;
            this.SetBackgroundColor8.OnClickBackColor = System.Drawing.Color.DimGray;
            this.SetBackgroundColor8.OnHoverBackColor = System.Drawing.Color.DimGray;
            this.SetBackgroundColor8.Size = new System.Drawing.Size(25, 25);
            this.SetBackgroundColor8.TabIndex = 25;
            this.SetBackgroundColor8.UseVisualStyleBackColor = false;
            // 
            // BackgroundColorLabel
            // 
            this.BackgroundColorLabel.Font = new System.Drawing.Font("Fontin SmallCaps", 12F);
            this.BackgroundColorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BackgroundColorLabel.Location = new System.Drawing.Point(6, 24);
            this.BackgroundColorLabel.Name = "BackgroundColorLabel";
            this.BackgroundColorLabel.Size = new System.Drawing.Size(60, 20);
            this.BackgroundColorLabel.TabIndex = 10;
            this.BackgroundColorLabel.Text = "Color:";
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.BackColor = System.Drawing.Color.White;
            this.BackgroundColor.Controls.Add(this.BackgroundColorHashtag);
            this.BackgroundColor.Controls.Add(this.BackgroundColorTextBox);
            this.BackgroundColor.Location = new System.Drawing.Point(66, 21);
            this.BackgroundColor.Name = "BackgroundColor";
            this.BackgroundColor.Size = new System.Drawing.Size(70, 25);
            this.BackgroundColor.TabIndex = 13;
            // 
            // BackgroundColorHashtag
            // 
            this.BackgroundColorHashtag.BackColor = System.Drawing.Color.White;
            this.BackgroundColorHashtag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundColorHashtag.Location = new System.Drawing.Point(1, 1);
            this.BackgroundColorHashtag.Margin = new System.Windows.Forms.Padding(0);
            this.BackgroundColorHashtag.Name = "BackgroundColorHashtag";
            this.BackgroundColorHashtag.Size = new System.Drawing.Size(14, 23);
            this.BackgroundColorHashtag.TabIndex = 23;
            this.BackgroundColorHashtag.Text = "#";
            this.BackgroundColorHashtag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BackgroundColorTextBox
            // 
            this.BackgroundColorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BackgroundColorTextBox.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundColorTextBox.Location = new System.Drawing.Point(15, 4);
            this.BackgroundColorTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.BackgroundColorTextBox.MaxLength = 6;
            this.BackgroundColorTextBox.Name = "BackgroundColorTextBox";
            this.BackgroundColorTextBox.Size = new System.Drawing.Size(53, 18);
            this.BackgroundColorTextBox.TabIndex = 13;
            this.BackgroundColorTextBox.Text = "FFFFFF";
            this.BackgroundColorTextBox.TextChanged += new System.EventHandler(this.BackgroundColorTextBox_TextChanged);
            // 
            // SetBackgroundColor1
            // 
            this.SetBackgroundColor1.BackColor = System.Drawing.Color.White;
            this.SetBackgroundColor1.CurrentBackColor = System.Drawing.Color.White;
            this.SetBackgroundColor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBackgroundColor1.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBackgroundColor1.FlatAppearance.BorderSize = 0;
            this.SetBackgroundColor1.ForeColor = System.Drawing.Color.White;
            this.SetBackgroundColor1.Location = new System.Drawing.Point(144, 21);
            this.SetBackgroundColor1.Margin = new System.Windows.Forms.Padding(0);
            this.SetBackgroundColor1.Name = "SetBackgroundColor1";
            this.SetBackgroundColor1.NormalBackColor = System.Drawing.Color.White;
            this.SetBackgroundColor1.OnClickBackColor = System.Drawing.Color.White;
            this.SetBackgroundColor1.OnHoverBackColor = System.Drawing.Color.White;
            this.SetBackgroundColor1.Size = new System.Drawing.Size(25, 25);
            this.SetBackgroundColor1.TabIndex = 15;
            this.SetBackgroundColor1.UseVisualStyleBackColor = false;
            this.SetBackgroundColor1.Click += new System.EventHandler(this.SetBackgroundColor1_Click);
            // 
            // SetBackgroundColor2
            // 
            this.SetBackgroundColor2.BackColor = System.Drawing.Color.Black;
            this.SetBackgroundColor2.CurrentBackColor = System.Drawing.Color.Black;
            this.SetBackgroundColor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBackgroundColor2.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBackgroundColor2.FlatAppearance.BorderSize = 0;
            this.SetBackgroundColor2.ForeColor = System.Drawing.Color.White;
            this.SetBackgroundColor2.Location = new System.Drawing.Point(174, 21);
            this.SetBackgroundColor2.Margin = new System.Windows.Forms.Padding(0);
            this.SetBackgroundColor2.Name = "SetBackgroundColor2";
            this.SetBackgroundColor2.NormalBackColor = System.Drawing.Color.Black;
            this.SetBackgroundColor2.OnClickBackColor = System.Drawing.Color.Black;
            this.SetBackgroundColor2.OnHoverBackColor = System.Drawing.Color.Black;
            this.SetBackgroundColor2.Size = new System.Drawing.Size(25, 25);
            this.SetBackgroundColor2.TabIndex = 19;
            this.SetBackgroundColor2.UseVisualStyleBackColor = false;
            this.SetBackgroundColor2.Click += new System.EventHandler(this.SetBackgroundColor2_Click);
            // 
            // SetBackgroundColor3
            // 
            this.SetBackgroundColor3.BackColor = System.Drawing.Color.DarkRed;
            this.SetBackgroundColor3.CurrentBackColor = System.Drawing.Color.DarkRed;
            this.SetBackgroundColor3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBackgroundColor3.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBackgroundColor3.FlatAppearance.BorderSize = 0;
            this.SetBackgroundColor3.ForeColor = System.Drawing.Color.White;
            this.SetBackgroundColor3.Location = new System.Drawing.Point(204, 21);
            this.SetBackgroundColor3.Margin = new System.Windows.Forms.Padding(0);
            this.SetBackgroundColor3.Name = "SetBackgroundColor3";
            this.SetBackgroundColor3.NormalBackColor = System.Drawing.Color.DarkRed;
            this.SetBackgroundColor3.OnClickBackColor = System.Drawing.Color.DarkRed;
            this.SetBackgroundColor3.OnHoverBackColor = System.Drawing.Color.DarkRed;
            this.SetBackgroundColor3.Size = new System.Drawing.Size(25, 25);
            this.SetBackgroundColor3.TabIndex = 16;
            this.SetBackgroundColor3.UseVisualStyleBackColor = false;
            this.SetBackgroundColor3.Click += new System.EventHandler(this.SetBackgroundColor3_Click);
            // 
            // SetBackgroundColor4
            // 
            this.SetBackgroundColor4.BackColor = System.Drawing.Color.DarkGreen;
            this.SetBackgroundColor4.CurrentBackColor = System.Drawing.Color.DarkGreen;
            this.SetBackgroundColor4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBackgroundColor4.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBackgroundColor4.FlatAppearance.BorderSize = 0;
            this.SetBackgroundColor4.ForeColor = System.Drawing.Color.White;
            this.SetBackgroundColor4.Location = new System.Drawing.Point(234, 21);
            this.SetBackgroundColor4.Margin = new System.Windows.Forms.Padding(0);
            this.SetBackgroundColor4.Name = "SetBackgroundColor4";
            this.SetBackgroundColor4.NormalBackColor = System.Drawing.Color.DarkGreen;
            this.SetBackgroundColor4.OnClickBackColor = System.Drawing.Color.DarkGreen;
            this.SetBackgroundColor4.OnHoverBackColor = System.Drawing.Color.DarkGreen;
            this.SetBackgroundColor4.Size = new System.Drawing.Size(25, 25);
            this.SetBackgroundColor4.TabIndex = 17;
            this.SetBackgroundColor4.UseVisualStyleBackColor = false;
            this.SetBackgroundColor4.Click += new System.EventHandler(this.SetBackgroundColor4_Click);
            // 
            // SetBackgroundColor5
            // 
            this.SetBackgroundColor5.BackColor = System.Drawing.Color.SteelBlue;
            this.SetBackgroundColor5.CurrentBackColor = System.Drawing.Color.SteelBlue;
            this.SetBackgroundColor5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBackgroundColor5.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBackgroundColor5.FlatAppearance.BorderSize = 0;
            this.SetBackgroundColor5.ForeColor = System.Drawing.Color.White;
            this.SetBackgroundColor5.Location = new System.Drawing.Point(264, 21);
            this.SetBackgroundColor5.Margin = new System.Windows.Forms.Padding(0);
            this.SetBackgroundColor5.Name = "SetBackgroundColor5";
            this.SetBackgroundColor5.NormalBackColor = System.Drawing.Color.SteelBlue;
            this.SetBackgroundColor5.OnClickBackColor = System.Drawing.Color.SteelBlue;
            this.SetBackgroundColor5.OnHoverBackColor = System.Drawing.Color.SteelBlue;
            this.SetBackgroundColor5.Size = new System.Drawing.Size(25, 25);
            this.SetBackgroundColor5.TabIndex = 18;
            this.SetBackgroundColor5.UseVisualStyleBackColor = false;
            this.SetBackgroundColor5.Click += new System.EventHandler(this.SetBackgroundColor5_Click);
            // 
            // SetBackgroundColor6
            // 
            this.SetBackgroundColor6.BackColor = System.Drawing.Color.Goldenrod;
            this.SetBackgroundColor6.CurrentBackColor = System.Drawing.Color.Goldenrod;
            this.SetBackgroundColor6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBackgroundColor6.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBackgroundColor6.FlatAppearance.BorderSize = 0;
            this.SetBackgroundColor6.ForeColor = System.Drawing.Color.White;
            this.SetBackgroundColor6.Location = new System.Drawing.Point(294, 21);
            this.SetBackgroundColor6.Margin = new System.Windows.Forms.Padding(0);
            this.SetBackgroundColor6.Name = "SetBackgroundColor6";
            this.SetBackgroundColor6.NormalBackColor = System.Drawing.Color.Goldenrod;
            this.SetBackgroundColor6.OnClickBackColor = System.Drawing.Color.Goldenrod;
            this.SetBackgroundColor6.OnHoverBackColor = System.Drawing.Color.Goldenrod;
            this.SetBackgroundColor6.Size = new System.Drawing.Size(25, 25);
            this.SetBackgroundColor6.TabIndex = 23;
            this.SetBackgroundColor6.UseVisualStyleBackColor = false;
            this.SetBackgroundColor6.Click += new System.EventHandler(this.SetBackgroundColor6_Click);
            // 
            // SetBackgroundColor7
            // 
            this.SetBackgroundColor7.BackColor = System.Drawing.Color.DimGray;
            this.SetBackgroundColor7.CurrentBackColor = System.Drawing.Color.DimGray;
            this.SetBackgroundColor7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBackgroundColor7.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBackgroundColor7.FlatAppearance.BorderSize = 0;
            this.SetBackgroundColor7.ForeColor = System.Drawing.Color.White;
            this.SetBackgroundColor7.Location = new System.Drawing.Point(324, 21);
            this.SetBackgroundColor7.Margin = new System.Windows.Forms.Padding(0);
            this.SetBackgroundColor7.Name = "SetBackgroundColor7";
            this.SetBackgroundColor7.NormalBackColor = System.Drawing.Color.DimGray;
            this.SetBackgroundColor7.OnClickBackColor = System.Drawing.Color.DimGray;
            this.SetBackgroundColor7.OnHoverBackColor = System.Drawing.Color.DimGray;
            this.SetBackgroundColor7.Size = new System.Drawing.Size(25, 25);
            this.SetBackgroundColor7.TabIndex = 24;
            this.SetBackgroundColor7.UseVisualStyleBackColor = false;
            this.SetBackgroundColor7.Click += new System.EventHandler(this.SetBackgroundColor7_Click);
            // 
            // BackgroundColorPicker
            // 
            this.BackgroundColorPicker.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundColorPicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackgroundColorPicker.BackgroundImage")));
            this.BackgroundColorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundColorPicker.CurrentBackColor = System.Drawing.Color.Transparent;
            this.BackgroundColorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackgroundColorPicker.DisabledBackColor = System.Drawing.Color.Gray;
            this.BackgroundColorPicker.FlatAppearance.BorderSize = 0;
            this.BackgroundColorPicker.ForeColor = System.Drawing.Color.White;
            this.BackgroundColorPicker.Location = new System.Drawing.Point(384, 21);
            this.BackgroundColorPicker.Margin = new System.Windows.Forms.Padding(0);
            this.BackgroundColorPicker.Name = "BackgroundColorPicker";
            this.BackgroundColorPicker.NormalBackColor = System.Drawing.Color.Transparent;
            this.BackgroundColorPicker.OnClickBackColor = System.Drawing.Color.Transparent;
            this.BackgroundColorPicker.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.BackgroundColorPicker.Size = new System.Drawing.Size(25, 25);
            this.BackgroundColorPicker.TabIndex = 20;
            this.BackgroundColorPicker.UseVisualStyleBackColor = false;
            this.BackgroundColorPicker.Click += new System.EventHandler(this.BackgroundColorPicker_Click);
            // 
            // BackgroundAlphaLabel
            // 
            this.BackgroundAlphaLabel.Font = new System.Drawing.Font("Fontin SmallCaps", 12F);
            this.BackgroundAlphaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BackgroundAlphaLabel.Location = new System.Drawing.Point(6, 55);
            this.BackgroundAlphaLabel.Name = "BackgroundAlphaLabel";
            this.BackgroundAlphaLabel.Size = new System.Drawing.Size(60, 20);
            this.BackgroundAlphaLabel.TabIndex = 11;
            this.BackgroundAlphaLabel.Text = "Alpha:";
            // 
            // BackgroundAlphaTextBox
            // 
            this.BackgroundAlphaTextBox.Location = new System.Drawing.Point(66, 52);
            this.BackgroundAlphaTextBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BackgroundAlphaTextBox.Name = "BackgroundAlphaTextBox";
            this.BackgroundAlphaTextBox.Size = new System.Drawing.Size(70, 25);
            this.BackgroundAlphaTextBox.TabIndex = 22;
            this.BackgroundAlphaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BackgroundAlphaTextBox.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BackgroundAlphaTextBox.ValueChanged += new System.EventHandler(this.BackgroundAlphaTextBox_ValueChanged);
            // 
            // TrackBarBackgroundAlpha
            // 
            this.TrackBarBackgroundAlpha.BackColor = System.Drawing.Color.Transparent;
            this.TrackBarBackgroundAlpha.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.TrackBarBackgroundAlpha.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.TrackBarBackgroundAlpha.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TrackBarBackgroundAlpha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrackBarBackgroundAlpha.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.TrackBarBackgroundAlpha.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(208)))));
            this.TrackBarBackgroundAlpha.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.TrackBarBackgroundAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.TrackBarBackgroundAlpha.ForeColor = System.Drawing.Color.White;
            this.TrackBarBackgroundAlpha.LargeChange = ((uint)(5u));
            this.TrackBarBackgroundAlpha.Location = new System.Drawing.Point(142, 55);
            this.TrackBarBackgroundAlpha.Maximum = 255;
            this.TrackBarBackgroundAlpha.Name = "TrackBarBackgroundAlpha";
            this.TrackBarBackgroundAlpha.ScaleDivisions = 10;
            this.TrackBarBackgroundAlpha.ScaleSubDivisions = 5;
            this.TrackBarBackgroundAlpha.ShowDivisionsText = true;
            this.TrackBarBackgroundAlpha.ShowSmallScale = false;
            this.TrackBarBackgroundAlpha.Size = new System.Drawing.Size(270, 20);
            this.TrackBarBackgroundAlpha.SmallChange = ((uint)(1u));
            this.TrackBarBackgroundAlpha.TabIndex = 6;
            this.TrackBarBackgroundAlpha.Text = "slider1";
            this.TrackBarBackgroundAlpha.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.TrackBarBackgroundAlpha.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.TrackBarBackgroundAlpha.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.TrackBarBackgroundAlpha.ThumbSize = new System.Drawing.Size(16, 16);
            this.TrackBarBackgroundAlpha.TickAdd = 0F;
            this.TrackBarBackgroundAlpha.TickColor = System.Drawing.Color.White;
            this.TrackBarBackgroundAlpha.TickDivide = 0F;
            this.TrackBarBackgroundAlpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarBackgroundAlpha.Value = 100;
            this.TrackBarBackgroundAlpha.ValueChanged += new System.EventHandler(this.TrackBarBackgroundAlpha_ValueChanged);
            // 
            // BorderGroup
            // 
            this.BorderGroup.Controls.Add(this.SetBorderColor8);
            this.BorderGroup.Controls.Add(this.BorderColorLabel);
            this.BorderGroup.Controls.Add(this.BorderColor);
            this.BorderGroup.Controls.Add(this.SetBorderColor1);
            this.BorderGroup.Controls.Add(this.SetBorderColor2);
            this.BorderGroup.Controls.Add(this.SetBorderColor3);
            this.BorderGroup.Controls.Add(this.SetBorderColor4);
            this.BorderGroup.Controls.Add(this.SetBorderColor5);
            this.BorderGroup.Controls.Add(this.SetBorderColor6);
            this.BorderGroup.Controls.Add(this.SetBorderColor7);
            this.BorderGroup.Controls.Add(this.BorderColorPicker);
            this.BorderGroup.Controls.Add(this.BorderAlphaLabel);
            this.BorderGroup.Controls.Add(this.BorderAlphaTextBox);
            this.BorderGroup.Controls.Add(this.TrackBarBorderAlpha);
            this.BorderGroup.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorderGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BorderGroup.Location = new System.Drawing.Point(0, 331);
            this.BorderGroup.Name = "BorderGroup";
            this.BorderGroup.Size = new System.Drawing.Size(422, 91);
            this.BorderGroup.TabIndex = 25;
            this.BorderGroup.TabStop = false;
            this.BorderGroup.Text = "Border";
            // 
            // SetBorderColor8
            // 
            this.SetBorderColor8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.SetBorderColor8.CurrentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.SetBorderColor8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBorderColor8.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBorderColor8.FlatAppearance.BorderSize = 0;
            this.SetBorderColor8.ForeColor = System.Drawing.Color.White;
            this.SetBorderColor8.Location = new System.Drawing.Point(354, 21);
            this.SetBorderColor8.Margin = new System.Windows.Forms.Padding(0);
            this.SetBorderColor8.Name = "SetBorderColor8";
            this.SetBorderColor8.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.SetBorderColor8.OnClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.SetBorderColor8.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.SetBorderColor8.Size = new System.Drawing.Size(25, 25);
            this.SetBorderColor8.TabIndex = 25;
            this.SetBorderColor8.UseVisualStyleBackColor = false;
            // 
            // BorderColorLabel
            // 
            this.BorderColorLabel.Font = new System.Drawing.Font("Fontin SmallCaps", 12F);
            this.BorderColorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BorderColorLabel.Location = new System.Drawing.Point(6, 24);
            this.BorderColorLabel.Name = "BorderColorLabel";
            this.BorderColorLabel.Size = new System.Drawing.Size(60, 20);
            this.BorderColorLabel.TabIndex = 10;
            this.BorderColorLabel.Text = "Color:";
            // 
            // BorderColor
            // 
            this.BorderColor.BackColor = System.Drawing.Color.White;
            this.BorderColor.Controls.Add(this.BorderColorHashtag);
            this.BorderColor.Controls.Add(this.BorderColorTextBox);
            this.BorderColor.Location = new System.Drawing.Point(66, 21);
            this.BorderColor.Name = "BorderColor";
            this.BorderColor.Size = new System.Drawing.Size(70, 25);
            this.BorderColor.TabIndex = 13;
            // 
            // BorderColorHashtag
            // 
            this.BorderColorHashtag.BackColor = System.Drawing.Color.White;
            this.BorderColorHashtag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BorderColorHashtag.Location = new System.Drawing.Point(1, 1);
            this.BorderColorHashtag.Margin = new System.Windows.Forms.Padding(0);
            this.BorderColorHashtag.Name = "BorderColorHashtag";
            this.BorderColorHashtag.Size = new System.Drawing.Size(14, 23);
            this.BorderColorHashtag.TabIndex = 23;
            this.BorderColorHashtag.Text = "#";
            this.BorderColorHashtag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BorderColorTextBox
            // 
            this.BorderColorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BorderColorTextBox.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorderColorTextBox.Location = new System.Drawing.Point(15, 4);
            this.BorderColorTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.BorderColorTextBox.MaxLength = 6;
            this.BorderColorTextBox.Name = "BorderColorTextBox";
            this.BorderColorTextBox.Size = new System.Drawing.Size(53, 18);
            this.BorderColorTextBox.TabIndex = 13;
            this.BorderColorTextBox.Text = "4682B4";
            this.BorderColorTextBox.TextChanged += new System.EventHandler(this.BorderColorTextBox_TextChanged);
            // 
            // SetBorderColor1
            // 
            this.SetBorderColor1.BackColor = System.Drawing.Color.White;
            this.SetBorderColor1.CurrentBackColor = System.Drawing.Color.White;
            this.SetBorderColor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBorderColor1.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBorderColor1.FlatAppearance.BorderSize = 0;
            this.SetBorderColor1.ForeColor = System.Drawing.Color.White;
            this.SetBorderColor1.Location = new System.Drawing.Point(144, 21);
            this.SetBorderColor1.Margin = new System.Windows.Forms.Padding(0);
            this.SetBorderColor1.Name = "SetBorderColor1";
            this.SetBorderColor1.NormalBackColor = System.Drawing.Color.White;
            this.SetBorderColor1.OnClickBackColor = System.Drawing.Color.White;
            this.SetBorderColor1.OnHoverBackColor = System.Drawing.Color.White;
            this.SetBorderColor1.Size = new System.Drawing.Size(25, 25);
            this.SetBorderColor1.TabIndex = 15;
            this.SetBorderColor1.UseVisualStyleBackColor = false;
            this.SetBorderColor1.Click += new System.EventHandler(this.SetBorderColor1_Click);
            // 
            // SetBorderColor2
            // 
            this.SetBorderColor2.BackColor = System.Drawing.Color.Black;
            this.SetBorderColor2.CurrentBackColor = System.Drawing.Color.Black;
            this.SetBorderColor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBorderColor2.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBorderColor2.FlatAppearance.BorderSize = 0;
            this.SetBorderColor2.ForeColor = System.Drawing.Color.White;
            this.SetBorderColor2.Location = new System.Drawing.Point(174, 21);
            this.SetBorderColor2.Margin = new System.Windows.Forms.Padding(0);
            this.SetBorderColor2.Name = "SetBorderColor2";
            this.SetBorderColor2.NormalBackColor = System.Drawing.Color.Black;
            this.SetBorderColor2.OnClickBackColor = System.Drawing.Color.Black;
            this.SetBorderColor2.OnHoverBackColor = System.Drawing.Color.Black;
            this.SetBorderColor2.Size = new System.Drawing.Size(25, 25);
            this.SetBorderColor2.TabIndex = 19;
            this.SetBorderColor2.UseVisualStyleBackColor = false;
            this.SetBorderColor2.Click += new System.EventHandler(this.SetBorderColor2_Click);
            // 
            // SetBorderColor3
            // 
            this.SetBorderColor3.BackColor = System.Drawing.Color.DarkRed;
            this.SetBorderColor3.CurrentBackColor = System.Drawing.Color.DarkRed;
            this.SetBorderColor3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBorderColor3.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBorderColor3.FlatAppearance.BorderSize = 0;
            this.SetBorderColor3.ForeColor = System.Drawing.Color.White;
            this.SetBorderColor3.Location = new System.Drawing.Point(204, 21);
            this.SetBorderColor3.Margin = new System.Windows.Forms.Padding(0);
            this.SetBorderColor3.Name = "SetBorderColor3";
            this.SetBorderColor3.NormalBackColor = System.Drawing.Color.DarkRed;
            this.SetBorderColor3.OnClickBackColor = System.Drawing.Color.DarkRed;
            this.SetBorderColor3.OnHoverBackColor = System.Drawing.Color.DarkRed;
            this.SetBorderColor3.Size = new System.Drawing.Size(25, 25);
            this.SetBorderColor3.TabIndex = 16;
            this.SetBorderColor3.UseVisualStyleBackColor = false;
            this.SetBorderColor3.Click += new System.EventHandler(this.SetBorderColor3_Click);
            // 
            // SetBorderColor4
            // 
            this.SetBorderColor4.BackColor = System.Drawing.Color.DarkGreen;
            this.SetBorderColor4.CurrentBackColor = System.Drawing.Color.DarkGreen;
            this.SetBorderColor4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBorderColor4.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBorderColor4.FlatAppearance.BorderSize = 0;
            this.SetBorderColor4.ForeColor = System.Drawing.Color.White;
            this.SetBorderColor4.Location = new System.Drawing.Point(234, 21);
            this.SetBorderColor4.Margin = new System.Windows.Forms.Padding(0);
            this.SetBorderColor4.Name = "SetBorderColor4";
            this.SetBorderColor4.NormalBackColor = System.Drawing.Color.DarkGreen;
            this.SetBorderColor4.OnClickBackColor = System.Drawing.Color.DarkGreen;
            this.SetBorderColor4.OnHoverBackColor = System.Drawing.Color.DarkGreen;
            this.SetBorderColor4.Size = new System.Drawing.Size(25, 25);
            this.SetBorderColor4.TabIndex = 17;
            this.SetBorderColor4.UseVisualStyleBackColor = false;
            this.SetBorderColor4.Click += new System.EventHandler(this.SetBorderColor4_Click);
            // 
            // SetBorderColor5
            // 
            this.SetBorderColor5.BackColor = System.Drawing.Color.SteelBlue;
            this.SetBorderColor5.CurrentBackColor = System.Drawing.Color.SteelBlue;
            this.SetBorderColor5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBorderColor5.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBorderColor5.FlatAppearance.BorderSize = 0;
            this.SetBorderColor5.ForeColor = System.Drawing.Color.White;
            this.SetBorderColor5.Location = new System.Drawing.Point(264, 21);
            this.SetBorderColor5.Margin = new System.Windows.Forms.Padding(0);
            this.SetBorderColor5.Name = "SetBorderColor5";
            this.SetBorderColor5.NormalBackColor = System.Drawing.Color.SteelBlue;
            this.SetBorderColor5.OnClickBackColor = System.Drawing.Color.SteelBlue;
            this.SetBorderColor5.OnHoverBackColor = System.Drawing.Color.SteelBlue;
            this.SetBorderColor5.Size = new System.Drawing.Size(25, 25);
            this.SetBorderColor5.TabIndex = 18;
            this.SetBorderColor5.UseVisualStyleBackColor = false;
            this.SetBorderColor5.Click += new System.EventHandler(this.SetBorderColor5_Click);
            // 
            // SetBorderColor6
            // 
            this.SetBorderColor6.BackColor = System.Drawing.Color.Goldenrod;
            this.SetBorderColor6.CurrentBackColor = System.Drawing.Color.Goldenrod;
            this.SetBorderColor6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBorderColor6.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBorderColor6.FlatAppearance.BorderSize = 0;
            this.SetBorderColor6.ForeColor = System.Drawing.Color.White;
            this.SetBorderColor6.Location = new System.Drawing.Point(294, 21);
            this.SetBorderColor6.Margin = new System.Windows.Forms.Padding(0);
            this.SetBorderColor6.Name = "SetBorderColor6";
            this.SetBorderColor6.NormalBackColor = System.Drawing.Color.Goldenrod;
            this.SetBorderColor6.OnClickBackColor = System.Drawing.Color.Goldenrod;
            this.SetBorderColor6.OnHoverBackColor = System.Drawing.Color.Goldenrod;
            this.SetBorderColor6.Size = new System.Drawing.Size(25, 25);
            this.SetBorderColor6.TabIndex = 23;
            this.SetBorderColor6.UseVisualStyleBackColor = false;
            this.SetBorderColor6.Click += new System.EventHandler(this.SetBorderColor6_Click);
            // 
            // SetBorderColor7
            // 
            this.SetBorderColor7.BackColor = System.Drawing.Color.DimGray;
            this.SetBorderColor7.CurrentBackColor = System.Drawing.Color.DimGray;
            this.SetBorderColor7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetBorderColor7.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetBorderColor7.FlatAppearance.BorderSize = 0;
            this.SetBorderColor7.ForeColor = System.Drawing.Color.White;
            this.SetBorderColor7.Location = new System.Drawing.Point(324, 21);
            this.SetBorderColor7.Margin = new System.Windows.Forms.Padding(0);
            this.SetBorderColor7.Name = "SetBorderColor7";
            this.SetBorderColor7.NormalBackColor = System.Drawing.Color.DimGray;
            this.SetBorderColor7.OnClickBackColor = System.Drawing.Color.DimGray;
            this.SetBorderColor7.OnHoverBackColor = System.Drawing.Color.DimGray;
            this.SetBorderColor7.Size = new System.Drawing.Size(25, 25);
            this.SetBorderColor7.TabIndex = 24;
            this.SetBorderColor7.UseVisualStyleBackColor = false;
            this.SetBorderColor7.Click += new System.EventHandler(this.SetBorderColor7_Click);
            // 
            // BorderColorPicker
            // 
            this.BorderColorPicker.BackColor = System.Drawing.Color.Transparent;
            this.BorderColorPicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BorderColorPicker.BackgroundImage")));
            this.BorderColorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderColorPicker.CurrentBackColor = System.Drawing.Color.Transparent;
            this.BorderColorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorderColorPicker.DisabledBackColor = System.Drawing.Color.Gray;
            this.BorderColorPicker.FlatAppearance.BorderSize = 0;
            this.BorderColorPicker.ForeColor = System.Drawing.Color.White;
            this.BorderColorPicker.Location = new System.Drawing.Point(384, 21);
            this.BorderColorPicker.Margin = new System.Windows.Forms.Padding(0);
            this.BorderColorPicker.Name = "BorderColorPicker";
            this.BorderColorPicker.NormalBackColor = System.Drawing.Color.Transparent;
            this.BorderColorPicker.OnClickBackColor = System.Drawing.Color.Transparent;
            this.BorderColorPicker.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.BorderColorPicker.Size = new System.Drawing.Size(25, 25);
            this.BorderColorPicker.TabIndex = 20;
            this.BorderColorPicker.UseVisualStyleBackColor = false;
            this.BorderColorPicker.Click += new System.EventHandler(this.BorderColorPicker_Click);
            // 
            // BorderAlphaLabel
            // 
            this.BorderAlphaLabel.Font = new System.Drawing.Font("Fontin SmallCaps", 12F);
            this.BorderAlphaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BorderAlphaLabel.Location = new System.Drawing.Point(6, 55);
            this.BorderAlphaLabel.Name = "BorderAlphaLabel";
            this.BorderAlphaLabel.Size = new System.Drawing.Size(60, 20);
            this.BorderAlphaLabel.TabIndex = 11;
            this.BorderAlphaLabel.Text = "Alpha:";
            // 
            // BorderAlphaTextBox
            // 
            this.BorderAlphaTextBox.Location = new System.Drawing.Point(66, 52);
            this.BorderAlphaTextBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BorderAlphaTextBox.Name = "BorderAlphaTextBox";
            this.BorderAlphaTextBox.Size = new System.Drawing.Size(70, 25);
            this.BorderAlphaTextBox.TabIndex = 22;
            this.BorderAlphaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BorderAlphaTextBox.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BorderAlphaTextBox.ValueChanged += new System.EventHandler(this.BorderAlphaTextBox_ValueChanged);
            // 
            // TrackBarBorderAlpha
            // 
            this.TrackBarBorderAlpha.BackColor = System.Drawing.Color.Transparent;
            this.TrackBarBorderAlpha.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.TrackBarBorderAlpha.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.TrackBarBorderAlpha.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TrackBarBorderAlpha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrackBarBorderAlpha.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.TrackBarBorderAlpha.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(208)))));
            this.TrackBarBorderAlpha.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.TrackBarBorderAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.TrackBarBorderAlpha.ForeColor = System.Drawing.Color.White;
            this.TrackBarBorderAlpha.LargeChange = ((uint)(5u));
            this.TrackBarBorderAlpha.Location = new System.Drawing.Point(142, 55);
            this.TrackBarBorderAlpha.Maximum = 255;
            this.TrackBarBorderAlpha.Name = "TrackBarBorderAlpha";
            this.TrackBarBorderAlpha.ScaleDivisions = 10;
            this.TrackBarBorderAlpha.ScaleSubDivisions = 5;
            this.TrackBarBorderAlpha.ShowDivisionsText = true;
            this.TrackBarBorderAlpha.ShowSmallScale = false;
            this.TrackBarBorderAlpha.Size = new System.Drawing.Size(270, 20);
            this.TrackBarBorderAlpha.SmallChange = ((uint)(1u));
            this.TrackBarBorderAlpha.TabIndex = 6;
            this.TrackBarBorderAlpha.Text = "slider1";
            this.TrackBarBorderAlpha.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.TrackBarBorderAlpha.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.TrackBarBorderAlpha.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.TrackBarBorderAlpha.ThumbSize = new System.Drawing.Size(16, 16);
            this.TrackBarBorderAlpha.TickAdd = 0F;
            this.TrackBarBorderAlpha.TickColor = System.Drawing.Color.White;
            this.TrackBarBorderAlpha.TickDivide = 0F;
            this.TrackBarBorderAlpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarBorderAlpha.Value = 100;
            this.TrackBarBorderAlpha.ValueChanged += new System.EventHandler(this.TrackBarBorderAlpha_ValueChanged);
            // 
            // TextGroup
            // 
            this.TextGroup.Controls.Add(this.SetTextColor8);
            this.TextGroup.Controls.Add(this.FontSizeLabel);
            this.TextGroup.Controls.Add(this.FontSizeTextBox);
            this.TextGroup.Controls.Add(this.TrackBarFontSize);
            this.TextGroup.Controls.Add(this.FontColorLabel);
            this.TextGroup.Controls.Add(this.FontColor);
            this.TextGroup.Controls.Add(this.SetTextColor1);
            this.TextGroup.Controls.Add(this.SetTextColor2);
            this.TextGroup.Controls.Add(this.SetTextColor3);
            this.TextGroup.Controls.Add(this.SetTextColor4);
            this.TextGroup.Controls.Add(this.SetTextColor5);
            this.TextGroup.Controls.Add(this.SetTextColor6);
            this.TextGroup.Controls.Add(this.SetTextColor7);
            this.TextGroup.Controls.Add(this.TextColorPicker);
            this.TextGroup.Controls.Add(this.FontAlphaLabel);
            this.TextGroup.Controls.Add(this.FontAlphaTextBox);
            this.TextGroup.Controls.Add(this.TrackBarFontAlpha);
            this.TextGroup.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.TextGroup.Location = new System.Drawing.Point(0, 105);
            this.TextGroup.Name = "TextGroup";
            this.TextGroup.Size = new System.Drawing.Size(422, 122);
            this.TextGroup.TabIndex = 12;
            this.TextGroup.TabStop = false;
            this.TextGroup.Text = "Text";
            // 
            // SetTextColor8
            // 
            this.SetTextColor8.BackColor = System.Drawing.Color.DimGray;
            this.SetTextColor8.CurrentBackColor = System.Drawing.Color.DimGray;
            this.SetTextColor8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetTextColor8.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetTextColor8.FlatAppearance.BorderSize = 0;
            this.SetTextColor8.ForeColor = System.Drawing.Color.White;
            this.SetTextColor8.Location = new System.Drawing.Point(354, 52);
            this.SetTextColor8.Margin = new System.Windows.Forms.Padding(0);
            this.SetTextColor8.Name = "SetTextColor8";
            this.SetTextColor8.NormalBackColor = System.Drawing.Color.DimGray;
            this.SetTextColor8.OnClickBackColor = System.Drawing.Color.DimGray;
            this.SetTextColor8.OnHoverBackColor = System.Drawing.Color.DimGray;
            this.SetTextColor8.Size = new System.Drawing.Size(25, 25);
            this.SetTextColor8.TabIndex = 25;
            this.SetTextColor8.UseVisualStyleBackColor = false;
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.Font = new System.Drawing.Font("Fontin SmallCaps", 12F);
            this.FontSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.FontSizeLabel.Location = new System.Drawing.Point(6, 24);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(60, 20);
            this.FontSizeLabel.TabIndex = 9;
            this.FontSizeLabel.Text = "Size:";
            // 
            // FontSizeTextBox
            // 
            this.FontSizeTextBox.Location = new System.Drawing.Point(66, 21);
            this.FontSizeTextBox.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.FontSizeTextBox.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.FontSizeTextBox.Name = "FontSizeTextBox";
            this.FontSizeTextBox.Size = new System.Drawing.Size(70, 25);
            this.FontSizeTextBox.TabIndex = 21;
            this.FontSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FontSizeTextBox.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.FontSizeTextBox.ValueChanged += new System.EventHandler(this.FontSizeTextBox_ValueChanged);
            // 
            // TrackBarFontSize
            // 
            this.TrackBarFontSize.BackColor = System.Drawing.Color.Transparent;
            this.TrackBarFontSize.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.TrackBarFontSize.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.TrackBarFontSize.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TrackBarFontSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrackBarFontSize.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.TrackBarFontSize.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(208)))));
            this.TrackBarFontSize.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.TrackBarFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.TrackBarFontSize.ForeColor = System.Drawing.Color.White;
            this.TrackBarFontSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TrackBarFontSize.LargeChange = ((uint)(5u));
            this.TrackBarFontSize.Location = new System.Drawing.Point(142, 24);
            this.TrackBarFontSize.Maximum = 45;
            this.TrackBarFontSize.Minimum = 18;
            this.TrackBarFontSize.Name = "TrackBarFontSize";
            this.TrackBarFontSize.ScaleDivisions = 10;
            this.TrackBarFontSize.ScaleSubDivisions = 5;
            this.TrackBarFontSize.ShowDivisionsText = false;
            this.TrackBarFontSize.ShowSmallScale = false;
            this.TrackBarFontSize.Size = new System.Drawing.Size(270, 20);
            this.TrackBarFontSize.SmallChange = ((uint)(1u));
            this.TrackBarFontSize.TabIndex = 5;
            this.TrackBarFontSize.Text = "slider1";
            this.TrackBarFontSize.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.TrackBarFontSize.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.TrackBarFontSize.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.TrackBarFontSize.ThumbSize = new System.Drawing.Size(16, 16);
            this.TrackBarFontSize.TickAdd = 0F;
            this.TrackBarFontSize.TickColor = System.Drawing.Color.White;
            this.TrackBarFontSize.TickDivide = 0F;
            this.TrackBarFontSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarFontSize.ValueChanged += new System.EventHandler(this.TrackBarFontSize_ValueChanged);
            // 
            // FontColorLabel
            // 
            this.FontColorLabel.Font = new System.Drawing.Font("Fontin SmallCaps", 12F);
            this.FontColorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.FontColorLabel.Location = new System.Drawing.Point(6, 55);
            this.FontColorLabel.Name = "FontColorLabel";
            this.FontColorLabel.Size = new System.Drawing.Size(60, 20);
            this.FontColorLabel.TabIndex = 10;
            this.FontColorLabel.Text = "Color:";
            // 
            // FontColor
            // 
            this.FontColor.BackColor = System.Drawing.Color.White;
            this.FontColor.Controls.Add(this.FontColorHashtag);
            this.FontColor.Controls.Add(this.FontColorTextBox);
            this.FontColor.Location = new System.Drawing.Point(66, 52);
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(70, 25);
            this.FontColor.TabIndex = 13;
            // 
            // FontColorHashtag
            // 
            this.FontColorHashtag.BackColor = System.Drawing.Color.White;
            this.FontColorHashtag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FontColorHashtag.Location = new System.Drawing.Point(1, 1);
            this.FontColorHashtag.Margin = new System.Windows.Forms.Padding(0);
            this.FontColorHashtag.Name = "FontColorHashtag";
            this.FontColorHashtag.Size = new System.Drawing.Size(14, 23);
            this.FontColorHashtag.TabIndex = 23;
            this.FontColorHashtag.Text = "#";
            this.FontColorHashtag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FontColorTextBox
            // 
            this.FontColorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FontColorTextBox.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontColorTextBox.Location = new System.Drawing.Point(15, 4);
            this.FontColorTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.FontColorTextBox.MaxLength = 6;
            this.FontColorTextBox.Name = "FontColorTextBox";
            this.FontColorTextBox.Size = new System.Drawing.Size(53, 18);
            this.FontColorTextBox.TabIndex = 13;
            this.FontColorTextBox.Text = "4682B4";
            this.FontColorTextBox.TextChanged += new System.EventHandler(this.FontColorTextBox_TextChanged);
            // 
            // SetTextColor1
            // 
            this.SetTextColor1.BackColor = System.Drawing.Color.White;
            this.SetTextColor1.CurrentBackColor = System.Drawing.Color.White;
            this.SetTextColor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetTextColor1.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetTextColor1.FlatAppearance.BorderSize = 0;
            this.SetTextColor1.ForeColor = System.Drawing.Color.White;
            this.SetTextColor1.Location = new System.Drawing.Point(144, 52);
            this.SetTextColor1.Margin = new System.Windows.Forms.Padding(0);
            this.SetTextColor1.Name = "SetTextColor1";
            this.SetTextColor1.NormalBackColor = System.Drawing.Color.White;
            this.SetTextColor1.OnClickBackColor = System.Drawing.Color.White;
            this.SetTextColor1.OnHoverBackColor = System.Drawing.Color.White;
            this.SetTextColor1.Size = new System.Drawing.Size(25, 25);
            this.SetTextColor1.TabIndex = 15;
            this.SetTextColor1.UseVisualStyleBackColor = false;
            this.SetTextColor1.Click += new System.EventHandler(this.SetTextColor1_Click);
            // 
            // SetTextColor2
            // 
            this.SetTextColor2.BackColor = System.Drawing.Color.Black;
            this.SetTextColor2.CurrentBackColor = System.Drawing.Color.Black;
            this.SetTextColor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetTextColor2.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetTextColor2.FlatAppearance.BorderSize = 0;
            this.SetTextColor2.ForeColor = System.Drawing.Color.White;
            this.SetTextColor2.Location = new System.Drawing.Point(174, 52);
            this.SetTextColor2.Margin = new System.Windows.Forms.Padding(0);
            this.SetTextColor2.Name = "SetTextColor2";
            this.SetTextColor2.NormalBackColor = System.Drawing.Color.Black;
            this.SetTextColor2.OnClickBackColor = System.Drawing.Color.Black;
            this.SetTextColor2.OnHoverBackColor = System.Drawing.Color.Black;
            this.SetTextColor2.Size = new System.Drawing.Size(25, 25);
            this.SetTextColor2.TabIndex = 19;
            this.SetTextColor2.UseVisualStyleBackColor = false;
            this.SetTextColor2.Click += new System.EventHandler(this.SetTextColor2_Click);
            // 
            // SetTextColor3
            // 
            this.SetTextColor3.BackColor = System.Drawing.Color.DarkRed;
            this.SetTextColor3.CurrentBackColor = System.Drawing.Color.DarkRed;
            this.SetTextColor3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetTextColor3.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetTextColor3.FlatAppearance.BorderSize = 0;
            this.SetTextColor3.ForeColor = System.Drawing.Color.White;
            this.SetTextColor3.Location = new System.Drawing.Point(204, 52);
            this.SetTextColor3.Margin = new System.Windows.Forms.Padding(0);
            this.SetTextColor3.Name = "SetTextColor3";
            this.SetTextColor3.NormalBackColor = System.Drawing.Color.DarkRed;
            this.SetTextColor3.OnClickBackColor = System.Drawing.Color.DarkRed;
            this.SetTextColor3.OnHoverBackColor = System.Drawing.Color.DarkRed;
            this.SetTextColor3.Size = new System.Drawing.Size(25, 25);
            this.SetTextColor3.TabIndex = 16;
            this.SetTextColor3.UseVisualStyleBackColor = false;
            this.SetTextColor3.Click += new System.EventHandler(this.SetTextColor3_Click);
            // 
            // SetTextColor4
            // 
            this.SetTextColor4.BackColor = System.Drawing.Color.DarkGreen;
            this.SetTextColor4.CurrentBackColor = System.Drawing.Color.DarkGreen;
            this.SetTextColor4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetTextColor4.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetTextColor4.FlatAppearance.BorderSize = 0;
            this.SetTextColor4.ForeColor = System.Drawing.Color.White;
            this.SetTextColor4.Location = new System.Drawing.Point(234, 52);
            this.SetTextColor4.Margin = new System.Windows.Forms.Padding(0);
            this.SetTextColor4.Name = "SetTextColor4";
            this.SetTextColor4.NormalBackColor = System.Drawing.Color.DarkGreen;
            this.SetTextColor4.OnClickBackColor = System.Drawing.Color.DarkGreen;
            this.SetTextColor4.OnHoverBackColor = System.Drawing.Color.DarkGreen;
            this.SetTextColor4.Size = new System.Drawing.Size(25, 25);
            this.SetTextColor4.TabIndex = 17;
            this.SetTextColor4.UseVisualStyleBackColor = false;
            this.SetTextColor4.Click += new System.EventHandler(this.SetTextColor4_Click);
            // 
            // SetTextColor5
            // 
            this.SetTextColor5.BackColor = System.Drawing.Color.SteelBlue;
            this.SetTextColor5.CurrentBackColor = System.Drawing.Color.SteelBlue;
            this.SetTextColor5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetTextColor5.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetTextColor5.FlatAppearance.BorderSize = 0;
            this.SetTextColor5.ForeColor = System.Drawing.Color.White;
            this.SetTextColor5.Location = new System.Drawing.Point(264, 52);
            this.SetTextColor5.Margin = new System.Windows.Forms.Padding(0);
            this.SetTextColor5.Name = "SetTextColor5";
            this.SetTextColor5.NormalBackColor = System.Drawing.Color.SteelBlue;
            this.SetTextColor5.OnClickBackColor = System.Drawing.Color.SteelBlue;
            this.SetTextColor5.OnHoverBackColor = System.Drawing.Color.SteelBlue;
            this.SetTextColor5.Size = new System.Drawing.Size(25, 25);
            this.SetTextColor5.TabIndex = 18;
            this.SetTextColor5.UseVisualStyleBackColor = false;
            this.SetTextColor5.Click += new System.EventHandler(this.SetTextColor5_Click);
            // 
            // SetTextColor6
            // 
            this.SetTextColor6.BackColor = System.Drawing.Color.Goldenrod;
            this.SetTextColor6.CurrentBackColor = System.Drawing.Color.Goldenrod;
            this.SetTextColor6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetTextColor6.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetTextColor6.FlatAppearance.BorderSize = 0;
            this.SetTextColor6.ForeColor = System.Drawing.Color.White;
            this.SetTextColor6.Location = new System.Drawing.Point(294, 52);
            this.SetTextColor6.Margin = new System.Windows.Forms.Padding(0);
            this.SetTextColor6.Name = "SetTextColor6";
            this.SetTextColor6.NormalBackColor = System.Drawing.Color.Goldenrod;
            this.SetTextColor6.OnClickBackColor = System.Drawing.Color.Goldenrod;
            this.SetTextColor6.OnHoverBackColor = System.Drawing.Color.Goldenrod;
            this.SetTextColor6.Size = new System.Drawing.Size(25, 25);
            this.SetTextColor6.TabIndex = 23;
            this.SetTextColor6.UseVisualStyleBackColor = false;
            this.SetTextColor6.Click += new System.EventHandler(this.SetTextColor6_Click);
            // 
            // SetTextColor7
            // 
            this.SetTextColor7.BackColor = System.Drawing.Color.DimGray;
            this.SetTextColor7.CurrentBackColor = System.Drawing.Color.DimGray;
            this.SetTextColor7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetTextColor7.DisabledBackColor = System.Drawing.Color.Gray;
            this.SetTextColor7.FlatAppearance.BorderSize = 0;
            this.SetTextColor7.ForeColor = System.Drawing.Color.White;
            this.SetTextColor7.Location = new System.Drawing.Point(324, 52);
            this.SetTextColor7.Margin = new System.Windows.Forms.Padding(0);
            this.SetTextColor7.Name = "SetTextColor7";
            this.SetTextColor7.NormalBackColor = System.Drawing.Color.DimGray;
            this.SetTextColor7.OnClickBackColor = System.Drawing.Color.DimGray;
            this.SetTextColor7.OnHoverBackColor = System.Drawing.Color.DimGray;
            this.SetTextColor7.Size = new System.Drawing.Size(25, 25);
            this.SetTextColor7.TabIndex = 24;
            this.SetTextColor7.UseVisualStyleBackColor = false;
            this.SetTextColor7.Click += new System.EventHandler(this.SetTextColor7_Click);
            // 
            // TextColorPicker
            // 
            this.TextColorPicker.BackColor = System.Drawing.Color.Transparent;
            this.TextColorPicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextColorPicker.BackgroundImage")));
            this.TextColorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TextColorPicker.CurrentBackColor = System.Drawing.Color.Transparent;
            this.TextColorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextColorPicker.DisabledBackColor = System.Drawing.Color.Gray;
            this.TextColorPicker.FlatAppearance.BorderSize = 0;
            this.TextColorPicker.ForeColor = System.Drawing.Color.White;
            this.TextColorPicker.Location = new System.Drawing.Point(384, 52);
            this.TextColorPicker.Margin = new System.Windows.Forms.Padding(0);
            this.TextColorPicker.Name = "TextColorPicker";
            this.TextColorPicker.NormalBackColor = System.Drawing.Color.Transparent;
            this.TextColorPicker.OnClickBackColor = System.Drawing.Color.Transparent;
            this.TextColorPicker.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.TextColorPicker.Size = new System.Drawing.Size(25, 25);
            this.TextColorPicker.TabIndex = 20;
            this.TextColorPicker.UseVisualStyleBackColor = false;
            this.TextColorPicker.Click += new System.EventHandler(this.TextColorPicker_Click);
            // 
            // FontAlphaLabel
            // 
            this.FontAlphaLabel.Font = new System.Drawing.Font("Fontin SmallCaps", 12F);
            this.FontAlphaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.FontAlphaLabel.Location = new System.Drawing.Point(6, 86);
            this.FontAlphaLabel.Name = "FontAlphaLabel";
            this.FontAlphaLabel.Size = new System.Drawing.Size(60, 20);
            this.FontAlphaLabel.TabIndex = 11;
            this.FontAlphaLabel.Text = "Alpha:";
            // 
            // FontAlphaTextBox
            // 
            this.FontAlphaTextBox.Location = new System.Drawing.Point(66, 83);
            this.FontAlphaTextBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.FontAlphaTextBox.Name = "FontAlphaTextBox";
            this.FontAlphaTextBox.Size = new System.Drawing.Size(70, 25);
            this.FontAlphaTextBox.TabIndex = 22;
            this.FontAlphaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FontAlphaTextBox.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.FontAlphaTextBox.ValueChanged += new System.EventHandler(this.FontAlphaTextBox_ValueChanged);
            // 
            // TrackBarFontAlpha
            // 
            this.TrackBarFontAlpha.BackColor = System.Drawing.Color.Transparent;
            this.TrackBarFontAlpha.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.TrackBarFontAlpha.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.TrackBarFontAlpha.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TrackBarFontAlpha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrackBarFontAlpha.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.TrackBarFontAlpha.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(208)))));
            this.TrackBarFontAlpha.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.TrackBarFontAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.TrackBarFontAlpha.ForeColor = System.Drawing.Color.White;
            this.TrackBarFontAlpha.LargeChange = ((uint)(5u));
            this.TrackBarFontAlpha.Location = new System.Drawing.Point(142, 86);
            this.TrackBarFontAlpha.Maximum = 255;
            this.TrackBarFontAlpha.Name = "TrackBarFontAlpha";
            this.TrackBarFontAlpha.ScaleDivisions = 10;
            this.TrackBarFontAlpha.ScaleSubDivisions = 5;
            this.TrackBarFontAlpha.ShowDivisionsText = true;
            this.TrackBarFontAlpha.ShowSmallScale = false;
            this.TrackBarFontAlpha.Size = new System.Drawing.Size(270, 20);
            this.TrackBarFontAlpha.SmallChange = ((uint)(1u));
            this.TrackBarFontAlpha.TabIndex = 6;
            this.TrackBarFontAlpha.Text = "slider1";
            this.TrackBarFontAlpha.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.TrackBarFontAlpha.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.TrackBarFontAlpha.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.TrackBarFontAlpha.ThumbSize = new System.Drawing.Size(16, 16);
            this.TrackBarFontAlpha.TickAdd = 0F;
            this.TrackBarFontAlpha.TickColor = System.Drawing.Color.White;
            this.TrackBarFontAlpha.TickDivide = 0F;
            this.TrackBarFontAlpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarFontAlpha.Value = 100;
            this.TrackBarFontAlpha.ValueChanged += new System.EventHandler(this.TrackBarFontAlpha_ValueChanged);
            // 
            // OtherGroup
            // 
            this.OtherGroup.Controls.Add(this.ChangeVolume);
            this.OtherGroup.Controls.Add(this.ChangeSoundDropdown);
            this.OtherGroup.Controls.Add(this.ChangeBeamButton);
            this.OtherGroup.Controls.Add(this.ChangeIconButton);
            this.OtherGroup.Controls.Add(this.label4);
            this.OtherGroup.Controls.Add(this.label3);
            this.OtherGroup.Controls.Add(this.label2);
            this.OtherGroup.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OtherGroup.Location = new System.Drawing.Point(0, 425);
            this.OtherGroup.Name = "OtherGroup";
            this.OtherGroup.Size = new System.Drawing.Size(422, 57);
            this.OtherGroup.TabIndex = 29;
            this.OtherGroup.TabStop = false;
            this.OtherGroup.Text = "Other";
            // 
            // ChangeVolume
            // 
            this.ChangeVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeVolume.Image = ((System.Drawing.Image)(resources.GetObject("ChangeVolume.Image")));
            this.ChangeVolume.Location = new System.Drawing.Point(390, 21);
            this.ChangeVolume.Name = "ChangeVolume";
            this.ChangeVolume.Size = new System.Drawing.Size(26, 26);
            this.ChangeVolume.TabIndex = 10;
            this.ChangeVolume.TabStop = false;
            this.ChangeVolume.Click += new System.EventHandler(this.ChangeVolume_Click);
            // 
            // ChangeSoundDropdown
            // 
            this.ChangeSoundDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeSoundDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChangeSoundDropdown.DropDownWidth = 200;
            this.ChangeSoundDropdown.FormattingEnabled = true;
            this.ChangeSoundDropdown.Location = new System.Drawing.Point(240, 21);
            this.ChangeSoundDropdown.Name = "ChangeSoundDropdown";
            this.ChangeSoundDropdown.Size = new System.Drawing.Size(144, 25);
            this.ChangeSoundDropdown.TabIndex = 9;
            this.ChangeSoundDropdown.SelectedIndexChanged += new System.EventHandler(this.ChangeSoundDropdown_SelectedIndexChanged);
            // 
            // ChangeBeamButton
            // 
            this.ChangeBeamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeBeamButton.Image = global::PoE_Easy_Mapping.Properties.Resources.IconBeamWhite;
            this.ChangeBeamButton.Location = new System.Drawing.Point(140, 21);
            this.ChangeBeamButton.Name = "ChangeBeamButton";
            this.ChangeBeamButton.Size = new System.Drawing.Size(26, 26);
            this.ChangeBeamButton.TabIndex = 8;
            this.ChangeBeamButton.TabStop = false;
            this.ChangeBeamButton.Click += new System.EventHandler(this.ChangeBeamButton_Click);
            // 
            // ChangeIconButton
            // 
            this.ChangeIconButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeIconButton.Image = global::PoE_Easy_Mapping.Properties.Resources.IconSphereBlue;
            this.ChangeIconButton.Location = new System.Drawing.Point(54, 21);
            this.ChangeIconButton.Name = "ChangeIconButton";
            this.ChangeIconButton.Size = new System.Drawing.Size(26, 26);
            this.ChangeIconButton.TabIndex = 7;
            this.ChangeIconButton.TabStop = false;
            this.ChangeIconButton.Click += new System.EventHandler(this.ChangeIconButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(90, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Beam:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(176, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sound:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Icon:";
            // 
            // StyleListGroup
            // 
            this.StyleListGroup.Controls.Add(this.DeleteStyleButton);
            this.StyleListGroup.Controls.Add(this.NewStyleButton);
            this.StyleListGroup.Controls.Add(this.PasteStyleButton);
            this.StyleListGroup.Controls.Add(this.CopyStyleButton);
            this.StyleListGroup.Controls.Add(this.RevertStyleButton);
            this.StyleListGroup.Controls.Add(this.StyleList);
            this.StyleListGroup.Controls.Add(this.SaveStyleButton);
            this.StyleListGroup.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleListGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StyleListGroup.Location = new System.Drawing.Point(10, 0);
            this.StyleListGroup.Name = "StyleListGroup";
            this.StyleListGroup.Size = new System.Drawing.Size(329, 482);
            this.StyleListGroup.TabIndex = 28;
            this.StyleListGroup.TabStop = false;
            this.StyleListGroup.Text = "Styles";
            // 
            // DeleteStyleButton
            // 
            this.DeleteStyleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DeleteStyleButton.CurrentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DeleteStyleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteStyleButton.DisabledBackColor = System.Drawing.Color.Gray;
            this.DeleteStyleButton.Enabled = false;
            this.DeleteStyleButton.FlatAppearance.BorderSize = 0;
            this.DeleteStyleButton.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStyleButton.ForeColor = System.Drawing.Color.White;
            this.DeleteStyleButton.Location = new System.Drawing.Point(253, 199);
            this.DeleteStyleButton.Name = "DeleteStyleButton";
            this.DeleteStyleButton.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DeleteStyleButton.OnClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DeleteStyleButton.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DeleteStyleButton.Size = new System.Drawing.Size(68, 25);
            this.DeleteStyleButton.TabIndex = 34;
            this.DeleteStyleButton.Text = "Delete";
            this.DeleteStyleButton.UseVisualStyleBackColor = false;
            this.DeleteStyleButton.Click += new System.EventHandler(this.DeleteStyleButton_Click);
            // 
            // NewStyleButton
            // 
            this.NewStyleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.NewStyleButton.CurrentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.NewStyleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewStyleButton.DisabledBackColor = System.Drawing.Color.Gray;
            this.NewStyleButton.FlatAppearance.BorderSize = 0;
            this.NewStyleButton.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStyleButton.ForeColor = System.Drawing.Color.White;
            this.NewStyleButton.Location = new System.Drawing.Point(253, 24);
            this.NewStyleButton.Name = "NewStyleButton";
            this.NewStyleButton.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.NewStyleButton.OnClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.NewStyleButton.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.NewStyleButton.Size = new System.Drawing.Size(68, 25);
            this.NewStyleButton.TabIndex = 33;
            this.NewStyleButton.Text = "New";
            this.NewStyleButton.UseVisualStyleBackColor = false;
            this.NewStyleButton.Click += new System.EventHandler(this.NewStyleButton_Click);
            // 
            // PasteStyleButton
            // 
            this.PasteStyleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.PasteStyleButton.CurrentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.PasteStyleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasteStyleButton.DisabledBackColor = System.Drawing.Color.Gray;
            this.PasteStyleButton.Enabled = false;
            this.PasteStyleButton.FlatAppearance.BorderSize = 0;
            this.PasteStyleButton.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteStyleButton.ForeColor = System.Drawing.Color.White;
            this.PasteStyleButton.Location = new System.Drawing.Point(253, 164);
            this.PasteStyleButton.Name = "PasteStyleButton";
            this.PasteStyleButton.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.PasteStyleButton.OnClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.PasteStyleButton.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.PasteStyleButton.Size = new System.Drawing.Size(68, 25);
            this.PasteStyleButton.TabIndex = 32;
            this.PasteStyleButton.Text = "Paste";
            this.PasteStyleButton.UseVisualStyleBackColor = false;
            this.PasteStyleButton.Click += new System.EventHandler(this.PasteStyleButton_Click);
            // 
            // CopyStyleButton
            // 
            this.CopyStyleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.CopyStyleButton.CurrentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.CopyStyleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyStyleButton.DisabledBackColor = System.Drawing.Color.Gray;
            this.CopyStyleButton.Enabled = false;
            this.CopyStyleButton.FlatAppearance.BorderSize = 0;
            this.CopyStyleButton.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyStyleButton.ForeColor = System.Drawing.Color.White;
            this.CopyStyleButton.Location = new System.Drawing.Point(253, 129);
            this.CopyStyleButton.Name = "CopyStyleButton";
            this.CopyStyleButton.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.CopyStyleButton.OnClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.CopyStyleButton.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.CopyStyleButton.Size = new System.Drawing.Size(68, 25);
            this.CopyStyleButton.TabIndex = 31;
            this.CopyStyleButton.Text = "Copy";
            this.CopyStyleButton.UseVisualStyleBackColor = false;
            this.CopyStyleButton.Click += new System.EventHandler(this.CopyStyleButton_Click);
            // 
            // RevertStyleButton
            // 
            this.RevertStyleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RevertStyleButton.CurrentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RevertStyleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevertStyleButton.DisabledBackColor = System.Drawing.Color.Gray;
            this.RevertStyleButton.Enabled = false;
            this.RevertStyleButton.FlatAppearance.BorderSize = 0;
            this.RevertStyleButton.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevertStyleButton.ForeColor = System.Drawing.Color.White;
            this.RevertStyleButton.Location = new System.Drawing.Point(253, 94);
            this.RevertStyleButton.Name = "RevertStyleButton";
            this.RevertStyleButton.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RevertStyleButton.OnClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RevertStyleButton.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.RevertStyleButton.Size = new System.Drawing.Size(68, 25);
            this.RevertStyleButton.TabIndex = 30;
            this.RevertStyleButton.Text = "Revert";
            this.RevertStyleButton.UseVisualStyleBackColor = false;
            this.RevertStyleButton.Click += new System.EventHandler(this.RevertStyleButton_Click);
            // 
            // StyleList
            // 
            this.StyleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StyleList.FormattingEnabled = true;
            this.StyleList.IntegralHeight = false;
            this.StyleList.ItemHeight = 20;
            this.StyleList.Location = new System.Drawing.Point(11, 24);
            this.StyleList.Name = "StyleList";
            this.StyleList.Size = new System.Drawing.Size(236, 445);
            this.StyleList.TabIndex = 7;
            this.StyleList.SelectedIndexChanged += new System.EventHandler(this.StyleList_SelectedIndexChanged);
            // 
            // SaveStyleButton
            // 
            this.SaveStyleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.SaveStyleButton.CurrentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.SaveStyleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveStyleButton.DisabledBackColor = System.Drawing.Color.Gray;
            this.SaveStyleButton.Enabled = false;
            this.SaveStyleButton.FlatAppearance.BorderSize = 0;
            this.SaveStyleButton.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveStyleButton.ForeColor = System.Drawing.Color.White;
            this.SaveStyleButton.Location = new System.Drawing.Point(253, 59);
            this.SaveStyleButton.Name = "SaveStyleButton";
            this.SaveStyleButton.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.SaveStyleButton.OnClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.SaveStyleButton.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.SaveStyleButton.Size = new System.Drawing.Size(68, 25);
            this.SaveStyleButton.TabIndex = 29;
            this.SaveStyleButton.Text = "Save";
            this.SaveStyleButton.UseVisualStyleBackColor = false;
            this.SaveStyleButton.Click += new System.EventHandler(this.SaveStyleButton_Click);
            // 
            // SettingsContent
            // 
            this.SettingsContent.BackColor = System.Drawing.Color.Transparent;
            this.SettingsContent.Controls.Add(this.label1);
            this.SettingsContent.Location = new System.Drawing.Point(0, 0);
            this.SettingsContent.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsContent.Name = "SettingsContent";
            this.SettingsContent.Size = new System.Drawing.Size(776, 490);
            this.SettingsContent.TabIndex = 0;
            this.SettingsContent.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // ReduceButton
            // 
            this.ReduceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.ReduceButton.CurrentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.ReduceButton.DisabledBackColor = System.Drawing.Color.Gray;
            this.ReduceButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F);
            this.ReduceButton.ForeColor = System.Drawing.Color.White;
            this.ReduceButton.Location = new System.Drawing.Point(704, 0);
            this.ReduceButton.Name = "ReduceButton";
            this.ReduceButton.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.ReduceButton.OnClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.ReduceButton.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.ReduceButton.Size = new System.Drawing.Size(48, 24);
            this.ReduceButton.TabIndex = 6;
            this.ReduceButton.Text = "_";
            this.ReduceButton.UseVisualStyleBackColor = false;
            this.ReduceButton.Click += new System.EventHandler(this.ReduceButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton.CurrentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton.DisabledBackColor = System.Drawing.Color.Gray;
            this.CloseButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(752, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton.OnClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton.Size = new System.Drawing.Size(48, 24);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.ReduceButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MainWindowContainer);
            this.Controls.Add(this.MainWindowTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoE Easy Mapping";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainWindowTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPlayer)).EndInit();
            this.TrayMenuStrip.ResumeLayout(false);
            this.MainWindowContainer.ResumeLayout(false);
            this.TabsContainer.ResumeLayout(false);
            this.TabContentContainer.ResumeLayout(false);
            this.StylesContent.ResumeLayout(false);
            this.SelectedStyleEditor.ResumeLayout(false);
            this.SampleContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SampleSockets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePicture)).EndInit();
            this.BackgroundGroup.ResumeLayout(false);
            this.BackgroundColor.ResumeLayout(false);
            this.BackgroundColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundAlphaTextBox)).EndInit();
            this.BorderGroup.ResumeLayout(false);
            this.BorderColor.ResumeLayout(false);
            this.BorderColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorderAlphaTextBox)).EndInit();
            this.TextGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeTextBox)).EndInit();
            this.FontColor.ResumeLayout(false);
            this.FontColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontAlphaTextBox)).EndInit();
            this.OtherGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChangeVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeBeamButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeIconButton)).EndInit();
            this.StyleListGroup.ResumeLayout(false);
            this.SettingsContent.ResumeLayout(false);
            this.SettingsContent.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private void NormalizeFont()
        {
            this.MainWindowTitle.Font = new Font(StaticLibrary.GetMainFont(), this.MainWindowTitle.Font.Size, this.MainWindowTitle.Font.Style, this.MainWindowTitle.Font.Unit);
            this.ReduceButton.Font = new Font(StaticLibrary.GetMainFont(), this.ReduceButton.Font.Size, this.ReduceButton.Font.Style, this.ReduceButton.Font.Unit);
            this.CloseButton.Font = new Font(StaticLibrary.GetMainFont(), this.CloseButton.Font.Size, this.CloseButton.Font.Style, this.CloseButton.Font.Unit);
            this.SettingsTab.Font = new Font(StaticLibrary.GetMainFont(), this.SettingsTab.Font.Size, this.SettingsTab.Font.Style, this.SettingsTab.Font.Unit);
            this.StylesTab.Font = new Font(StaticLibrary.GetMainFont(), this.StylesTab.Font.Size, this.StylesTab.Font.Style, this.StylesTab.Font.Unit);
            this.SampleText.Font = new Font(StaticLibrary.GetMainFont(), this.SampleText.Font.Size, this.SampleText.Font.Style, this.SampleText.Font.Unit );
            this.StyleList.Font = new Font(StaticLibrary.GetMainFont(), this.StyleList.Font.Size, this.StyleList.Font.Style, this.StyleList.Font.Unit);

            
        }

        private System.Windows.Forms.Panel MainWindowTitleBar;
        private System.Windows.Forms.Label MainWindowTitle;
        private FlatButton CloseButton;
        private FlatButton ReduceButton;
        private System.Windows.Forms.NotifyIcon TrayBarIcon;
        private System.Windows.Forms.ContextMenuStrip TrayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TrayMenuItem_Exit;
        private System.Windows.Forms.Panel MainWindowContainer;
        private FlatTab SettingsTab;
        private System.Windows.Forms.Panel TabContentContainer;
        private System.Windows.Forms.Panel TabsContainer;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer TabsRectangle;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape TabsRectangleShape;
        private FlatTab StylesTab;
        private System.Windows.Forms.Panel SettingsContent;
        private System.Windows.Forms.Panel StylesContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SamplePicture;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer SampleRectContainer;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape SampleRect;
        private System.Windows.Forms.Panel SampleContent;
        private AlphaLabel SampleText;
        private Slider TrackBarFontSize;
        private Slider TrackBarFontAlpha;
        private System.Windows.Forms.ListBox StyleList;
        private System.Windows.Forms.GroupBox TextGroup;
        private System.Windows.Forms.Label FontSizeLabel;
        private System.Windows.Forms.Label FontAlphaLabel;
        private System.Windows.Forms.Label FontColorLabel;
        private System.Windows.Forms.TextBox FontColorTextBox;
        private FlatButton TextColorPicker;
        private FlatButton SetTextColor2;
        private FlatButton SetTextColor5;
        private FlatButton SetTextColor4;
        private FlatButton SetTextColor3;
        private FlatButton SetTextColor1;
        private System.Windows.Forms.NumericUpDown FontSizeTextBox;
        private System.Windows.Forms.NumericUpDown FontAlphaTextBox;
        private AlphaLabel FontColorHashtag;
        private System.Windows.Forms.Panel FontColor;
        private FlatButton SetTextColor7;
        private FlatButton SetTextColor6;
        private System.Windows.Forms.GroupBox BorderGroup;
        private FlatButton SetBorderColor7;
        private FlatButton SetBorderColor6;
        private System.Windows.Forms.Panel BorderColor;
        private System.Windows.Forms.TextBox BorderColorTextBox;
        private AlphaLabel BorderColorHashtag;
        private System.Windows.Forms.NumericUpDown BorderAlphaTextBox;
        private FlatButton BorderColorPicker;
        private FlatButton SetBorderColor2;
        private FlatButton SetBorderColor5;
        private FlatButton SetBorderColor4;
        private FlatButton SetBorderColor3;
        private FlatButton SetBorderColor1;
        private System.Windows.Forms.Label BorderAlphaLabel;
        private System.Windows.Forms.Label BorderColorLabel;
        private Slider TrackBarBorderAlpha;
        private System.Windows.Forms.GroupBox BackgroundGroup;
        private FlatButton SetBackgroundColor7;
        private FlatButton SetBackgroundColor6;
        private System.Windows.Forms.Panel BackgroundColor;
        private System.Windows.Forms.TextBox BackgroundColorTextBox;
        private AlphaLabel BackgroundColorHashtag;
        private System.Windows.Forms.NumericUpDown BackgroundAlphaTextBox;
        private FlatButton BackgroundColorPicker;
        private FlatButton SetBackgroundColor2;
        private FlatButton SetBackgroundColor5;
        private FlatButton SetBackgroundColor4;
        private FlatButton SetBackgroundColor3;
        private FlatButton SetBackgroundColor1;
        private System.Windows.Forms.Label BackgroundAlphaLabel;
        private System.Windows.Forms.Label BackgroundColorLabel;
        private Slider TrackBarBackgroundAlpha;
        private System.Windows.Forms.GroupBox StyleListGroup;
        private FlatButton RevertStyleButton;
        private FlatButton SaveStyleButton;
        private System.Windows.Forms.GroupBox OtherGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox SampleSockets;
        private System.Windows.Forms.ComboBox ChangeSoundDropdown;
        private System.Windows.Forms.PictureBox ChangeBeamButton;
        private System.Windows.Forms.PictureBox ChangeIconButton;
        private FlatButton PasteStyleButton;
        private FlatButton CopyStyleButton;
        private FlatButton SetTextColor8;
        private FlatButton SetBorderColor8;
        private FlatButton SetBackgroundColor8;
        private AxWMPLib.AxWindowsMediaPlayer BackgroundPlayer;
        private System.Windows.Forms.PictureBox ChangeVolume;
        private System.Windows.Forms.Panel SelectedStyleEditor;
        private FlatButton NewStyleButton;
        private FlatButton DeleteStyleButton;
    }
}


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
            this.SampleContent = new System.Windows.Forms.Panel();
            this.SampleText = new PoE_Easy_Mapping.AlphaLabel();
            this.SampleRectContainer = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SampleRect = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SamplePicture = new System.Windows.Forms.PictureBox();
            this.TrackBarAlpha = new System.Windows.Forms.TrackBar();
            this.SettingsContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ReduceButton = new PoE_Easy_Mapping.FlatButton();
            this.CloseButton = new PoE_Easy_Mapping.FlatButton();
            this.TrackBarSize = new System.Windows.Forms.TrackBar();
            this.MainWindowTitleBar.SuspendLayout();
            this.TrayMenuStrip.SuspendLayout();
            this.MainWindowContainer.SuspendLayout();
            this.TabsContainer.SuspendLayout();
            this.TabContentContainer.SuspendLayout();
            this.StylesContent.SuspendLayout();
            this.SampleContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAlpha)).BeginInit();
            this.SettingsContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSize)).BeginInit();
            this.SuspendLayout();
            // 
            // MainWindowTitleBar
            // 
            this.MainWindowTitleBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.MainWindowTitleBar.Controls.Add(this.MainWindowTitle);
            this.MainWindowTitleBar.Location = new System.Drawing.Point(0, 0);
            this.MainWindowTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.MainWindowTitleBar.Name = "MainWindowTitleBar";
            this.MainWindowTitleBar.Size = new System.Drawing.Size(800, 200);
            this.MainWindowTitleBar.TabIndex = 3;
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
            this.SettingsTab.ActiveBackColor = System.Drawing.Color.DodgerBlue;
            this.SettingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.SettingsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SettingsTab.ForeColor = System.Drawing.Color.White;
            this.SettingsTab.Location = new System.Drawing.Point(10, 0);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.SettingsTab.OnClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.SettingsTab.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.SettingsTab.Size = new System.Drawing.Size(120, 35);
            this.SettingsTab.TabIndex = 0;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = false;
            this.SettingsTab.Click += new System.EventHandler(this.SettingsTab_Click);
            // 
            // StylesTab
            // 
            this.StylesTab.ActiveBackColor = System.Drawing.Color.DodgerBlue;
            this.StylesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.StylesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.StylesTab.ForeColor = System.Drawing.Color.White;
            this.StylesTab.Location = new System.Drawing.Point(135, 0);
            this.StylesTab.Name = "StylesTab";
            this.StylesTab.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.StylesTab.OnClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.StylesTab.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
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
            this.TabsRectangleShape.BorderColor = System.Drawing.Color.Transparent;
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
            this.StylesContent.Controls.Add(this.TrackBarSize);
            this.StylesContent.Controls.Add(this.SampleContent);
            this.StylesContent.Controls.Add(this.TrackBarAlpha);
            this.StylesContent.Location = new System.Drawing.Point(0, 0);
            this.StylesContent.Margin = new System.Windows.Forms.Padding(0);
            this.StylesContent.Name = "StylesContent";
            this.StylesContent.Size = new System.Drawing.Size(776, 490);
            this.StylesContent.TabIndex = 0;
            this.StylesContent.Visible = false;
            // 
            // SampleContent
            // 
            this.SampleContent.Controls.Add(this.SampleText);
            this.SampleContent.Controls.Add(this.SampleRectContainer);
            this.SampleContent.Controls.Add(this.SamplePicture);
            this.SampleContent.Location = new System.Drawing.Point(343, 6);
            this.SampleContent.Name = "SampleContent";
            this.SampleContent.Size = new System.Drawing.Size(430, 150);
            this.SampleContent.TabIndex = 3;
            // 
            // SampleText
            // 
            this.SampleText.BackColor = System.Drawing.Color.SteelBlue;
            this.SampleText.Font = new System.Drawing.Font("Fontin SmallCaps", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SampleText.ForeColor = System.Drawing.Color.White;
            this.SampleText.Location = new System.Drawing.Point(42, 47);
            this.SampleText.Margin = new System.Windows.Forms.Padding(0);
            this.SampleText.Name = "SampleText";
            this.SampleText.Size = new System.Drawing.Size(346, 56);
            this.SampleText.TabIndex = 4;
            this.SampleText.Text = "Exalted Orb";
            this.SampleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SampleRectContainer
            // 
            this.SampleRectContainer.Location = new System.Drawing.Point(0, 0);
            this.SampleRectContainer.Margin = new System.Windows.Forms.Padding(0);
            this.SampleRectContainer.Name = "SampleRectContainer";
            this.SampleRectContainer.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.SampleRect});
            this.SampleRectContainer.Size = new System.Drawing.Size(430, 150);
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
            this.SampleRect.Location = new System.Drawing.Point(40, 45);
            this.SampleRect.Name = "SampleRect";
            this.SampleRect.Size = new System.Drawing.Size(350, 60);
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
            // TrackBarAlpha
            // 
            this.TrackBarAlpha.LargeChange = 17;
            this.TrackBarAlpha.Location = new System.Drawing.Point(183, 429);
            this.TrackBarAlpha.Margin = new System.Windows.Forms.Padding(0);
            this.TrackBarAlpha.Maximum = 255;
            this.TrackBarAlpha.Name = "TrackBarAlpha";
            this.TrackBarAlpha.Size = new System.Drawing.Size(429, 45);
            this.TrackBarAlpha.TabIndex = 1;
            this.TrackBarAlpha.Scroll += new System.EventHandler(this.TrackBarAlpha_Scroll);
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
            // TrackBarSize
            // 
            this.TrackBarSize.LargeChange = 4;
            this.TrackBarSize.Location = new System.Drawing.Point(183, 363);
            this.TrackBarSize.Margin = new System.Windows.Forms.Padding(0);
            this.TrackBarSize.Maximum = 45;
            this.TrackBarSize.Minimum = 18;
            this.TrackBarSize.Name = "TrackBarSize";
            this.TrackBarSize.Size = new System.Drawing.Size(429, 45);
            this.TrackBarSize.TabIndex = 4;
            this.TrackBarSize.Value = 18;
            this.TrackBarSize.Scroll += new System.EventHandler(this.TrackBarSize_Scroll);
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
            this.TrayMenuStrip.ResumeLayout(false);
            this.MainWindowContainer.ResumeLayout(false);
            this.TabsContainer.ResumeLayout(false);
            this.TabContentContainer.ResumeLayout(false);
            this.StylesContent.ResumeLayout(false);
            this.StylesContent.PerformLayout();
            this.SampleContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SamplePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAlpha)).EndInit();
            this.SettingsContent.ResumeLayout(false);
            this.SettingsContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void NormalizeFont()
        {
            this.MainWindowTitle.Font = new Font(Pfc.Families[0], this.MainWindowTitle.Font.Size, this.MainWindowTitle.Font.Style, this.MainWindowTitle.Font.Unit);
            this.ReduceButton.Font = new Font(Pfc.Families[0], this.ReduceButton.Font.Size, this.ReduceButton.Font.Style, this.ReduceButton.Font.Unit);
            this.CloseButton.Font = new Font(Pfc.Families[0], this.CloseButton.Font.Size, this.CloseButton.Font.Style, this.CloseButton.Font.Unit);
            this.SettingsTab.Font = new Font(Pfc.Families[0], this.SettingsTab.Font.Size, this.SettingsTab.Font.Style, this.SettingsTab.Font.Unit);
            this.StylesTab.Font = new Font(Pfc.Families[0], this.StylesTab.Font.Size, this.StylesTab.Font.Style, this.StylesTab.Font.Unit);
            this.SampleText.Font = new Font(Pfc.Families[0], this.SampleText.Font.Size, this.SampleText.Font.Style, this.SampleText.Font.Unit );
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
        private System.Windows.Forms.TrackBar TrackBarAlpha;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer SampleRectContainer;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape SampleRect;
        private System.Windows.Forms.Panel SampleContent;
        private AlphaLabel SampleText;
        private System.Windows.Forms.TrackBar TrackBarSize;
    }
}


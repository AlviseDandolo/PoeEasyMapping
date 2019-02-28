namespace PoE_Easy_Mapping
{
    partial class SaveStylePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.NewStyleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ErrorRect = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SaveNewStyleAs = new PoE_Easy_Mapping.FlatButton();
            this.OutsidePanel = new PoE_Easy_Mapping.TransparentPanel();
            this.ActionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionPanel
            // 
            this.ActionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ActionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActionPanel.Controls.Add(this.NewStyleName);
            this.ActionPanel.Controls.Add(this.shapeContainer1);
            this.ActionPanel.Controls.Add(this.SaveNewStyleAs);
            this.ActionPanel.Controls.Add(this.label1);
            this.ActionPanel.Location = new System.Drawing.Point(254, 187);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(268, 115);
            this.ActionPanel.TabIndex = 33;
            this.ActionPanel.Visible = false;
            // 
            // NewStyleName
            // 
            this.NewStyleName.Font = new System.Drawing.Font("Fontin SmallCaps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStyleName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NewStyleName.Location = new System.Drawing.Point(10, 40);
            this.NewStyleName.Margin = new System.Windows.Forms.Padding(0);
            this.NewStyleName.Name = "NewStyleName";
            this.NewStyleName.Size = new System.Drawing.Size(246, 25);
            this.NewStyleName.TabIndex = 1;
            this.NewStyleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewStyleName.Enter += new System.EventHandler(NewStyleName_Enter);
            this.NewStyleName.Leave += new System.EventHandler(NewStyleName_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Fontin SmallCaps", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save new style as:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ErrorRect});
            this.shapeContainer1.Size = new System.Drawing.Size(266, 113);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // ErrorRect
            // 
            this.ErrorRect.BackColor = System.Drawing.Color.Red;
            this.ErrorRect.BorderColor = System.Drawing.Color.Red;
            this.ErrorRect.BorderWidth = 4;
            this.ErrorRect.FillColor = System.Drawing.Color.Red;
            this.ErrorRect.Location = new System.Drawing.Point(8, 38);
            this.ErrorRect.Name = "ErrorRect";
            this.ErrorRect.Size = new System.Drawing.Size(250, 29);
            this.ErrorRect.Visible = false;
            // 
            // SaveNewStyleAs
            // 
            this.SaveNewStyleAs.BackColor = System.Drawing.Color.DodgerBlue;
            this.SaveNewStyleAs.CurrentBackColor = System.Drawing.Color.DodgerBlue;
            this.SaveNewStyleAs.DisabledBackColor = System.Drawing.Color.Gray;
            this.SaveNewStyleAs.Font = new System.Drawing.Font("Fontin SmallCaps", 12F);
            this.SaveNewStyleAs.ForeColor = System.Drawing.Color.White;
            this.SaveNewStyleAs.Location = new System.Drawing.Point(93, 75);
            this.SaveNewStyleAs.Name = "SaveNewStyleAs";
            this.SaveNewStyleAs.NormalBackColor = System.Drawing.Color.DodgerBlue;
            this.SaveNewStyleAs.OnClickBackColor = System.Drawing.Color.DarkOrchid;
            this.SaveNewStyleAs.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.SaveNewStyleAs.Size = new System.Drawing.Size(85, 25);
            this.SaveNewStyleAs.TabIndex = 2;
            this.SaveNewStyleAs.Text = "Save";
            this.SaveNewStyleAs.UseVisualStyleBackColor = false;
            this.SaveNewStyleAs.Click += new System.EventHandler(this.SaveNewStyleAs_Click);
            // 
            // OutsidePanel
            // 
            this.OutsidePanel.BackColor = System.Drawing.Color.Transparent;
            this.OutsidePanel.Location = new System.Drawing.Point(0, 0);
            this.OutsidePanel.Name = "OutsidePanel";
            this.OutsidePanel.Size = new System.Drawing.Size(776, 490);
            this.OutsidePanel.TabIndex = 34;
            this.OutsidePanel.Click += new System.EventHandler(this.OutsidePanel_Click);
            // 
            // SaveStylePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.OutsidePanel);
            this.Name = "SaveStylePanel";
            this.Size = new System.Drawing.Size(776, 490);
            this.ActionPanel.ResumeLayout(false);
            this.ActionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentPanel OutsidePanel;
        private System.Windows.Forms.Panel ActionPanel;
        private System.Windows.Forms.TextBox NewStyleName;
        private System.Windows.Forms.Label label1;
        private FlatButton SaveNewStyleAs;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape ErrorRect;
    }
}

namespace Gui_Malve
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Currency"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sell 1C"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "1"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "2"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "3"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "4"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.flatButton3 = new Gui_Malve.FlatButton();
            this.flatButton2 = new Gui_Malve.FlatButton();
            this.flatButton1 = new Gui_Malve.FlatButton();
            this.flatButton4 = new Gui_Malve.FlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 600);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rectangleShape3.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.rectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape3.Location = new System.Drawing.Point(20, 71);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(759, 12);
            this.rectangleShape3.Click += new System.EventHandler(this.rectangleShape3_Click);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.rectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape2.Location = new System.Drawing.Point(20, 70);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(760, 510);
            this.rectangleShape2.Click += new System.EventHandler(this.rectangleShape2_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(118)))));
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.Location = new System.Drawing.Point(0, 200);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(800, 400);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(9, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fast Mapping";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.listView1.CheckBoxes = true;
            this.listView1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Gray;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(30, 130);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(192, 440);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tab List";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.flatButton3.ForeColor = System.Drawing.Color.White;
            this.flatButton3.Location = new System.Drawing.Point(754, 90);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.NormalBackColor = System.Drawing.Color.DodgerBlue;
            this.flatButton3.OnClickBackColor = System.Drawing.Color.DarkOrchid;
            this.flatButton3.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.flatButton3.Size = new System.Drawing.Size(20, 20);
            this.flatButton3.TabIndex = 6;
            this.flatButton3.Text = "?";
            this.flatButton3.UseVisualStyleBackColor = true;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.flatButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.flatButton2.Location = new System.Drawing.Point(111, 60);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.flatButton2.OnClickBackColor = System.Drawing.Color.DarkOrchid;
            this.flatButton2.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.flatButton2.Size = new System.Drawing.Size(75, 23);
            this.flatButton2.TabIndex = 3;
            this.flatButton2.Text = "Set Counter";
            this.flatButton2.UseVisualStyleBackColor = false;
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.flatButton1.ForeColor = System.Drawing.Color.Gray;
            this.flatButton1.Location = new System.Drawing.Point(30, 60);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.flatButton1.OnClickBackColor = System.Drawing.Color.LightBlue;
            this.flatButton1.OnHoverBackColor = System.Drawing.Color.Navy;
            this.flatButton1.Size = new System.Drawing.Size(75, 23);
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Text = "Settings";
            this.flatButton1.UseVisualStyleBackColor = false;
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.flatButton4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.flatButton4.FlatAppearance.BorderSize = 5;
            this.flatButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.flatButton4.Location = new System.Drawing.Point(147, 105);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.flatButton4.OnClickBackColor = System.Drawing.Color.DarkOrchid;
            this.flatButton4.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.flatButton4.Size = new System.Drawing.Size(75, 23);
            this.flatButton4.TabIndex = 7;
            this.flatButton4.Text = "Update";
            this.flatButton4.UseVisualStyleBackColor = false;
            this.flatButton4.Click += new System.EventHandler(this.flatButton4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(238, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flatButton4);
            this.Controls.Add(this.flatButton3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.flatButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatButton flatButton1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private FlatButton flatButton2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private FlatButton flatButton3;
        private FlatButton flatButton4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


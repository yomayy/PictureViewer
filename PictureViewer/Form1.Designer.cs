namespace PictureViewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_item = new System.Windows.Forms.ToolStripMenuItem();
            this.Close_item = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_item = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Author_item = new System.Windows.Forms.ToolStripMenuItem();
            this.Program_item = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Guide_item = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Delay = new System.Windows.Forms.NumericUpDown();
            this.Reset_but = new System.Windows.Forms.Button();
            this.Stop_but = new System.Windows.Forms.Button();
            this.Start_but = new System.Windows.Forms.Button();
            this.Forw_button = new System.Windows.Forms.Button();
            this.Backward_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_item,
            this.Close_item,
            this.Exit_item});
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.folderToolStripMenuItem.Text = "&Folder";
            // 
            // Open_item
            // 
            this.Open_item.Name = "Open_item";
            this.Open_item.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Open_item.Size = new System.Drawing.Size(173, 26);
            this.Open_item.Text = "&Open";
            this.Open_item.Click += new System.EventHandler(this.Open_item_Click);
            // 
            // Close_item
            // 
            this.Close_item.Name = "Close_item";
            this.Close_item.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.Close_item.Size = new System.Drawing.Size(173, 26);
            this.Close_item.Text = "&Close";
            this.Close_item.Click += new System.EventHandler(this.Close_item_Click);
            // 
            // Exit_item
            // 
            this.Exit_item.Name = "Exit_item";
            this.Exit_item.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Exit_item.Size = new System.Drawing.Size(173, 26);
            this.Exit_item.Text = "&Exit";
            this.Exit_item.Click += new System.EventHandler(this.Exit_item_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Author_item,
            this.Program_item});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // Author_item
            // 
            this.Author_item.Name = "Author_item";
            this.Author_item.Size = new System.Drawing.Size(141, 26);
            this.Author_item.Text = "&Author";
            // 
            // Program_item
            // 
            this.Program_item.Name = "Program_item";
            this.Program_item.Size = new System.Drawing.Size(141, 26);
            this.Program_item.Text = "&Program";
            this.Program_item.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Guide_item});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // Guide_item
            // 
            this.Guide_item.Name = "Guide_item";
            this.Guide_item.Size = new System.Drawing.Size(123, 26);
            this.Guide_item.Text = "&Guide";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileListBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 397);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FileList";
            // 
            // FileListBox
            // 
            this.FileListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileListBox.FormattingEnabled = true;
            this.FileListBox.ItemHeight = 25;
            this.FileListBox.Location = new System.Drawing.Point(3, 26);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.ScrollAlwaysVisible = true;
            this.FileListBox.Size = new System.Drawing.Size(267, 368);
            this.FileListBox.TabIndex = 0;
            this.FileListBox.SelectedIndexChanged += new System.EventHandler(this.FileListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delay);
            this.groupBox2.Controls.Add(this.Reset_but);
            this.groupBox2.Controls.Add(this.Stop_but);
            this.groupBox2.Controls.Add(this.Start_but);
            this.groupBox2.Controls.Add(this.Forw_button);
            this.groupBox2.Controls.Add(this.Backward_button);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(273, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // Delay
            // 
            this.Delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delay.Location = new System.Drawing.Point(599, 53);
            this.Delay.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(120, 38);
            this.Delay.TabIndex = 5;
            this.Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Delay.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Delay.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Reset_but
            // 
            this.Reset_but.Location = new System.Drawing.Point(474, 50);
            this.Reset_but.Name = "Reset_but";
            this.Reset_but.Size = new System.Drawing.Size(88, 46);
            this.Reset_but.TabIndex = 4;
            this.Reset_but.Text = "Reset";
            this.Reset_but.UseVisualStyleBackColor = true;
            this.Reset_but.Click += new System.EventHandler(this.Reset_but_Click);
            // 
            // Stop_but
            // 
            this.Stop_but.Location = new System.Drawing.Point(380, 50);
            this.Stop_but.Name = "Stop_but";
            this.Stop_but.Size = new System.Drawing.Size(88, 46);
            this.Stop_but.TabIndex = 3;
            this.Stop_but.Text = "Stop";
            this.Stop_but.UseVisualStyleBackColor = true;
            this.Stop_but.Click += new System.EventHandler(this.Stop_but_Click);
            // 
            // Start_but
            // 
            this.Start_but.Location = new System.Drawing.Point(286, 50);
            this.Start_but.Name = "Start_but";
            this.Start_but.Size = new System.Drawing.Size(88, 46);
            this.Start_but.TabIndex = 2;
            this.Start_but.Text = "Start";
            this.Start_but.UseVisualStyleBackColor = true;
            this.Start_but.Click += new System.EventHandler(this.Start_but_Click);
            // 
            // Forw_button
            // 
            this.Forw_button.Location = new System.Drawing.Point(111, 50);
            this.Forw_button.Name = "Forw_button";
            this.Forw_button.Size = new System.Drawing.Size(88, 46);
            this.Forw_button.TabIndex = 1;
            this.Forw_button.Text = ">>>";
            this.Forw_button.UseVisualStyleBackColor = true;
            this.Forw_button.Click += new System.EventHandler(this.Forw_button_Click);
            // 
            // Backward_button
            // 
            this.Backward_button.Location = new System.Drawing.Point(17, 50);
            this.Backward_button.Name = "Backward_button";
            this.Backward_button.Size = new System.Drawing.Size(88, 46);
            this.Backward_button.TabIndex = 0;
            this.Backward_button.Text = "<<<";
            this.Backward_button.UseVisualStyleBackColor = true;
            this.Backward_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Canvas);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(273, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(746, 263);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // Canvas
            // 
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Image = global::PictureViewer.Properties.Resources.unnamed_768x768;
            this.Canvas.Location = new System.Drawing.Point(3, 26);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(740, 234);
            this.Canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Click += new System.EventHandler(this.Canvas_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 425);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Viewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_item;
        private System.Windows.Forms.ToolStripMenuItem Close_item;
        private System.Windows.Forms.ToolStripMenuItem Exit_item;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Author_item;
        private System.Windows.Forms.ToolStripMenuItem Program_item;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Guide_item;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox FileListBox;
        private System.Windows.Forms.NumericUpDown Delay;
        private System.Windows.Forms.Button Reset_but;
        private System.Windows.Forms.Button Stop_but;
        private System.Windows.Forms.Button Start_but;
        private System.Windows.Forms.Button Forw_button;
        private System.Windows.Forms.Button Backward_button;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace Shapes
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vertexesColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linesColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.innerAreaColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShapeSelectionComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.vertexRadiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopButton = new System.Windows.Forms.ToolStripMenuItem();
            this.playButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.SettingsMenuItem,
            this.stopButton,
            this.playButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1633, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Menu";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.vertexRadiusToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(61, 20);
            this.SettingsMenuItem.Text = "Settings";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vertexesColorToolStripMenuItem,
            this.linesColorToolStripMenuItem,
            this.innerAreaColorToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.colorToolStripMenuItem.Text = "Color...";
            // 
            // vertexesColorToolStripMenuItem
            // 
            this.vertexesColorToolStripMenuItem.Name = "vertexesColorToolStripMenuItem";
            this.vertexesColorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.vertexesColorToolStripMenuItem.Text = "Vertexes color...";
            this.vertexesColorToolStripMenuItem.Click += new System.EventHandler(this.vertexesColorToolStripMenuItem_Click);
            // 
            // linesColorToolStripMenuItem
            // 
            this.linesColorToolStripMenuItem.Name = "linesColorToolStripMenuItem";
            this.linesColorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.linesColorToolStripMenuItem.Text = "Lines color...";
            this.linesColorToolStripMenuItem.Click += new System.EventHandler(this.linesColorToolStripMenuItem_Click);
            // 
            // innerAreaColorToolStripMenuItem
            // 
            this.innerAreaColorToolStripMenuItem.Name = "innerAreaColorToolStripMenuItem";
            this.innerAreaColorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.innerAreaColorToolStripMenuItem.Text = "Inner area color...";
            this.innerAreaColorToolStripMenuItem.Click += new System.EventHandler(this.innerAreaColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShapeSelectionComboBox});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "Select shape...";
            // 
            // ShapeSelectionComboBox
            // 
            this.ShapeSelectionComboBox.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Triangle"});
            this.ShapeSelectionComboBox.Name = "ShapeSelectionComboBox";
            this.ShapeSelectionComboBox.Size = new System.Drawing.Size(121, 23);
            this.ShapeSelectionComboBox.Text = "Circle";
            // 
            // vertexRadiusToolStripMenuItem
            // 
            this.vertexRadiusToolStripMenuItem.Name = "vertexRadiusToolStripMenuItem";
            this.vertexRadiusToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.vertexRadiusToolStripMenuItem.Text = "Vertex radius";
            this.vertexRadiusToolStripMenuItem.Click += new System.EventHandler(this.vertexRadiusToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::Shapes.Properties.Resources.icons8_save_as_96;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Shapes.Properties.Resources.icons8_new_file_96;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Shapes.Properties.Resources.icons8_add_file_96;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Shapes.Properties.Resources.icons8_save_96;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // stopButton
            // 
            this.stopButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stopButton.Enabled = false;
            this.stopButton.Image = global::Shapes.Properties.Resources.icons8_stop_96;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(28, 20);
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playButton
            // 
            this.playButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.playButton.Enabled = false;
            this.playButton.Image = global::Shapes.Properties.Resources.icons8_play_96;
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(28, 20);
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1633, 661);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Polygons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vertexesColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linesColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem innerAreaColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox ShapeSelectionComboBox;
        private System.Windows.Forms.ToolStripMenuItem playButton;
        private System.Windows.Forms.ToolStripMenuItem stopButton;
        private System.Windows.Forms.ToolStripMenuItem vertexRadiusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}


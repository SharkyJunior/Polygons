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
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.SettingsMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1633, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Menu";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
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
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color...";
            // 
            // vertexesColorToolStripMenuItem
            // 
            this.vertexesColorToolStripMenuItem.Name = "vertexesColorToolStripMenuItem";
            this.vertexesColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vertexesColorToolStripMenuItem.Text = "Vertexes color...";
            this.vertexesColorToolStripMenuItem.Click += new System.EventHandler(this.vertexesColorToolStripMenuItem_Click);
            // 
            // linesColorToolStripMenuItem
            // 
            this.linesColorToolStripMenuItem.Name = "linesColorToolStripMenuItem";
            this.linesColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linesColorToolStripMenuItem.Text = "Lines color...";
            this.linesColorToolStripMenuItem.Click += new System.EventHandler(this.linesColorToolStripMenuItem_Click);
            // 
            // innerAreaColorToolStripMenuItem
            // 
            this.innerAreaColorToolStripMenuItem.Name = "innerAreaColorToolStripMenuItem";
            this.innerAreaColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.innerAreaColorToolStripMenuItem.Text = "Inner area color...";
            this.innerAreaColorToolStripMenuItem.Click += new System.EventHandler(this.innerAreaColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShapeSelectionComboBox});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
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
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 661);
            this.Controls.Add(this.menuStrip);
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
    }
}


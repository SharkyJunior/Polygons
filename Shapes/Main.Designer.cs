﻿namespace Shapes
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vertexesColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linesColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.innerAreaColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vertexRadiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.convexHullAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithmByDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grahamScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.playButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.algorithmComparisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.SettingsMenuItem,
            this.algorithmComparisonToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(887, 24);
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
            this.FileMenuItem.Size = new System.Drawing.Size(37, 22);
            this.FileMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Shapes.Properties.Resources.icons8_new_file_96;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Shapes.Properties.Resources.icons8_add_file_96;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Shapes.Properties.Resources.icons8_save_96;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::Shapes.Properties.Resources.icons8_save_as_96;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.vertexRadiusToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.convexHullAlgorithmToolStripMenuItem});
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(61, 22);
            this.SettingsMenuItem.Text = "Settings";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vertexesColorToolStripMenuItem,
            this.linesColorToolStripMenuItem,
            this.innerAreaColorToolStripMenuItem});
            this.colorToolStripMenuItem.Image = global::Shapes.Properties.Resources.icons8_paint_palette_96;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
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
            // vertexRadiusToolStripMenuItem
            // 
            this.vertexRadiusToolStripMenuItem.Image = global::Shapes.Properties.Resources.icons8_radius_96;
            this.vertexRadiusToolStripMenuItem.Name = "vertexRadiusToolStripMenuItem";
            this.vertexRadiusToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.vertexRadiusToolStripMenuItem.Text = "Vertex radius";
            this.vertexRadiusToolStripMenuItem.Click += new System.EventHandler(this.vertexRadiusToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circleToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.triangleToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::Shapes.Properties.Resources.icons8_shape_96;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 38);
            this.toolStripMenuItem1.Text = "Select shape...";
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Checked = true;
            this.circleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.circleToolStripMenuItem.Image = global::Shapes.Properties.Resources.icons8_circle_96;
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Image = global::Shapes.Properties.Resources.icons8_maximize_button_96;
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Image = global::Shapes.Properties.Resources.icons8_triangle_96;
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // convexHullAlgorithmToolStripMenuItem
            // 
            this.convexHullAlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algorithmByDefinitionToolStripMenuItem,
            this.grahamScanToolStripMenuItem});
            this.convexHullAlgorithmToolStripMenuItem.Name = "convexHullAlgorithmToolStripMenuItem";
            this.convexHullAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.convexHullAlgorithmToolStripMenuItem.Text = " Convex Hull Algorithm...";
            // 
            // algorithmByDefinitionToolStripMenuItem
            // 
            this.algorithmByDefinitionToolStripMenuItem.Name = "algorithmByDefinitionToolStripMenuItem";
            this.algorithmByDefinitionToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.algorithmByDefinitionToolStripMenuItem.Text = "Algorithm by Definition";
            this.algorithmByDefinitionToolStripMenuItem.Click += new System.EventHandler(this.algorithmByDefinitionToolStripMenuItem_Click);
            // 
            // grahamScanToolStripMenuItem
            // 
            this.grahamScanToolStripMenuItem.Checked = true;
            this.grahamScanToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.grahamScanToolStripMenuItem.Name = "grahamScanToolStripMenuItem";
            this.grahamScanToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.grahamScanToolStripMenuItem.Text = "Graham Scan";
            this.grahamScanToolStripMenuItem.Click += new System.EventHandler(this.grahamScanToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playButton,
            this.stopButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(887, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // playButton
            // 
            this.playButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playButton.Enabled = false;
            this.playButton.Image = global::Shapes.Properties.Resources.icons8_play_96;
            this.playButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(36, 36);
            this.playButton.Text = "playButton";
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopButton.Enabled = false;
            this.stopButton.Image = global::Shapes.Properties.Resources.icons8_stop_96;
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(36, 36);
            this.stopButton.Text = "stopButton";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // algorithmComparisonToolStripMenuItem
            // 
            this.algorithmComparisonToolStripMenuItem.Name = "algorithmComparisonToolStripMenuItem";
            this.algorithmComparisonToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.algorithmComparisonToolStripMenuItem.Text = "Algorithm Comparison";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(887, 378);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Polygons";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem vertexRadiusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton playButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem convexHullAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorithmByDefinitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grahamScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorithmComparisonToolStripMenuItem;
    }
}


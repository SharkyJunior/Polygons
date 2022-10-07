namespace Shapes
{
    partial class RadiusSliderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadiusSliderForm));
            this.radiusTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // radiusTrackBar
            // 
            this.radiusTrackBar.Location = new System.Drawing.Point(24, 23);
            this.radiusTrackBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radiusTrackBar.Maximum = 30;
            this.radiusTrackBar.Minimum = 5;
            this.radiusTrackBar.Name = "radiusTrackBar";
            this.radiusTrackBar.Size = new System.Drawing.Size(414, 90);
            this.radiusTrackBar.TabIndex = 0;
            this.radiusTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.radiusTrackBar.Value = 5;
            this.radiusTrackBar.ValueChanged += new System.EventHandler(this.radiusTrackBar_ValueChanged);
            this.radiusTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radiusTrackBar_MouseUp);
            // 
            // RadiusSliderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 115);
            this.Controls.Add(this.radiusTrackBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "RadiusSliderForm";
            this.Text = "Radius";
            this.Load += new System.EventHandler(this.RadiusSliderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TrackBar radiusTrackBar;
    }
}
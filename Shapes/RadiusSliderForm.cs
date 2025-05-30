﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class RadiusSliderForm : Form
    {
        private Main mainForm = null;
        public int vertexRadius;
        
        public RadiusSliderForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }

        public RadiusSliderForm(Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            
        }

        private void RadiusSliderForm_Load(object sender, EventArgs e)
        {
            radiusTrackBar.Value = mainForm.vertexRadius;
        }

        private void radiusTrackBar_ValueChanged(object sender, EventArgs e)
        {
            mainForm.vertexRadius = radiusTrackBar.Value;
            mainForm.Refresh();
        }

        private void radiusTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (vertexRadius != radiusTrackBar.Value)
                mainForm.SaveCurrentState();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Shapes
{
    public partial class ComparisonChartForm : Form
    {
        public ComparisonChartForm()
        {
            InitializeComponent();
        }

        private void ComparisonChartForm_Load(object sender, EventArgs e)
        {
            comparisonChart.Series.Clear();

            Series defSeries = new Series{ 
                Name = "Algorithm by definition", 
                Color = Color.Blue, 
                ChartType = SeriesChartType.Line
            };
            Series grahamSeries = new Series{
                Name = "Graham Scan",
                Color = Color.Red, 
                ChartType = SeriesChartType.Line
            };

            comparisonChart.Series.Add(defSeries);
            comparisonChart.Series.Add(grahamSeries);


        }
    }
}

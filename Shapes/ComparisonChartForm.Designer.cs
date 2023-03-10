namespace Shapes
{
    partial class ComparisonChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comparisonChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // comparisonChart
            // 
            this.comparisonChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.Title = "Points Count";
            chartArea3.AxisY.Title = "Time (ms)";
            chartArea3.Name = "ChartArea1";
            this.comparisonChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.comparisonChart.Legends.Add(legend3);
            this.comparisonChart.Location = new System.Drawing.Point(12, 12);
            this.comparisonChart.Name = "comparisonChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.comparisonChart.Series.Add(series3);
            this.comparisonChart.Size = new System.Drawing.Size(776, 426);
            this.comparisonChart.TabIndex = 0;
            this.comparisonChart.Text = "Comparison";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(780, 323);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // ComparisonChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.comparisonChart);
            this.Name = "ComparisonChartForm";
            this.Text = "Algorithm Comparison Chart";
            this.Load += new System.EventHandler(this.ComparisonChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comparisonChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart comparisonChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}
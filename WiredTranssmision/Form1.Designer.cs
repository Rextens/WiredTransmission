
namespace WiredTranssmision
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Spectrum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FunctionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Spectrum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Spectrum
            // 
            chartArea1.AxisX.Interval = 100D;
            chartArea1.Name = "ChartArea1";
            this.Spectrum.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Spectrum.Legends.Add(legend1);
            this.Spectrum.Location = new System.Drawing.Point(12, 296);
            this.Spectrum.Name = "Spectrum";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.Spectrum.Series.Add(series1);
            this.Spectrum.Size = new System.Drawing.Size(614, 306);
            this.Spectrum.TabIndex = 0;
            this.Spectrum.Text = "chart1";
            this.Spectrum.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseWheel);
            // 
            // FunctionChart
            // 
            chartArea2.Name = "ChartArea1";
            this.FunctionChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.FunctionChart.Legends.Add(legend2);
            this.FunctionChart.Location = new System.Drawing.Point(25, 12);
            this.FunctionChart.Name = "FunctionChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.FunctionChart.Series.Add(series2);
            this.FunctionChart.Size = new System.Drawing.Size(601, 278);
            this.FunctionChart.TabIndex = 1;
            this.FunctionChart.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 625);
            this.Controls.Add(this.FunctionChart);
            this.Controls.Add(this.Spectrum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Spectrum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Spectrum;
        private System.Windows.Forms.DataVisualization.Charting.Chart FunctionChart;
    }
}


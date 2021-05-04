
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Spectrum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FunctionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Spectrum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Spectrum
            // 
            chartArea5.AxisX.Interval = 100D;
            chartArea5.Name = "ChartArea1";
            this.Spectrum.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.Spectrum.Legends.Add(legend5);
            this.Spectrum.Location = new System.Drawing.Point(12, 296);
            this.Spectrum.Name = "Spectrum";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.Spectrum.Series.Add(series5);
            this.Spectrum.Size = new System.Drawing.Size(614, 306);
            this.Spectrum.TabIndex = 0;
            this.Spectrum.Text = "chart1";
            this.Spectrum.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseWheel);
            // 
            // FunctionChart
            // 
            chartArea6.Name = "ChartArea1";
            this.FunctionChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.FunctionChart.Legends.Add(legend6);
            this.FunctionChart.Location = new System.Drawing.Point(598, 308);
            this.FunctionChart.Name = "FunctionChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.FunctionChart.Series.Add(series6);
            this.FunctionChart.Size = new System.Drawing.Size(565, 278);
            this.FunctionChart.TabIndex = 1;
            this.FunctionChart.Text = "chart2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 155);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 625);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FunctionChart);
            this.Controls.Add(this.Spectrum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Spectrum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Spectrum;
        private System.Windows.Forms.DataVisualization.Charting.Chart FunctionChart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}


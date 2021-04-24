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
using AForge.Math;
using System.Runtime.InteropServices;

namespace WiredTranssmision
{
    public partial class Form1 : Form
    {
        List<double> spectrumXValues = new List<double>();
        List<double> spectrumYValues = new List<double>();

        List<double> functionXValues = new List<double>();
        List<double> functionYValues = new List<double>();

        public Form1()
        {
            InitializeComponent();

            this.MouseWheel += new MouseEventHandler(chart1_MouseWheel);

            double func(double t)
            {
                return 10 * Math.Sin(200 * Math.PI * t) + 10 * Math.Sin(800 * Math.PI * t) + 10 * Math.Sin(2000 * Math.PI * t);
                //return 10 * Math.Sin(100 * t) + 10 * Math.Sin(400 * t) + 10 * Math.Sin(1000 * t);
                /*
                if(Math.Sin(t * Math.PI * 2) > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
                */

                //return 10 * Math.Sin(t * Math.PI * 200);
            }


            //FOURIER

            const double period = 1.0/100.0;
            const double intervals = 1;
            const int howMany = 2048;

            Complex[] data = new Complex[howMany];

            for (int i = 0; i < howMany; ++i)
            {
                double functionResult = func(period * intervals * (i / Convert.ToDouble(howMany)));
                data[i] = new Complex(functionResult, 0);
            }

            for (double i = period / 100; i < period * intervals; i += period / 100)
            {
                functionYValues.Add(func(i));
                functionXValues.Add(i);
            }

            FourierTransform.DFT(data, FourierTransform.Direction.Forward);

            double[] bins = new double[howMany];

            double maxBin = 0;

            for (int i = 0; i < howMany; ++i)
            {
                bins[i] = Math.Sqrt(data[i].Re * data[i].Re + data[i].Im * data[i].Im);

                if (bins[i] > maxBin)
                {
                    maxBin = bins[i];
                }
            }

            double sr = howMany / (period * intervals);

            for (int i = 1; i < 100; ++i)
            {
                spectrumYValues.Add(bins[i] * 2);
                spectrumXValues.Add((double)i * sr / howMany);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Spectrum.Series["Series1"].Points.DataBindXY(spectrumXValues, spectrumYValues);
            Spectrum.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            // Spectrum.ChartAreas[0].AxisX.Interval = 0;
            FunctionChart.Series["Series1"].Points.DataBindXY(functionXValues, functionYValues);
        }

        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                Spectrum.ChartAreas[0].AxisX.Interval += 1;
            }
            else if (e.Delta < 0)
            {
                if (Spectrum.ChartAreas[0].AxisX.Interval - 1.0 > 0)
                {
                    Spectrum.ChartAreas[0].AxisX.Interval -= 1;
                }
            }
        }
    }
}

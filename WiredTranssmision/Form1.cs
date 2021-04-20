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
using Extreme.Mathematics;
using Extreme.Mathematics.SignalProcessing;

namespace WiredTranssmision
{
    public partial class Form1 : Form
    {
      

        List<double> xValues = new List<double>();
        List<double> yValues = new List<double>();

        public Form1()
        {
            InitializeComponent();

            this.MouseWheel += new MouseEventHandler(chart1_MouseWheel);

            const double period = Math.PI * 2;
            const double intervals = 3;
            const int howMany = 512;

            double func(double t)
            {
                //return 10 * Math.Sin(200 * Math.PI * t) + 10 * Math.Sin(800 * Math.PI * t) + 10 * Math.Sin(2000 * Math.PI * t);
                return Math.Sin(t * Math.PI * 2);
            }

            Complex[] data = new Complex[howMany];

            for (int i = 0; i < howMany; ++i)
            {
                data[i] = new Complex(func(period * intervals * (i / Convert.ToDouble(howMany))), 0);
            }

            FourierTransform.DFT(data, FourierTransform.Direction.Forward);

            double[] bins = new double[howMany];

            double maxBin = 0;

            for (int i = 0; i < howMany; ++i)
            {
                bins[i] = Math.Sqrt(data[i].Re * data[i].Re + data[i].Im * data[i].Im);

                if(bins[i] > maxBin)
                {
                    maxBin = bins[i];
              }
            }

            double fs = 0.5 / (maxBin * 2);
            double sr = howMany / (period * intervals);

            for (int i = 0; i < howMany / 2; ++i)
            {
                yValues.Add(bins[i] * 2);
                //yValues.Add(Math.Atan2(data[i].Re, data[i].Im));
                //xValues.Add(i * 200);
                xValues.Add((double)i * sr / howMany);
                //xValues.Add(i);
            }  
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
        }

        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hewwo :3");
        }
    }
}

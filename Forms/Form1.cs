using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Forms
{
    public partial class Form1 : Form
    {
        private Thread cpuThread;
        private double[] cpuArray = new double[60];
        //Random rd;
        public Form1()
        {
            InitializeComponent();
        }

        //Thread thread;
        //public void creatThread()
        //{
        //    rd = new Random();
        //    thread = new Thread(t =>
        //    {
        //        while (true)
        //        {
        //            int width = rd.Next(0, this.Width);
        //            int height = rd.Next(50, this.Height);
        //            this.CreateGraphics().DrawEllipse(new Pen(Brushes.Red, 1), new Rectangle(width, height, 10, 10));
        //            Delay
        //            Thread.Sleep(100);
        //        }
        //    })
        //    {
        //        IsBackground = true
        //    };
        //}
        private void btnThread1_Click(object sender, EventArgs e)
        {
            cpuThread = new Thread(new ThreadStart(this.getPerfomanceCounters));
            cpuThread.IsBackground = true;
            cpuThread.Start();
            //creatThread();
            //if (thread.ThreadState != ThreadState.Running)
            //{
            //    thread.Start();
            //}
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnThread2_Click(object sender, EventArgs e)
        {
            if ((cpuThread != null))
            {
                if (cpuThread.ThreadState != System.Threading.ThreadState.Aborted)
                {
                    cpuThread.Abort();
                }
            }
        }
        private void getPerfomanceCounters()
        {
            var cpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);
                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);
                if (cpuChart1.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCpuChart1(); });
                }
                else
                {

                }
                Thread.Sleep(500);
            }
        }

        private void UpdateCpuChart1()
        {
            cpuChart1.Series["% in used"].Points.Clear();
            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                cpuChart1.Series["% in used"].Points.AddY(cpuArray[i]);

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}

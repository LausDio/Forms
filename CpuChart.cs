namespace Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;

    public partial class Form1 : Form
    {
        private Thread cpuThread;
        private Thread cpuThread2;
        private Thread cpuThread3;
        private Thread cpuThread4;
        private double[] cpuArray = new double[60];

        public Form1()
        {
            InitializeComponent();
        }

        private void GetPerfomanceCounters(object sender)
        {
            var chart = sender as Chart;
            var cpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);
                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);
                if (cpuChart1.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCpuChart1(chart); });
                }

                Thread.Sleep(200);
            }
        }

        private void UpdateCpuChart1(object sender)
        {
            var chart = sender as Chart;
            chart.Series["% in used"].Points.Clear();
            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                chart.Series["% in used"].Points.AddY(cpuArray[i]);
            }
        }

        private void Start1_Click(object sender, EventArgs e)
        {
            if (cpuThread == null || cpuThread.ThreadState == System.Threading.ThreadState.Aborted)
            {
                cpuThread = new Thread(() => this.GetPerfomanceCounters(cpuChart1));
                cpuThread.IsBackground = true;
                cpuThread.Start();
            }
        }

        private void Start2_Click(object sender, EventArgs e)
        {
            if (cpuThread2 == null || cpuThread2.ThreadState == System.Threading.ThreadState.Aborted)
            {
                cpuThread2 = new Thread(() => this.GetPerfomanceCounters(cpuChart2));
                cpuThread2.IsBackground = true;
                cpuThread2.Start();
            }
        }

        private void Start3_Click(object sender, EventArgs e)
        {
            if (cpuThread3 == null || cpuThread3.ThreadState == System.Threading.ThreadState.Aborted)
            {
                cpuThread3 = new Thread(() => this.GetPerfomanceCounters(cpuChart3));
                cpuThread3.IsBackground = true;
                cpuThread3.Start();
            }
        }

        private void Start4_Click(object sender, EventArgs e)
        {
            if (cpuThread4 == null || cpuThread4.ThreadState == System.Threading.ThreadState.Aborted)
            {
                cpuThread4 = new Thread(() => this.GetPerfomanceCounters(cpuChart4));
                cpuThread4.IsBackground = true;
                cpuThread4.Start();
            }
        }

        private void Stop1_Click(object sender, EventArgs e)
        {
            if (cpuThread != null && cpuThread.ThreadState != System.Threading.ThreadState.Aborted)
            {
                cpuThread.Abort();
            }
        }

        private void Stop2_Click(object sender, EventArgs e)
        {
            if (cpuThread2 != null && cpuThread2.ThreadState != System.Threading.ThreadState.Aborted)
            {
                cpuThread2.Abort();
            }
        }

        private void Stop3_Click(object sender, EventArgs e)
        {
            if (cpuThread3 != null && cpuThread3.ThreadState != System.Threading.ThreadState.Aborted)
            {
                cpuThread3.Abort();
            }
        }

        private void Stop4_Click(object sender, EventArgs e)
        {
            if (cpuThread4 != null && cpuThread4.ThreadState != System.Threading.ThreadState.Aborted)
            {
                cpuThread4.Abort();
            }
        }
    }
}

namespace Forms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnThread1 = new System.Windows.Forms.Button();
            this.btnThread2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cpuChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuChart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuChart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThread1
            // 
            this.btnThread1.Location = new System.Drawing.Point(12, 12);
            this.btnThread1.Name = "btnThread1";
            this.btnThread1.Size = new System.Drawing.Size(228, 32);
            this.btnThread1.TabIndex = 0;
            this.btnThread1.Text = "Start Thread";
            this.btnThread1.UseVisualStyleBackColor = true;
            this.btnThread1.Click += new System.EventHandler(this.btnThread1_Click);
            // 
            // btnThread2
            // 
            this.btnThread2.Location = new System.Drawing.Point(12, 50);
            this.btnThread2.Name = "btnThread2";
            this.btnThread2.Size = new System.Drawing.Size(228, 32);
            this.btnThread2.TabIndex = 1;
            this.btnThread2.Text = "Stop Thread";
            this.btnThread2.UseVisualStyleBackColor = true;
            this.btnThread2.Click += new System.EventHandler(this.btnThread2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Thread";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnThread1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop Thread";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnThread2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(655, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 32);
            this.button3.TabIndex = 0;
            this.button3.Text = "Start Thread";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnThread1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(655, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(228, 32);
            this.button4.TabIndex = 1;
            this.button4.Text = "Stop Thread";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnThread2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(996, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(228, 32);
            this.button5.TabIndex = 0;
            this.button5.Text = "Start Thread";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnThread1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(996, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(228, 32);
            this.button6.TabIndex = 1;
            this.button6.Text = "Stop Thread";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnThread2_Click);
            // 
            // cpuChart1
            // 
            chartArea1.Name = "ChartArea1";
            this.cpuChart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cpuChart1.Legends.Add(legend1);
            this.cpuChart1.Location = new System.Drawing.Point(12, 88);
            this.cpuChart1.Name = "cpuChart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "% in used";
            this.cpuChart1.Series.Add(series1);
            this.cpuChart1.Size = new System.Drawing.Size(228, 300);
            this.cpuChart1.TabIndex = 2;
            this.cpuChart1.Text = "cpuChart1";
            this.cpuChart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // cpuChart2
            // 
            chartArea2.Name = "ChartArea1";
            this.cpuChart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cpuChart2.Legends.Add(legend2);
            this.cpuChart2.Location = new System.Drawing.Point(308, 88);
            this.cpuChart2.Name = "cpuChart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "% in used";
            this.cpuChart2.Series.Add(series2);
            this.cpuChart2.Size = new System.Drawing.Size(228, 300);
            this.cpuChart2.TabIndex = 2;
            this.cpuChart2.Text = "cpuChart1";
            this.cpuChart2.Click += new System.EventHandler(this.chart1_Click);
            // 
            // cpuChart3
            // 
            chartArea3.Name = "ChartArea1";
            this.cpuChart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cpuChart3.Legends.Add(legend3);
            this.cpuChart3.Location = new System.Drawing.Point(655, 88);
            this.cpuChart3.Name = "cpuChart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "% in used";
            this.cpuChart3.Series.Add(series3);
            this.cpuChart3.Size = new System.Drawing.Size(228, 300);
            this.cpuChart3.TabIndex = 2;
            this.cpuChart3.Text = "cpuChart1";
            this.cpuChart3.Click += new System.EventHandler(this.chart1_Click);
            // 
            // cpuChart4
            // 
            chartArea4.Name = "ChartArea1";
            this.cpuChart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.cpuChart4.Legends.Add(legend4);
            this.cpuChart4.Location = new System.Drawing.Point(996, 88);
            this.cpuChart4.Name = "cpuChart4";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "% in used";
            this.cpuChart4.Series.Add(series4);
            this.cpuChart4.Size = new System.Drawing.Size(228, 300);
            this.cpuChart4.TabIndex = 2;
            this.cpuChart4.Text = "cpuChart1";
            this.cpuChart4.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 400);
            this.Controls.Add(this.cpuChart4);
            this.Controls.Add(this.cpuChart3);
            this.Controls.Add(this.cpuChart2);
            this.Controls.Add(this.cpuChart1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnThread2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThread1);
            this.Name = "Form1";
            this.Text = "Forms with threads";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThread1;
        private System.Windows.Forms.Button btnThread2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart4;
    }
}


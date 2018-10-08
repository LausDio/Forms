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
            this.Start1 = new System.Windows.Forms.Button();
            this.Stop1 = new System.Windows.Forms.Button();
            this.cpuChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuChart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuChart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Start2 = new System.Windows.Forms.Button();
            this.Stop2 = new System.Windows.Forms.Button();
            this.Start3 = new System.Windows.Forms.Button();
            this.Stop3 = new System.Windows.Forms.Button();
            this.Start4 = new System.Windows.Forms.Button();
            this.Stop4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart4)).BeginInit();
            this.SuspendLayout();
            // 
            // Start1
            // 
            this.Start1.Location = new System.Drawing.Point(12, 14);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(353, 32);
            this.Start1.TabIndex = 0;
            this.Start1.Text = "Start Thread";
            this.Start1.UseVisualStyleBackColor = true;
            this.Start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // Stop1
            // 
            this.Stop1.Location = new System.Drawing.Point(12, 52);
            this.Stop1.Name = "Stop1";
            this.Stop1.Size = new System.Drawing.Size(353, 32);
            this.Stop1.TabIndex = 1;
            this.Stop1.Text = "Stop Thread";
            this.Stop1.UseVisualStyleBackColor = true;
            this.Stop1.Click += new System.EventHandler(this.Stop1_Click);
            // 
            // cpuChart1
            // 
            chartArea1.Name = "ChartArea1";
            this.cpuChart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cpuChart1.Legends.Add(legend1);
            this.cpuChart1.Location = new System.Drawing.Point(12, 90);
            this.cpuChart1.Name = "cpuChart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "% in used";
            this.cpuChart1.Series.Add(series1);
            this.cpuChart1.Size = new System.Drawing.Size(353, 538);
            this.cpuChart1.TabIndex = 2;
            this.cpuChart1.Text = "cpuChart1";
            // 
            // cpuChart2
            // 
            chartArea2.Name = "ChartArea1";
            this.cpuChart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cpuChart2.Legends.Add(legend2);
            this.cpuChart2.Location = new System.Drawing.Point(371, 90);
            this.cpuChart2.Name = "cpuChart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "% in used";
            this.cpuChart2.Series.Add(series2);
            this.cpuChart2.Size = new System.Drawing.Size(353, 538);
            this.cpuChart2.TabIndex = 2;
            this.cpuChart2.Text = "cpuChart2";
            // 
            // cpuChart3
            // 
            chartArea3.Name = "ChartArea1";
            this.cpuChart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cpuChart3.Legends.Add(legend3);
            this.cpuChart3.Location = new System.Drawing.Point(730, 90);
            this.cpuChart3.Name = "cpuChart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "% in used";
            this.cpuChart3.Series.Add(series3);
            this.cpuChart3.Size = new System.Drawing.Size(353, 538);
            this.cpuChart3.TabIndex = 2;
            this.cpuChart3.Text = "cpuChart3";
            // 
            // cpuChart4
            // 
            chartArea4.Name = "ChartArea1";
            this.cpuChart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.cpuChart4.Legends.Add(legend4);
            this.cpuChart4.Location = new System.Drawing.Point(1089, 90);
            this.cpuChart4.Name = "cpuChart4";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "% in used";
            this.cpuChart4.Series.Add(series4);
            this.cpuChart4.Size = new System.Drawing.Size(353, 538);
            this.cpuChart4.TabIndex = 2;
            this.cpuChart4.Text = "cpuChart4";
            // 
            // Start2
            // 
            this.Start2.Location = new System.Drawing.Point(371, 14);
            this.Start2.Name = "Start2";
            this.Start2.Size = new System.Drawing.Size(353, 32);
            this.Start2.TabIndex = 3;
            this.Start2.Text = "Start Thread";
            this.Start2.UseVisualStyleBackColor = true;
            this.Start2.Click += new System.EventHandler(this.Start2_Click);
            // 
            // Stop2
            // 
            this.Stop2.Location = new System.Drawing.Point(371, 52);
            this.Stop2.Name = "Stop2";
            this.Stop2.Size = new System.Drawing.Size(353, 32);
            this.Stop2.TabIndex = 4;
            this.Stop2.Text = "Stop Thread";
            this.Stop2.UseVisualStyleBackColor = true;
            this.Stop2.Click += new System.EventHandler(this.Stop2_Click);
            // 
            // Start3
            // 
            this.Start3.Location = new System.Drawing.Point(730, 14);
            this.Start3.Name = "Start3";
            this.Start3.Size = new System.Drawing.Size(353, 32);
            this.Start3.TabIndex = 5;
            this.Start3.Text = "Start Thread";
            this.Start3.UseVisualStyleBackColor = true;
            this.Start3.Click += new System.EventHandler(this.Start3_Click);
            // 
            // Stop3
            // 
            this.Stop3.Location = new System.Drawing.Point(730, 52);
            this.Stop3.Name = "Stop3";
            this.Stop3.Size = new System.Drawing.Size(353, 32);
            this.Stop3.TabIndex = 6;
            this.Stop3.Text = "Stop Thread";
            this.Stop3.UseVisualStyleBackColor = true;
            this.Stop3.Click += new System.EventHandler(this.Stop3_Click);
            // 
            // Start4
            // 
            this.Start4.Location = new System.Drawing.Point(1089, 14);
            this.Start4.Name = "Start4";
            this.Start4.Size = new System.Drawing.Size(353, 32);
            this.Start4.TabIndex = 7;
            this.Start4.Text = "Start Thread";
            this.Start4.UseVisualStyleBackColor = true;
            this.Start4.Click += new System.EventHandler(this.Start4_Click);
            // 
            // Stop4
            // 
            this.Stop4.Location = new System.Drawing.Point(1089, 52);
            this.Stop4.Name = "Stop4";
            this.Stop4.Size = new System.Drawing.Size(353, 32);
            this.Stop4.TabIndex = 8;
            this.Stop4.Text = "Stop Thread";
            this.Stop4.UseVisualStyleBackColor = true;
            this.Stop4.Click += new System.EventHandler(this.Stop4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 654);
            this.Controls.Add(this.Stop4);
            this.Controls.Add(this.Start4);
            this.Controls.Add(this.Stop3);
            this.Controls.Add(this.Start3);
            this.Controls.Add(this.Stop2);
            this.Controls.Add(this.Start2);
            this.Controls.Add(this.cpuChart4);
            this.Controls.Add(this.cpuChart3);
            this.Controls.Add(this.cpuChart2);
            this.Controls.Add(this.cpuChart1);
            this.Controls.Add(this.Stop1);
            this.Controls.Add(this.Start1);
            this.Name = "Form1";
            this.Text = "Forms with threads";
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start1;
        private System.Windows.Forms.Button Stop1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart4;
        private System.Windows.Forms.Button Start2;
        private System.Windows.Forms.Button Stop2;
        private System.Windows.Forms.Button Start3;
        private System.Windows.Forms.Button Stop3;
        private System.Windows.Forms.Button Start4;
        private System.Windows.Forms.Button Stop4;
    }
}


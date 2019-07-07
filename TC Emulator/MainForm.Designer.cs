namespace TC_Emulator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EmuLenBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SamplingCountBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StartBtn = new System.Windows.Forms.Button();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PPGLB = new System.Windows.Forms.Label();
            this.GCDLB = new System.Windows.Forms.Label();
            this.TotalPTCLB = new System.Windows.Forms.Label();
            this.TotalGCDLB = new System.Windows.Forms.Label();
            this.TotalHCLB = new System.Windows.Forms.Label();
            this.TotalTCLB = new System.Windows.Forms.Label();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // EmuLenBox
            // 
            this.EmuLenBox.Location = new System.Drawing.Point(235, 579);
            this.EmuLenBox.Name = "EmuLenBox";
            this.EmuLenBox.Size = new System.Drawing.Size(100, 33);
            this.EmuLenBox.TabIndex = 1;
            this.EmuLenBox.Text = "1000";
            this.EmuLenBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emulation Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sample size";
            // 
            // SamplingCountBox
            // 
            this.SamplingCountBox.Location = new System.Drawing.Point(573, 579);
            this.SamplingCountBox.Name = "SamplingCountBox";
            this.SamplingCountBox.Size = new System.Drawing.Size(100, 33);
            this.SamplingCountBox.TabIndex = 1;
            this.SamplingCountBox.Text = "50";
            this.SamplingCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(40, 485);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(787, 25);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 6;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(721, 579);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(106, 32);
            this.StartBtn.TabIndex = 7;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusLabel.Location = new System.Drawing.Point(302, 529);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(242, 30);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Waiting For Params";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PPGLB
            // 
            this.PPGLB.AutoSize = true;
            this.PPGLB.Location = new System.Drawing.Point(380, 430);
            this.PPGLB.Name = "PPGLB";
            this.PPGLB.Size = new System.Drawing.Size(106, 27);
            this.PPGLB.TabIndex = 10;
            this.PPGLB.Text = "AvgPPG:0";
            this.PPGLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GCDLB
            // 
            this.GCDLB.AutoSize = true;
            this.GCDLB.Location = new System.Drawing.Point(685, 430);
            this.GCDLB.Name = "GCDLB";
            this.GCDLB.Size = new System.Drawing.Size(117, 27);
            this.GCDLB.TabIndex = 11;
            this.GCDLB.Text = "Exp. GCD:0";
            this.GCDLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalPTCLB
            // 
            this.TotalPTCLB.AutoSize = true;
            this.TotalPTCLB.Location = new System.Drawing.Point(380, 386);
            this.TotalPTCLB.Name = "TotalPTCLB";
            this.TotalPTCLB.Size = new System.Drawing.Size(105, 27);
            this.TotalPTCLB.TabIndex = 12;
            this.TotalPTCLB.Text = "TotalPtc:0";
            this.TotalPTCLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalGCDLB
            // 
            this.TotalGCDLB.AutoSize = true;
            this.TotalGCDLB.Location = new System.Drawing.Point(685, 386);
            this.TotalGCDLB.Name = "TotalGCDLB";
            this.TotalGCDLB.Size = new System.Drawing.Size(119, 27);
            this.TotalGCDLB.TabIndex = 12;
            this.TotalGCDLB.Text = "TotalGCD:0";
            this.TotalGCDLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalHCLB
            // 
            this.TotalHCLB.AutoSize = true;
            this.TotalHCLB.Location = new System.Drawing.Point(51, 386);
            this.TotalHCLB.Name = "TotalHCLB";
            this.TotalHCLB.Size = new System.Drawing.Size(104, 27);
            this.TotalHCLB.TabIndex = 13;
            this.TotalHCLB.Text = "TotalHC:0";
            // 
            // TotalTCLB
            // 
            this.TotalTCLB.AutoSize = true;
            this.TotalTCLB.Location = new System.Drawing.Point(51, 430);
            this.TotalTCLB.Name = "TotalTCLB";
            this.TotalTCLB.Size = new System.Drawing.Size(100, 27);
            this.TotalTCLB.TabIndex = 13;
            this.TotalTCLB.Text = "TotalTC:0";
            // 
            // MainChart
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Name = "Legend1";
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(56, 12);
            this.MainChart.Name = "MainChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "PPG";
            this.MainChart.Series.Add(series1);
            this.MainChart.Size = new System.Drawing.Size(771, 357);
            this.MainChart.TabIndex = 14;
            this.MainChart.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 650);
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.TotalTCLB);
            this.Controls.Add(this.TotalHCLB);
            this.Controls.Add(this.TotalGCDLB);
            this.Controls.Add(this.TotalPTCLB);
            this.Controls.Add(this.GCDLB);
            this.Controls.Add(this.PPGLB);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SamplingCountBox);
            this.Controls.Add(this.EmuLenBox);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "ThunderCloud Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EmuLenBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SamplingCountBox;
        private System.Windows.Forms.Button StartBtn;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer RefreshTimer;
        public System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label PPGLB;
        private System.Windows.Forms.Label GCDLB;
        private System.Windows.Forms.Label TotalPTCLB;
        private System.Windows.Forms.Label TotalGCDLB;
        private System.Windows.Forms.Label TotalHCLB;
        private System.Windows.Forms.Label TotalTCLB;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
    }
}


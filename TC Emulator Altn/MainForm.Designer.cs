﻿namespace TC_Emulator_Altn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RepeatBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StartBtn = new System.Windows.Forms.Button();
            this.AvgPtcLB = new System.Windows.Forms.Label();
            this.ExpGCDLB = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.ThreadSet = new System.Windows.Forms.NumericUpDown();
            this.ProgressLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadSet)).BeginInit();
            this.SuspendLayout();
            // 
            // RepeatBox
            // 
            this.RepeatBox.Location = new System.Drawing.Point(129, 81);
            this.RepeatBox.Name = "RepeatBox";
            this.RepeatBox.Size = new System.Drawing.Size(100, 33);
            this.RepeatBox.TabIndex = 0;
            this.RepeatBox.Text = "1000";
            this.RepeatBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Repeat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Times";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 125);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 24);
            this.progressBar1.TabIndex = 3;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(338, 78);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(112, 33);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.Text = "Calculate";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // AvgPtcLB
            // 
            this.AvgPtcLB.AutoSize = true;
            this.AvgPtcLB.Location = new System.Drawing.Point(45, 184);
            this.AvgPtcLB.Name = "AvgPtcLB";
            this.AvgPtcLB.Size = new System.Drawing.Size(123, 27);
            this.AvgPtcLB.TabIndex = 5;
            this.AvgPtcLB.Text = "Avg. PPG: 0";
            // 
            // ExpGCDLB
            // 
            this.ExpGCDLB.AutoSize = true;
            this.ExpGCDLB.Location = new System.Drawing.Point(306, 184);
            this.ExpGCDLB.Name = "ExpGCDLB";
            this.ExpGCDLB.Size = new System.Drawing.Size(123, 27);
            this.ExpGCDLB.TabIndex = 6;
            this.ExpGCDLB.Text = "Exp. GCD: 0";
            this.ExpGCDLB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thread";
            // 
            // ThreadSet
            // 
            this.ThreadSet.Location = new System.Drawing.Point(129, 21);
            this.ThreadSet.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.ThreadSet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThreadSet.Name = "ThreadSet";
            this.ThreadSet.Size = new System.Drawing.Size(120, 33);
            this.ThreadSet.TabIndex = 8;
            this.ThreadSet.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // ProgressLB
            // 
            this.ProgressLB.Location = new System.Drawing.Point(149, 152);
            this.ProgressLB.Name = "ProgressLB";
            this.ProgressLB.Size = new System.Drawing.Size(200, 27);
            this.ProgressLB.TabIndex = 9;
            this.ProgressLB.Text = "0/0";
            this.ProgressLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 231);
            this.Controls.Add(this.ProgressLB);
            this.Controls.Add(this.ThreadSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExpGCDLB);
            this.Controls.Add(this.AvgPtcLB);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RepeatBox);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "TC Emulator Altn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ThreadSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RepeatBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label AvgPtcLB;
        private System.Windows.Forms.Label ExpGCDLB;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ThreadSet;
        private System.Windows.Forms.Label ProgressLB;
    }
}


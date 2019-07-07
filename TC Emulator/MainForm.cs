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

namespace TC_Emulator
{

    public partial class MainForm : Form
    {
        
        bool NeedRefresh = true;

        Bot bot;

        public MainForm()
        {
            InitializeComponent();
        }

        public void debug(int i)
        {
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            
            StartBtn.Enabled = false;
            progressBar1.Value = 0;
            NeedRefresh = true;

            try
            {
                if (SamplingCountBox.Text == "0" || EmuLenBox.Text == "0") throw new Exception();
                bot = new Bot(Convert.ToInt64(EmuLenBox.Text) * 1000, Convert.ToInt32(SamplingCountBox.Text), progressBar1);
                Thread T = new Thread(StartEmulate);
                T.Start();
            }
            catch
            {
                MessageBox.Show("Params Error", "Critical Overflow Bug", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StartBtn.Enabled = true;
            }
        }

        private void StartEmulate()
        {
            bot.Engage();
        }

        private void UpdateData()
        {
            StatusLabel.Text = "Complete";
            StatusLabel.ForeColor = Color.Green;
            
            Sample s = bot.samples[bot.samples.Count - 1];
            double avgppg = (double)s.TotalPTC / (s.CountTC + s.CountHC);
            double expgcd = (s.CountTC + s.CountHC) / (double)s.CountHC;

            TotalHCLB.Text ="TotalHC: "+Convert.ToString( s.CountHC);
            TotalTCLB.Text = "TotalTC: " + Convert.ToString(s.CountTC);
            TotalPTCLB.Text = "TotalPtc: " + Convert.ToString(s.TotalPTC);
            TotalGCDLB.Text = "TotalGCD: " + Convert.ToString(s.CountTC+ s.CountHC);
            PPGLB.Text = "AvgPPG: " + Convert.ToString(Math.Round( avgppg,2));
            GCDLB.Text = "Exp.GCD: " + Convert.ToString(Math.Round(expgcd,2));

            UpdateChart();

            StartBtn.Enabled = true;
            NeedRefresh = false;
        }

        private void UpdateChart()
        {
            MainChart.Series[0].Points.Clear();
            foreach (Sample s in bot.samples)
            {
                MainChart.Series[0].Points.AddXY(s.TimeStamp / 1000, (double)s.TotalPTC / (s.CountTC + s.CountHC));
            }
            
        }


        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 0)
            {
                StatusLabel.Text = "Waiting For Params";
            }
            else if (progressBar1.Value <100)
            {
                StatusLabel.Text = "Calculating...";
                StatusLabel.ForeColor = Color.Red;
            }
            else if ((progressBar1.Value == 100) && NeedRefresh)
            {
                UpdateData();
            }
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

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

namespace TC_Emulator_Altn
{
    public partial class MainForm : Form
    {
        Bot bot = new Bot();

        long LOOP = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Enabled = false;
            progressBar1.Value = 0;
            RefreshTimer.Enabled = true;
            bot.Reset();
            try
            {
                //int divide error
                LOOP = (Convert.ToInt32(RepeatBox.Text) >= 1000)
                    ? Convert.ToInt32(RepeatBox.Text) / (int)ThreadSet.Value * (int)ThreadSet.Value
                    : 1000 / (int)ThreadSet.Value * (int)ThreadSet.Value;


                Thread CalcT = new Thread(MTA);
                CalcT.Start();
            }
            catch
            {
                MessageBox.Show("Params Error", "Critical Overflow Bug", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StartBtn.Enabled = true;
            }
        }

        private void MTA()
        {
            ParallelLoopResult result = Parallel.For(0, (long)ThreadSet.Value, BruteEmulate =>
            {
                for (int p = 0; p < (LOOP / (long)ThreadSet.Value); p++)
                {
                    bot.Engage();
                }
            });

        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            
            

            
            UpdateData();
            
        }

        private void UpdateData()
        {
            double Ptc;
            double GCD;
            long loopcount = Interlocked.Read(ref bot.loopcount);
            long TotalPTC = Interlocked.Read(ref bot.TotalPTC);
            long TotalGCD = Interlocked.Read(ref bot.TotalGCD);

            ProgressLB.Text = string.Format("{0}/{1}", loopcount, LOOP);
            progressBar1.Value = (int)(loopcount * 100 / LOOP);
            if (progressBar1.Value == 100)
            {
                StartBtn.Enabled = true;
            }
            Ptc = (double)TotalPTC / TotalGCD;
            GCD = (double)TotalGCD / loopcount;
            AvgPtcLB.Text = "Avg. PPG: " + Convert.ToString(Math.Round(Ptc, 3));
            ExpGCDLB.Text = "Exp. Gcd: " + Convert.ToString(Math.Round(GCD, 3));
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

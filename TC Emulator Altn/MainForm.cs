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
        Bot bot0;
        Bot bot1;
        Bot bot2;
        Bot bot3;
        Bot bot4;
        Bot bot5;
        Bot bot6;
        Bot bot7;


        bool NeedRefresh = false;
        int Repeat = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Enabled = false;
            progressBar1.Value = 0;
            NeedRefresh = true;
            try
            {
                Repeat = Convert.ToInt32(RepeatBox.Text);
                if (RepeatBox.Text == "0") throw new Exception();

                if (checkMTA.Checked)
                {
                    bot0 = new Bot(Convert.ToInt32(Repeat / 8), progressBar1);
                    bot1 = new Bot(Convert.ToInt32(Repeat / 8), progressBar1);
                    bot2 = new Bot(Convert.ToInt32(Repeat / 8), progressBar1);
                    bot3 = new Bot(Convert.ToInt32(Repeat / 8), progressBar1);
                    bot4 = new Bot(Convert.ToInt32(Repeat / 8), progressBar1);
                    bot5 = new Bot(Convert.ToInt32(Repeat / 8), progressBar1);
                    bot6 = new Bot(Convert.ToInt32(Repeat / 8), progressBar1);
                    bot7 = new Bot(Convert.ToInt32(Repeat / 8), progressBar1);

                    Thread T0 = new Thread(new ParameterizedThreadStart(bot0.StartBruteEmulate));
                    Thread T1 = new Thread(new ParameterizedThreadStart(bot1.StartBruteEmulate));
                    Thread T2 = new Thread(new ParameterizedThreadStart(bot2.StartBruteEmulate));
                    Thread T3 = new Thread(new ParameterizedThreadStart(bot3.StartBruteEmulate));
                    Thread T4 = new Thread(new ParameterizedThreadStart(bot4.StartBruteEmulate));
                    Thread T5 = new Thread(new ParameterizedThreadStart(bot5.StartBruteEmulate));
                    Thread T6 = new Thread(new ParameterizedThreadStart(bot6.StartBruteEmulate));
                    Thread T7 = new Thread(new ParameterizedThreadStart(bot7.StartBruteEmulate));
                    T0.Start(true);
                    T1.Start(false);
                    T2.Start(false);
                    T3.Start(false);
                    T4.Start(false);
                    T5.Start(false);
                    T6.Start(false);
                    T7.Start(false);
                }
                else
                {
                    bot0 = new Bot(Convert.ToInt32(Repeat), progressBar1);
                    Thread T = new Thread(new ParameterizedThreadStart(bot0.StartBruteEmulate));
                    T.Start(true);
                }
            }
            catch
            {
                MessageBox.Show("Params Error", "Critical Overflow Bug", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StartBtn.Enabled = true;
            }
        }

        private void MTA() { }



        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if ((progressBar1.Value == 100) && NeedRefresh)
            {
                UpdateData();
            }
        }

        private void UpdateData()
        {
            double Ptc;
            double GCD;
            if (checkMTA.Checked)
            {
                Ptc = ((double)bot0.TotalPTC +
                    (double)bot1.TotalPTC +
                    (double)bot2.TotalPTC +
                    (double)bot3.TotalPTC +
                    (double)bot4.TotalPTC +
                    (double)bot5.TotalPTC +
                    (double)bot6.TotalPTC +
                    (double)bot7.TotalPTC)
                    / (bot0.TotalGCD +
                    bot1.TotalGCD +
                    bot2.TotalGCD +
                    bot3.TotalGCD +
                    bot4.TotalGCD +
                    bot5.TotalGCD +
                    bot6.TotalGCD +
                    bot7.TotalGCD);



                GCD = (bot0.TotalGCD +
                    bot1.TotalGCD +
                    bot2.TotalGCD +
                    bot3.TotalGCD +
                    bot4.TotalGCD +
                    bot5.TotalGCD +
                    bot6.TotalGCD +
                    bot7.TotalGCD)
                    / ((double)bot0.Repeat*8);



                AvgPtcLB.Text = "Avg. Ptc: " + Convert.ToString(Math.Round(Ptc, 3));
                ExpGCDLB.Text = "Exp. Gcd: " + Convert.ToString(Math.Round(GCD, 3));
                StartBtn.Enabled = true;
                NeedRefresh = false;
            }
            else
            {
                Ptc = (double)bot0.TotalPTC / bot0.TotalGCD;
                GCD = (double)bot0.TotalGCD / bot0.Repeat;
                AvgPtcLB.Text = "Avg. Ptc: " + Convert.ToString(Math.Round(Ptc, 3));
                ExpGCDLB.Text = "Exp. Gcd: " + Convert.ToString(Math.Round(GCD, 3));
                StartBtn.Enabled = true;
                NeedRefresh = false;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;



namespace TC_Emulator_Altn
{
    public class Bot
    {

        public int TotalGCD;
        public int TotalPTC;
        public int Repeat;
        public Random Rd = new Random();

        private int ServerTick; //0-2999
        ProgressBar bar;
        public Bot(int Repeat, ProgressBar P)
        {
            this.Repeat = Repeat >= 100 ? Repeat : 100;
            ServerTick = Rd.Next(3000);
            this.bar = P;
        }

        public void StartBruteEmulate(object allowinvoke)
        {
            for (int p = 0; p < Repeat; p++)
            {
                Engage();
                if (p % (Repeat / 100) == 0&&(bool)allowinvoke)
                {
                    bar.Invoke((MethodInvoker)delegate
                    {
                        bar.Value = Convert.ToInt32((p * 100 / Repeat));
                    });
                }
            }
            if ((bool)allowinvoke)
            bar.Invoke((MethodInvoker)delegate
            {
                bar.Value = 100;
            });
        }

        public void Engage()
        {
            int loopgcd = 1;
            int loopptc = 70;

            long CurrentTime = 0;

            bool thunderstruck = false;
            int Tthunderstruck = 0;

            int TDoT = 0 + 24000;

            while (true)
            {
                if (thunderstruck && (Tthunderstruck <= 1 || TDoT <= 1))
                {
                    //throwTC
                    loopgcd++;
                    loopptc += 390;

                    thunderstruck = false;
                    Tthunderstruck = 0;

                    TDoT = 24000;

                }

                if (CurrentTime % 3000 == ServerTick)
                {
                    //dot damage
                    loopptc += 40;
                    //Gen TC
                    ThunderCloudGenerator(ref thunderstruck, ref Tthunderstruck);
                }

                //countdown
                CurrentTime++;
                Tthunderstruck--;
                TDoT--;
                if (TDoT == 0) break;
            }

            //Record data
            //TotalGCD += loopgcd;
            //TotalPTC += loopptc;
            Interlocked.Add(ref TotalGCD, loopgcd);
            Interlocked.Add(ref TotalPTC, loopptc);
        }


        public void ThunderCloudGenerator(ref bool thunderstruck, ref int Tthunderstruck)
        {
            string uidhead = Guid.NewGuid().ToString().Split('-')[0];
            int seed = Convert.ToInt32(uidhead, 16);
            //Generate
            if (seed % 10 == 0)
            {
                thunderstruck = true;
                Tthunderstruck = 18000;
            }
        }

    }
}

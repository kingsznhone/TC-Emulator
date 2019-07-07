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



namespace TC_Emulator
{
    public struct Sample
    {
        public long TimeStamp;
        public int CountHC;
        public int CountTC;
        public int TotalPTC;
    }

    public class Bot
    {
        public List<Sample> samples = new List<Sample>();
        public Random Rd = new Random();
        private long EmuLen;
        private int ServerTick; //0-2999
        private int SamplingInterval;
        ProgressBar bar;
        public Bot(long EmuLen, int Samplingcount, ProgressBar P)
        {
            this.EmuLen = EmuLen+1;
            this.SamplingInterval = (int)(EmuLen/Samplingcount);
            ServerTick = Rd.Next(3000);
            this.bar = P;
        }


        public void Engage()
        {
            
            Sample sample = new Sample();

            long CurrentTime = 0;

            bool thunderstruck = false;
            int Tthunderstruck = 0;

            int TDoT = 0;

            while(true)
            {
                
                if (CurrentTime == EmuLen) break;

                if (thunderstruck&&(Tthunderstruck<=1||TDoT<=1))
                {
                    //throwTC
                    sample.CountTC++;
                    thunderstruck = false;
                    Tthunderstruck = 0;
                    TDoT = 24000;
                    sample.TotalPTC += 390;
                }

                if (TDoT<=1)
                {
                    //HardCast
                    TDoT = 24000;
                    sample.TotalPTC += 70;
                    sample.CountHC++;
                }

                if(CurrentTime%3000==ServerTick)
                {
                    //dot damage
                    sample.TotalPTC += 40;
                    //Gen TC
                    ThunderCloudGenerator(ref thunderstruck, ref Tthunderstruck);

                }

                if ((CurrentTime) % SamplingInterval == 0)
                {
                    if(CurrentTime!=0)
                    {
                        sample.TimeStamp = CurrentTime+1;
                        samples.Add(sample);
                    }
                }


                //countdown
                CurrentTime++;
                Tthunderstruck--;
                TDoT--;



                if (CurrentTime % (EmuLen / 100) == 0)
                {
                    bar.Invoke((MethodInvoker)delegate
                    {
                        bar.Value = Convert.ToInt32((CurrentTime * 100 / EmuLen));
                    });
                }

            }
            bar.Invoke((MethodInvoker)delegate {
                bar.Value = 100;
            });

        }


        public void ThunderCloudGenerator(ref bool thunderstruck, ref int Tthunderstruck)
        {
            string uidhead = Guid.NewGuid().ToString().Split('-')[0];
            int seed = Convert.ToInt32(uidhead, 16);
            //Generate
            if (seed%10 == 0)
            {
                thunderstruck = true;
                Tthunderstruck = 18000;
            }
        }

    }
}

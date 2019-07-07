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
        public long TotalGCD;
        public long TotalPTC;
        public long loopcount;
        public Random Rd = new Random();

        private int ServerTick; //0-2999

        public Bot()
        {
            Reset();
        }

        public void Reset()
        {
            loopcount = 0;
            TotalGCD = 0;
            TotalPTC = 0;
            ServerTick = Rd.Next(3000);
        }

        public void Engage()
        {
            long loopgcd = 1;
            long loopptc = 70;

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
                    //AccTCGen(ref thunderstruck, ref Tthunderstruck);
                }

                //countdown
                CurrentTime++;
                Tthunderstruck--;
                TDoT--;
                
                if (TDoT == 0) break;
            }

            //Record data
            //loopcount++;
            //TotalGCD += loopgcd;
            //TotalPTC += loopptc;
            Interlocked.Add(ref loopcount, 1);
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


        public  void AccTCGen(ref bool thunderstruck, ref int Tthunderstruck)
        {
            if (Rd.Next(10) % 10 == 0)
            {
                thunderstruck = true;
                Tthunderstruck = 18000;
            }
        }
    }
}

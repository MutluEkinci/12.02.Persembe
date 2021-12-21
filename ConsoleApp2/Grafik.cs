using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Grafik
    {
        public Grafik(int[] data)
        {
            Data = data;
        }
        public int[] Data { get; set; }

        public void Ciz()
        {
            for (int i = 0; i < Data.Length; i++)
                Console.WriteLine("{0:d2} {1}",i,Bar(Data[i]));
        }
        private string Bar(int value)
        {
            string strBar = "";
            int bol = value / 10;
            for (int i = 0; i < bol; i++)
            {
                strBar += "***";
            }
            return strBar;
        }
    }
}

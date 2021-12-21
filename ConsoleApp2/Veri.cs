using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    static class Veri
    {
        public static void VeriDoldur(string strDosya, int adet)
        {
            StreamWriter sw = new StreamWriter(strDosya);
            Random rndAy = new Random();
            Random rndMiktar = new Random();
            for (int i = 0; i < adet; i++)
                sw.WriteLine(rndAy.Next(1, 13) + ";" + rndMiktar.Next(1, 6));
            sw.Close();
        }
        public static int[] AylaraGöre(string strDosya)
        {
            int[] data = new int[13];
            string[] satir = new string[2];

            StreamReader sr = new StreamReader(strDosya);

            while (!sr.EndOfStream)
            {
                satir = sr.ReadLine().Split(';');
                data[int.Parse(satir[0])] += int.Parse(satir[1]);
            }
            sr.Close();

            return data;
        }
    }
}

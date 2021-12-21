using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru: Bir firmanın bir yıl boyunca yaptığı satışların bilgisi rastgele olarak bir dosyaya(csv) aktarılmıştır. Bu dosyada 200 satır veri bulunmaktadır.İlk kısım ay bilgisi, ikinci kısım ise satış miktarı(satış miktarı maksimum 5 olabilir.)
            //ornek olarak
            //1;5
            //4;3
            //1;4
            //İkinci olarak aylık olarak grafiğini çizdirin.

            int secim = 0;
            do
            {
                Console.WriteLine("1-Veri Doldur");
                Console.WriteLine("2-Grafik Çiz");
                Console.WriteLine("3-Çıkış");
                Console.WriteLine("\nSeçiminiz");
                secim = int.Parse(Console.ReadLine());

                if (secim==1)
                    Veri.VeriDoldur("data.csv", 200);
                else if (secim == 2)
                {
                    int[] data = Veri.AylaraGöre("data.csv");
                    foreach (int s in data) 
                        Console.WriteLine(s);
                    Grafik grf = new Grafik(data);
                    grf.Ciz();
                }
            } while (secim != 3);
            


           
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dosyalar:dosyalar tututlurken disk üzerinde tutulur ama adresi "FAT" ve "NFTS" gibi indexleyicilerde tutulur.
            Dosyalar ikiye ayrılır.
            1-Text dosyalar:Herhangi bir metin dosyasıyla açıldığında anlamlandırabildiğimiz dosyalara denir.
            2-Binary dosyalar:İki bileşenden oluşur
            1-Header 2-Datanın olduğu kısım.
            Text dosyalarında header yoktur. Headerını bilmediğiniz binary dosyaları açamazsınız.
            Header:Çözünürlik,nasıl okunması gerektiği,ne zaman oluşturulduğu,datayı nerden okuyacağın gibi verileri tutar.
            */
            //Text Dosyalar

            //Dosya açma modları
            //1-Bir dosya read modunda açılabilir.
            //2-Write modunda açılabilir.
            //3-Append modunda açılabilir.

            //StreamWriter sw = new StreamWriter("Data.txt",true);
            //sw.WriteLine("Merhaba Dosya....");
            //sw.WriteLine("İkinci Satır...");
            //sw.Close();

            //StreamReader sr = new StreamReader("data.txt");
            //Console.WriteLine(sr.ReadToEnd());

            //sr.Close();

            CSVFileManager file = new CSVFileManager();

            int secim = 0;
            do
            {
                Console.WriteLine("1-Yeni Kayıt");
                Console.WriteLine("2-Listele");
                Console.WriteLine("3-Ara(ID)");
                Console.WriteLine("4-Çıkış");

                Console.WriteLine("Seçiminiz");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Personnel p = new Personnel();
                        Console.Write("Personel ID");
                        p.ID = int.Parse(Console.ReadLine());
                        Console.Write("Personel Ad");
                        p.Ad = Console.ReadLine();
                        Console.Write("Bölüm");
                        p.Bölüm = Console.ReadLine();
                        Console.Write("Maaş");
                        p.Maas = double.Parse(Console.ReadLine());
                        file.Add(p);
                        break;
                    case 2:
                        Console.WriteLine("Personel Listesi");
                        foreach (Personnel personel in file.List())
                            Console.WriteLine(personel);
                        break;
                    case 3:
                        Console.WriteLine("Aradığınız ID");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine(file.Find(id));
                        break;
                }
            } while (secim != 4);






        }
    }
}

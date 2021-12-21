using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._12.perşembe
{
    class Program
    {
        static void Listele(List<Urun> urunler)
        {
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun);
            }
        }
        static void Listele(IEnumerable<Urun> urunler)
        {
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun);
            }
        }

        static void Main(string[] args)
        {
            List<Urun> urunler = new List<Urun>()
            {
                new Urun { UrunID = 111, UrunAdi = "Defter", Fiyat = 33 },
                new Urun { UrunID = 155, UrunAdi = "Kalem", Fiyat = 23 },
                new Urun { UrunID = 102, UrunAdi = "Silgi", Fiyat = 5 }
            };

            //Soru 2: ID'si 155 olan urun?
            //Soru 3: Adi silgi olan urun?
            //Soru 4 : Fiyati 10dan büyük olanlar?

            //Eksi Usül
            foreach (Urun s in urunler)
            {
                if(s.UrunID==155)
                    Console.WriteLine(s);
            }

            foreach (Urun s in urunler)
            {
                if(s.UrunAdi=="Silgi")
                    Console.WriteLine(s);
            }
            foreach (var s in urunler)
            {
                if(s.Fiyat>10)
                    Console.WriteLine(s);
            }

            //LINQ TO Object
            //1-Expression Tree
            Console.WriteLine();
            foreach (var urun in urunler.Where(u=>u.UrunID==155))
            {
                Console.WriteLine(urun);
            }
            foreach (var urun in urunler.Where(u => u.UrunAdi=="Silgi"))
            {
                Console.WriteLine(urun);
            }
            foreach (var urun in urunler.Where(u => u.Fiyat>10))
            {
                Console.WriteLine(urun);
            }

            Console.WriteLine();
            foreach (var urun in urunler.Where(u => u.Fiyat > 10).OrderBy(u => u.Fiyat))
            {
                Console.WriteLine(urun);
            }


            //2-SQL gibi

            Console.WriteLine("SQL");

            var sonuc1 = from u in urunler
                         where u.UrunID == 155
                         select u;

            Console.WriteLine(sonuc1);//Koleksiyon olduğu için cw ile yazdırılmaz.
            Listele(sonuc1.ToList());

            var sonuc2 = from u in urunler
                         where u.UrunAdi == "Silgi"
                         select u;
            Listele(sonuc2.ToList());

            var sonuc3 = (from u in urunler
                         where u.Fiyat > 10
                         select u).OrderBy(u=>u.Fiyat>10);

            Listele(sonuc3.ToList());

            //Ozel durum
            //Deffered Mode
            //ToList,ToArray
            Console.WriteLine("Ara:155");
            int id = 155;
            var sonuc4 = (from u in urunler
                          where u.UrunID == id
                          select u);//.ToList();//anında çalıştırmak istersek tolist kullanırız.yoksa sonuc4'ü kullanmadan önceki son ıdyi(102) kullanır.
            Listele(sonuc4);

            id = 102;

            
            Console.WriteLine(sonuc4.SingleOrDefault());
            //LINQ sorguları ıenumerable tipinde değer döndürür eğer bir parametre girilmediyse.



        }
    }
}

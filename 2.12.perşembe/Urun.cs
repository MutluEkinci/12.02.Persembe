using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._12.perşembe
{
    class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public override string ToString()
        {
            return UrunID + " " + UrunAdi + " " + Fiyat;     
        }

    }
}

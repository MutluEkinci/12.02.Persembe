using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Personnel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Bölüm { get; set; }
        public double Maas { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", ID, Ad, Bölüm, Maas);
        }
    }
}

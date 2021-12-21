using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CSVFileManager
    {
        public void Add(Personnel p)
        {
            using (StreamWriter sw = new StreamWriter("Personnel.csv", true))//close yazmamıza gerek kalmıyor kendisi kapatıyor using...
            {
                sw.WriteLine(p.ToString().Replace(' ',';'));
            }
        }
        public List<Personnel> List()
        {
            List<Personnel> pers = new List<Personnel>();
            StreamReader sr = new StreamReader("Personnel.csv");
            while (!sr.EndOfStream)
            {
                string[] str = sr.ReadLine().Split(';');
                Personnel p = new Personnel() 
                {
                    ID=int.Parse(str[0]),
                    Ad=str[1],
                    Bölüm=str[2],
                    Maas=double.Parse(str[3])
                };
                pers.Add(p);
            }
            sr.Close();
            return pers;
        }
        public Personnel Find(int id)
        {
            StreamReader sr = new StreamReader("Personnel.csv");
            Personnel p = new Personnel();
            while (!sr.EndOfStream)
            {
                string[] str = sr.ReadLine().Split(';');
                if (id == int.Parse(str[0]))
                {
                    p.ID = int.Parse(str[0]);
                    p.Ad = str[1];
                    p.Bölüm = str[2];
                    p.Maas = double.Parse(str[3]);

                    break;
                }
            }
            sr.Close();
            return p;
        }
       
    }
}

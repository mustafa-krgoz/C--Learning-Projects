using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleSinif
{
    // Sınıf içinde sınıf tanımlama
     class Sinif
    {
        int x = 10;
        static int y = 10;
        class Sinif2
        {
            public int x = 0;
            static public int y = 10;
        }
        static void Main(string[] args)
        {
            Sinif a = new Sinif();
            Sinif2 b = new Sinif2(); // veya Sinif.Sinif2 b = new Sinif2();
            a.x = 7; Sinif.y = 15;
            b.x = 12; Sinif2.y = 1;

            Console.WriteLine("Sinif taki x = " + a.x+ ", " + "Sinif2 deki x = " + b.x);
            Console.WriteLine("Sinif taki y = " + Sinif.y+ ", " + "Sinif2 deki y = " + Sinif2.y);
            Console.ReadLine();
        }
    }
}

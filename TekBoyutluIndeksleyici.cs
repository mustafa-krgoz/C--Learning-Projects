using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekBoyutluIndeksleyici
{
    class Sinif
    {
        public int Sayi;
        public int this[int indeks]{
            get { return Sayi; }
            set { Sayi = value; }
        }
        static void Main(string[] args)
        {
            Sinif a = new Sinif();
            a[5] = 30;
            Console.WriteLine(a[5]);
            Console.ReadLine();
        }
    }
}

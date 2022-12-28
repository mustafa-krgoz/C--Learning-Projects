using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarmasikSayi
{
  class Program
    {
        static void Main(string[] args)
        {
            KarmasikSayi k = new KarmasikSayi(-5,-6); //Parametreli Yapıcı metoduna değer göndeririz.
            k.Yaz();
            Console.Read();
        }
    }
}

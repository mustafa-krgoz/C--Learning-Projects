using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethod
{
    internal class Program
    {
        static void Yaz(Array dizi) // Bütün türlere ait dizileri yazmak istiyorsak kullanılır(Array)
        {
            foreach (object i in dizi) // object yerine var veya dynamic kullanılabilir.
                Console.WriteLine(dizi);
        }
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 4, 7, 9 };
            Yaz(dizi);
            Console.ReadLine();
        }
    }
}

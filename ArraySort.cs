using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array.Sort();

            string[] dizi = { "Zeynep", "Fatma", "Ali", "Yılmaz", "Gökhan", "Osman", "Feride" };
            Console.WriteLine("Dizinin Elemanları\n==================");
            foreach (string s in dizi)
                Console.WriteLine(s);

            Array.Sort(dizi);
            Console.WriteLine();

            Console.WriteLine("Sıralanmış Dizi\n===================");
            foreach (string s in dizi)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraylistSınıfı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList içerisindeki verilere erişmek
            ArrayList liste = new ArrayList();
            liste.Add("Murat");
            liste.Add("Yeşim");
            liste.Add("Deniz");

            Console.WriteLine(liste[2]);
            foreach (String eleman in liste)
            {
                Console.WriteLine(eleman);
            }
            Console.ReadLine();


        }
    }
}

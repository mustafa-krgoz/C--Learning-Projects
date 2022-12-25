using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOrnek
{
     class MathOrnek
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Bir sayı giriniz:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Girilen sayının Mutlak değeri:" + Math.Abs(a));
            Console.WriteLine("Girilen sayının Cosinüs değeri:" + Math.Cos(a*Math.PI/180));
            Console.WriteLine("Girilen sayının Sinüs değeri:" + Math.Sin(a*Math.PI/180));
            Console.WriteLine("Girilen sayının Yuvarlatılması:" + Math.Round(a));
            Console.WriteLine("Girilen sayının Logaritması:" + Math.Log(a));
            Console.WriteLine("Girilen sayının Karekökü:" + Math.Sqrt(a));
            Console.WriteLine("Girilen sayının karesi:" + Math.Pow(a, 2));
            Console.ReadLine();
        }
    }
}

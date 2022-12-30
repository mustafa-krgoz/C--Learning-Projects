using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogumTarihi
{
    class Program
    {
        static void Main(string[] args)
        {
            int yil, ay, gun;
            Console.Write("Doğum Yılınız:");
            yil = Convert.ToInt32(Console.ReadLine());
            Console.Write("Doğum Ayınız:");
            ay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Doğum gününüz:");
            gun = Convert.ToInt32(Console.ReadLine());

            DateTime Bugun = DateTime.Today;
            DateTime DogumGunu = new DateTime(yil, ay, gun);

            TimeSpan fark = Bugun - DogumGunu;

            Console.WriteLine("Doğdunuz Gün: {0}", DogumGunu.DayOfWeek);
            Console.WriteLine("Gün sayısı: {0}", fark.Days);

            Console.WriteLine();
            Console.Write("Gün sayısı:");
            gun = Convert.ToInt32(Console.Read());

            TimeSpan GunSayisi = new TimeSpan(gun, 0, 0, 0);
            DateTime Gelecek = DateTime.Today + GunSayisi; 
            Console.WriteLine("{0} gün sonra günlerden {1} dir.", gun, Gelecek.DayOfWeek);
            Console.Read();

        }
    }
}

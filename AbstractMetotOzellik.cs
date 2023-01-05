using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMetotOzellik
{
    abstract class A
    {
        abstract public int ozellik // A sınıfından türeyen hangi sınıf olursa olsun özellik değişkenini
                                    // mutlaka kullanıcak.
        {
            get; set;
        }
    }
    class B : A
    {
        override public int ozellik // A sınıfında virtual olmasına gerek yok kendiliğinden virtual taşır.
        {
            get
            {
                return 100;
            }
            set
            {
                Console.WriteLine("Bu bir denemedir.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B nesne = new B();
            Console.WriteLine(nesne.ozellik); // Türemiş sınıftaki özelliğe erişiriz.
            nesne.ozellik = 200; // set ile değer ataması yapar.(Bu bir denemedir yazdırır.)
            Console.ReadLine();
        }

    }
        
 }


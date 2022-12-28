using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorunAsiriYuklenmesi
{
    class Program
    {
        public int x, y;
        public Program(int dd, int ff)
        {
            x = dd;
            y = ff;
        }
        public void Yaz()
        {
            Console.WriteLine(x + " " + y);
        }
        public static Program operator +(Program a, Program b)
        {
            int c = a.x + a.y;
            int z = b.x + b.y;
            return new Program(c, z);
        }
    }
    class Sinif
    {
        static void Main(string[] args)
        {
            Program a = new Program(5, 8);
            Program b = new Program(7, 9);
            Program m = new Program(6, 2);
            Program c = a + b + m;
            c.Yaz();
            Console.Read();
            
        }
    }
        
    
}

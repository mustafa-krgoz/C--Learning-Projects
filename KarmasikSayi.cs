using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarmasikSayi
{
    class KarmasikSayi
    {
        private double mGercek; // Private tanımlayarak Program sınıfı içerisinden saklanır.
        private double mSanal;

        public double Gercek {   /* Global alandaki değişkenlere, Program sınıfından erişebilmek için
                                SahteOzellik dediğimiz içerisinde get,set anahtar sözcüğü bulunduran
                                Gercek ve Sanal metotları oluşturduk. */
            get                 
            {
                return mGercek;
            }
            set
            {
                mGercek = value;

            }
        }
        public double Sanal
        {
            get
            {
                return mSanal;
            }
            set
            {
                mSanal = value;
            }
        }
        public KarmasikSayi(double x, double y) // Yapıcı Metod
        {
            mGercek= x;
            mSanal= y;
        }
        public KarmasikSayi() // Boş Yapıcı Metod
        {
            mGercek = 0;
            mSanal = 0;
        }
        public KarmasikSayi(KarmasikSayi k) // Kopyalayıcı Yapıcı Metod
        {
            mGercek= k.mGercek;
            mSanal= k.mSanal;
        } 
        public void Yaz()
        {
            if (mSanal > 0)
                Console.WriteLine("{0} + {1}i", mGercek, mSanal);
            else
                Console.WriteLine("{0} - ({1})i", mGercek, mSanal);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10haziran05
{
    class Program
    {
        static void Main(string[] args)
        {
            // == ve != operatörlerini overload ettik.
            // Zaman sınıfından bir nesne ile int türünde bir değeri karşılaştırabiliyoruz.
            // Karşılaştırma sonucunda bool türünde bir değer döndürür.

            Zaman zaman1 = new Zaman(2, 70, 125);
            zaman1.EkranaYaz();
            Zaman zaman3 = zaman1 + 2400;
            zaman3.EkranaYaz();


            Zaman zaman2 = zaman1.ToplamSaniye;
            zaman2.EkranaYaz();
            int saniye = (int)zaman1;
            Console.ReadKey();
        }
    }

    class Zaman
    {
        //---------------------
        //explicit(bilinçli tür dönüşümü) operatörünü overload ederek,
        //Zaman türünde bir nesneyi int türüne dönüştürebiliriz.
        // Bu dönüşüm sırasında, Zaman nesnesinin ToplamSaniye özelliği int türüne dönüştürülür.
        public static explicit operator int(Zaman zaman)
        {
            return zaman.ToplamSaniye;
        }


        //-------------------
        //implicit(bilinçsiz tür dönüşümü) operatörünü overload ederek,
        //int türünde bir değeri Zaman türüne dönüştürebiliriz.
        // Bu dönüşüm sırasında, int türündeki değer Zaman nesnesinin
        // ToplamSaniye özelliği olarak atanır ve diğer özellikler buna göre hesaplanır.
        public static implicit operator Zaman(int saniye)
        {
            return new Zaman(saniye);
        }

        //------------------

        public static bool operator true(Zaman z1)
        {
            if (z1.ToplamSaniye > 0)
            {
                return true;
            }
            return false;
        }
        public static bool operator false(Zaman z1)
        {
            if (z1.ToplamSaniye <= 0)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Zaman z1, int z2)
        {
            if (z1.ToplamSaniye == z2)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Zaman z1, int z2)
        {
            return !(z1 == z2);
        }
        public static bool operator ==(Zaman z1, Zaman z2)
        {
            if (z1.ToplamSaniye == z2.ToplamSaniye)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Zaman z1, Zaman z2)
        {
            return !(z1 == z2);
        }


        public static Zaman operator +(Zaman z1, int saniye1)
        {
            int saniye = z1.ToplamSaniye + saniye1;
            return new Zaman(saniye);
        }
        public static Zaman operator -(Zaman z1, Zaman z2)
        {

            int saniye = Math.Abs(z1.ToplamSaniye - z2.ToplamSaniye);
            return new Zaman(saniye);
        }
        public Zaman(int saat, int dakika, int saniye)
        {
            Saniye = saniye % 60;
            Dakika = dakika + saniye / 60;
            Saat = saat + Dakika / 60;
            Dakika %= 60;
            ToplamSaniye = (Saat * 3600) + (Dakika * 60) + Saniye;
            ZamanFormat = $"{Saat}:{Dakika}:{Saniye}";
        }
        public Zaman(int saniye) : this(0, 0, saniye)
        {


        }
        public readonly int Saat;
        public readonly int Dakika;
        public readonly int Saniye;
        public readonly int ToplamSaniye;
        public string ZamanFormat;
        public void EkranaYaz()
        {
            Console.WriteLine($"Toplam Saniye: {ToplamSaniye}");
            Console.WriteLine(ZamanFormat);
        }


    }
}

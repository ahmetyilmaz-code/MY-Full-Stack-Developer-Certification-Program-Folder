using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp29haziran05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ogrenci");
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.KullaniciOzellikleriniAl();

            Console.WriteLine("Ogretmen");
            Ogretmen ogretmen = new Ogretmen();
            ogrenci.KullaniciOzellikleriniAl();

        }

        // Kalıtım 
        class Ogrenci : Kullanici
        {

            public string Sinifi { get; set; }
        }
        class Ogretmen : Kullanici
        {

            public string Brans { get; set; }
        }
        class Kullanici
        {
            public string KullaniciAdi { get; set; }
            public string Sifre { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }

            public void KullaniciOzellikleriniAl() // bu metot ile kullanıcı sınıfından türüyen(miras alan)
                                                   //bütün sınıf nesneleri erişebilir
            {
                Console.Write("Ad :");
                Ad = Console.ReadLine();
                Console.Write("Soyad :");
                Soyad = Console.ReadLine();
                Console.Write("Sifre :");
                Sifre = Console.ReadLine();
                Console.Write("KullaniciAdi :");
                KullaniciAdi = Console.ReadLine();
            }
        }
    }
}

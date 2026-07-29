using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp29haziran04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "asdasd";
            ogrenci.Soyad = "wad";
            ogrenci.Sinifi = "asda";

            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Ad = "asd";
            ogretmen.Brans = "asd";

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
        }
    }
}

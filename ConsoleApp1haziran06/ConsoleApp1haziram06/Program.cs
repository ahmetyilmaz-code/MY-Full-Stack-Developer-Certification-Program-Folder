using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1haziran06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ogrenci {} olsun
            // bu sınıfın içinde OgrenciNo, Ad, Soyad, Adres ve VeliTelefonNumarası olsun

            // bu sınıftan bir nesne oluşacağı zaman mutlaka
            // OgrenciNo, ve VeliTelefonNumarası doldurulmak zorunda olsun
            // değer ataması yapılmayan özellijler için tanım yapılmadı şeklinde bilgi verilsin

            Ogrenci ogrenci1 = new Ogrenci("1453", "0555 123 45 67");
            //ogrenci1.Ad = "Ahmet";
            //ogrenci1.Soyad = "Yılmaz";
            //ogrenci1.Adres = "İstanbul";
            ogrenci1.ogrenciBilgileri();

            Console.ReadKey();
        }
    }

    class Ogrenci
    {
        public Ogrenci(string ogrenciNo, string veliTelefonNumarası)
        {
            OgrenciNo = ogrenciNo;
            VeliTelefonNumarası = veliTelefonNumarası;
        }

        public string OgrenciNo { get; set; }
        public string VeliTelefonNumarası { get; set; }

        private string ad { get; set; }
        private string soyad { get; set; }
        private string adres { get; set; }

        public string Adres { get; set; } = "Tanım yapılmadı";
        public string Ad { get => DegerKontrol(ad); set { ad = value; } }
        public string Soyad { get => (soyad == "" || soyad == null) ? "tanım yapılmadı" : soyad; set { soyad = value; } }



        private string DegerKontrol(string deger)
        {
            if (deger == "" || deger == null)
            {
                return "Tanım yapılmadı";
            }
            return deger;

        }

        public void ogrenciBilgileri()
        {
            Console.WriteLine($"Öğrenci No: {OgrenciNo}");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Soyad: {Soyad}");
            Console.WriteLine($"Adres: {Adres}");
            Console.WriteLine($"Veli Telefon Numarası: {VeliTelefonNumarası}");
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1haziran05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ogrenci {} olsun
            // bu sınıfın içinde OgrenciNo, Ad, Soyad, Adres ve VeliTelefonNumarası olsun

            // bu sınıftan bir nesne oluşacağı zaman mutlaka
            // OgrenciNo, ve VeliTelefonNumarası doldurulmak zorunda olsun
            // değer ataması yapılmayan özellijler için tanım yapılmadı şeklinde bilgi verilsin

            Ogrenci ogrenci1 = new Ogrenci("1453", "0555 123 45 67");
            //ogrenci1.Ad = "Ahmet";
            //ogrenci1.Soyad = "Yılmaz";
            //ogrenci1.Adres = "İstanbul";
            ogrenci1.ogrenciBilgileri();

            Console.ReadKey();
        }
    }

    class Ogrenci
    {
        public Ogrenci(string ogrenciNo, string veliTelefonNumarası)
        {
            OgrenciNo = ogrenciNo;
            VeliTelefonNumarası = veliTelefonNumarası;
        }

        public string OgrenciNo { get; set; }
        public string VeliTelefonNumarası { get; set; }

        private string ad { get; set; }
        private string soyad { get; set; }
        private string adres { get; set; }

        public string Adres { get; set; } = "Tanım yapılmadı";
        public string Ad { get => DegerKontrol(ad); set { ad = value; } }
        public string Soyad { get => (soyad == "" || soyad == null) ? "tanım yapılmadı" : soyad; set { soyad = value; } }



        private string DegerKontrol(string deger)
        {
            if (deger == "" || deger == null)
            {
                return "Tanım yapılmadı";
            }
            return deger;

        }

        public void ogrenciBilgileri()
        {
            Console.WriteLine($"Öğrenci No: {OgrenciNo}");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Soyad: {Soyad}");
            Console.WriteLine($"Adres: {Adres}");
            Console.WriteLine($"Veli Telefon Numarası: {VeliTelefonNumarası}");
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15haziran04
{
    class Program
    {
        static void Main(string[] args)
        {
            HesapMakinesi.Hesapla();
            Console.ReadKey();
        }
    }
    static class Hesaplama
    {
        public static int Toplam(params int[] sayilar)
        {
            return sayilar.Sum();
        }

        public static int Cikar(params int[] sayilar)
        {
            Array.Sort(sayilar);
            int sonuc = sayilar[0];
            for (int i = 1; i < sayilar.Length; i++)
            {
                sonuc -= sayilar[i];
            }
            return sonuc;
        }
        public static int Carpim(params int[] sayilar)
        {
            int sonuc = 1;
            foreach (int i in sayilar)
            {
                sonuc *= i;
            }
            return sonuc;
        }
        public static int Bolum(params int[] sayilar)
        {
            Array.Sort(sayilar);
            int sonuc = sayilar[0];
            for (int i = 1; i < sayilar.Length; i++)
            {
                sonuc /= sayilar[i];
            }
            return sonuc;
        }
    }

    class HesapMakinesi
    {
        public static int sayi1 { get; set; }
        public static int sayi2 { get; set; }
        public static Islemler islem { get; set; }
        public static int sonuc { get; set; }


        public static void Hesapla()
        {
            SayiAl();
            İslemAl();
            HesaplamaYap();
            SonucYaz();
        }

        private static void SayiAl()
        {
            Console.Write("1. Sayı: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
        }

        private static void İslemAl()
        {
            Console.WriteLine("1- ) Toplam\n2- ) Çıkart\n3- ) Böl\n4- ) Çarp\n1 ile 4 arasında bir sayı şeçiniz =>");
            int _islem = Convert.ToInt32(Console.ReadLine());
            if (_islem < 1 || _islem > 4)
            {
                Console.WriteLine("1 ile 4 arasında bir sayı yazınız...");
                İslemAl();
            }
            islem = (Islemler)_islem;
        }

        private static void HesaplamaYap()
        {
            switch (islem)
            {
                case Islemler.Topla:
                    sonuc = Hesaplama.Toplam(sayi1, sayi2);
                    break;
                case Islemler.Cikart:
                    sonuc = Hesaplama.Cikar(sayi1, sayi2);
                    break;
                case Islemler.Carp:
                    sonuc = Hesaplama.Carpim(sayi1, sayi2);
                    break;
                default:
                    sonuc = Hesaplama.Bolum(sayi1, sayi2);
                    break;
            }
        }
        private static void SonucYaz()
        {
            Console.Clear();
            Console.WriteLine($"Sonuç: {sonuc}");
            Console.WriteLine("İşlem yapmak için bir tuşa basınız...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Bir Önceki İşlem Sonuç: {sonuc}");
            Hesapla();
        }

    }

    enum Islemler
    {
        Topla = 1,
        Cikart,
        Carp,
        Bol
    }
}

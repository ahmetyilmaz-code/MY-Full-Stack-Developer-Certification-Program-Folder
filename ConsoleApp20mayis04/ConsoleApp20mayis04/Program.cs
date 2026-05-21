using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20mayis04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kişiden kişiye değişen özellikler
            AileBireyleri baba = new AileBireyleri();
            baba.DegerAl();

            AileBireyleri anne = new AileBireyleri();
            anne.DegerAl();

            AileBireyleri cocuk1 = new AileBireyleri();
            cocuk1.DegerAl();

            //Kişiden kişiye değişmeyen özellikler
            AileBireyleri.Adres = "İstanbul";
            AileBireyleri.SoyAdi = "Yılmaz";

            baba.DegerYaz();
            anne.DegerYaz();
            cocuk1.DegerYaz();



            Console.ReadKey();
        }




    }

    class AileBireyleri
    {
        //kişiden kişiye değişir özellikler
        public string Ad;
        public int Yas;
        public string Cinsiyet;

        //kişiden kişiye değişmez
        public static string Adres;
        public static string SoyAdi;

        public void DegerAl()
        {
            Console.Write("Ad: ");
            Ad = Console.ReadLine();
            Console.Write("Yaş: ");
            Yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cinsiyet: ");
            Cinsiyet = Console.ReadLine();
        }

        public void DegerYaz()
        {
            Console.WriteLine("\n***************\n");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Yaş: {Yas}");
            Console.WriteLine($"Cinsiyet: {Cinsiyet}");

            //stati olan özellikere aynı sınıfın içinde olmak kaydıyla isim ile erişebiliriz
            Console.WriteLine($"Adres: {Adres}");
            Console.WriteLine($"Soyadı: {SoyAdi}");
            Console.WriteLine("\n***************\n");
        }
    }





}

using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20mayis03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kişiden kişiye değişen özellikler
            AileBireyleri baba = new AileBireyleri();
            baba.Ad = "Ahmet";
            baba.Yas = 50;
            baba.Cinsiyet = "Erkek";

            AileBireyleri anne = new AileBireyleri();
            anne.Ad = "Ayşe";
            anne.Yas = 45;
            anne.Cinsiyet = "Kadın";

            AileBireyleri cocuk1 = new AileBireyleri();
            cocuk1.Ad = "Ali";
            cocuk1.Yas = 20;
            cocuk1.Cinsiyet = "Erkek";

            //Kişiden kişiye değişmeyen özellikler
            AileBireyleri.Adres = "İstanbul";
            AileBireyleri.SoyAdi = "Yılmaz";


            AileBireyOzellikYaz(baba);
            Console.WriteLine();
            AileBireyOzellikYaz(anne);
            Console.WriteLine();
            AileBireyOzellikYaz(cocuk1);

            Console.ReadKey();
        }

        static void AileBireyOzellikYaz(AileBireyleri birey)
        {
            Console.WriteLine($"Ad: {birey.Ad}");
            Console.WriteLine($"Yas: {birey.Yas}");
            Console.WriteLine($"Cinsiyet: {birey.Cinsiyet}");
            Console.WriteLine($"Adres: {AileBireyleri.Adres}");
            Console.WriteLine($"Soyad: {AileBireyleri.SoyAdi}");

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




    }





}
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20mayis02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kişiden kişiye değişen özellikler
            AileBireyleri baba = new AileBireyleri();
            baba.Ad = "Ahmet";
            baba.Yas = 50;
            baba.Cinsiyet = "Erkek";

            AileBireyleri anne = new AileBireyleri();
            anne.Ad = "Ayşe";
            anne.Yas = 45;
            anne.Cinsiyet = "Kadın";

            AileBireyleri cocuk1 = new AileBireyleri();
            cocuk1.Ad = "Ali";
            cocuk1.Yas = 20;
            cocuk1.Cinsiyet = "Erkek";

            //Kişiden kişiye değişmeyen özellikler
            AileBireyleri.Adres = "İstanbul";
            AileBireyleri.SoyAdi = "Yılmaz";


            AileBireyOzellikYaz(baba);
            Console.WriteLine();
            AileBireyOzellikYaz(anne);
            Console.WriteLine();
            AileBireyOzellikYaz(cocuk1);

            Console.ReadKey();
        }

        static void AileBireyOzellikYaz(AileBireyleri birey)
        {
            Console.WriteLine($"Ad: {birey.Ad}");
            Console.WriteLine($"Yas: {birey.Yas}");
            Console.WriteLine($"Cinsiyet: {birey.Cinsiyet}");
            Console.WriteLine($"Adres: {AileBireyleri.Adres}");
            Console.WriteLine($"Soyad: {AileBireyleri.SoyAdi}");

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




    }





}

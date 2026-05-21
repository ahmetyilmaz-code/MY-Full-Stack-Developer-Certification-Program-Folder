using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18mayis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Matematik isminde bir sınıf oluşturalım ve içerisinde
            // Min(), Max(), Ussu() Yuvarla()
            // yuvarla metodunda hazır metotlar kullanmak yasak.
            // 0.5 ve aşağısı 0
            // 0.51 ve üstü 1 olsun
            // Min ve Max sınırsız int değer alabilir.

            Matematik.Min(9, 2, 7, 15, 5);
            Matematik.Max(14, 52, 34, 47, 15);
            Matematik.Ussu(2, 3);
            Matematik.Yuvarla(3.4);
            Matematik.Yuvarla(3.8);


            Console.ReadKey();
        }
    }

    class Matematik
    {
        //Matematik.Min(9,2,7,15,5);
        //Min(9,2,7,15,5);

        public static void Min(params int[] sayilar)
        {
            if (sayilar.Length == 0)
            {
                Console.WriteLine("En az bir sayı giriniz.");
                return;
            }
            int Min = sayilar[0];
            foreach (int i in sayilar)
            {
                if (i < Min)
                    Min = i;
            }
            Console.WriteLine(Min);
        }

        public static void Max(params int[] sayilar)
        {
            if (sayilar.Length == 0)
            {
                Console.WriteLine("En az bir sayı giriniz.");
                return;
            }

            int Max = sayilar[0];
            foreach (int i in sayilar)
            {
                if (i > Max)
                    Max = i;
            }
            Console.WriteLine(Max);
        }

        public static void Ussu(int a, int b)
        {
            int Ussu = (int)Math.Pow(a, b);
            Console.WriteLine(Ussu);
        }

        public static void Yuvarla(double sayi)
        {
            int temp = (int)sayi;
            if (sayi - temp <= 0.5)
            {
                Console.WriteLine(temp);
            }
            else
            {
                Console.WriteLine(temp + 1);
            }

        }
    }




}

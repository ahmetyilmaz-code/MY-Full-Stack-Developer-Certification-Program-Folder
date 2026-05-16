using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13mayis03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gönderilen sayılar arasında istenildiğinde en büyüğünü veya seçime göre en küçüğünü bulan metot.
            int b = SayiBul(true, 12, 43, 5, 4, 23, 7, 564, 76, 8, 9);
            int k = SayiBul(false, 1, 32, 5, 6, 4353, 65, 43, 4, 65, -54, 342, 54 - 3);
            Console.WriteLine(b);
            Console.WriteLine(k);
            Console.ReadKey();
        }
        static int SayiBul(bool buyukMu, params int[] sayilar)
        {
            if (sayilar.Length == 0)
            {
                return 0;
            }
            int buyuk = sayilar[0], kucuk = sayilar[0];

            Array.Sort(sayilar);

            return buyukMu ? sayilar[sayilar.Length - 1] : sayilar[0];
        }

    }
}


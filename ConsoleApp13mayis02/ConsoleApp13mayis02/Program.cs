using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13mayis02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gönderilen sayılar arasında istenildiğinde en büyüğünü veya seçime göre en küçüğünü bulan metot
            // Array sınıfı kullanmadan yapılacak
            int b = SayiBul(true, 17, 2, 355, 4, 5);
            int k = SayiBul(false, -1, 23, 3, 4, 56);
            Console.WriteLine(k);
            Console.WriteLine(b);

        }

        static int SayiBul(bool buyukMu, params int[] sayilar)
        {

            if (sayilar.Length == 0)
            {
                return 0;
            }
            int buyuk = sayilar[0]; int kucuk = sayilar[0];
            foreach (int i in sayilar)
            {

                if (i > buyuk)
                {
                    buyuk = i;
                }
                if (i < kucuk)
                {
                    kucuk = i;
                }
            }
            return buyukMu ? buyuk : kucuk;


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18mayıs01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan 6 tane metin alalım ve bu aldığımız metinleri tersten tekrardan yazalım
            // asd
            // zxc
            // qwe

            // ***

            // qwe
            // zxc
            // asd

            //burada dizi ve döngü kullanmak yasaktır.
            metinAlVeTerstenYaz(6);

            Console.ReadKey();

        }

        static void metinAlVeTerstenYaz(int adet)
        {
            if (adet <= 0)
            {
                return;
            }
            Console.Write($"{7 - adet}. metni girin: ");
            string metin = Console.ReadLine();
            metinAlVeTerstenYaz(adet - 1);
            Console.WriteLine($"{7 - adet}. metin: {metin}");
        }
    }
}

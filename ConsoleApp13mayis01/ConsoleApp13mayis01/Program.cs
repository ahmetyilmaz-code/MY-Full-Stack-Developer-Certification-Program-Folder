using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13mayis01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gönderilen sayılar arasında istenildiğinde en büyüğünü veya seçime göre en küçüğünü bulan metot
            // Array sınıfı kullanmadan yapılacak
            int max;
            int min;

            Console.Write("Kaç adet sayı gireceksiniz :");
            int adet = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                Console.Write($"{i + 1}. sayıyı girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            enBuyukVeEnKucuk(sayilar, out max, out min);

            Console.WriteLine("Metottan çıkıldıktan sonra sonuçlar:");
            Console.WriteLine($"\nEn büyük sayı: {max}");
            Console.WriteLine($"\nEn küçük sayı: {min}");

        }

        static void enBuyukVeEnKucuk(int[] sayilar, out int max, out int min)
        {
            max = sayilar[0];
            min = sayilar[0];
            for (int i = 1; i < sayilar.Length; i++)
            {

                if (sayilar[i] > max)
                {
                    max = sayilar[i];
                }

                if (sayilar[i] < min)
                {
                    min = sayilar[i];
                }

            }
            char secim = 'b';
            while (true)
            {


                Console.WriteLine("\nEn büyük sayıyı görmek için 'b' tuşuna, en küçük sayıyı görmek için 'k' tuşuna basın.");
                secim = Console.ReadKey().KeyChar;
                if (secim == 'b' || secim == 'B')
                {
                    Console.WriteLine($"\nEn büyük sayı: {max}");
                    break;
                }
                else if (secim == 'k' || secim == 'K')
                {
                    Console.WriteLine($"\nEn küçük sayı: {min}");
                    break;
                }
                else
                {
                    Console.WriteLine("\nGeçersiz seçim.");
                    continue;
                }
            }

        }


    }
}

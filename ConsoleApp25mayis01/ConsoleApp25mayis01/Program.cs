using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25mayis01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan kullanıcının istediği kadar sayıyı alarak ortalama bulan program
            // döngü ve dizi kullanmak yasak

            //kullanıcı negatif değer girerse o değeri saymadan
            //tekrardan aynı indexteki sayıyı isteyelim

            Console.Write("Kaç adet sayı alınacak? :");
            int adet = Convert.ToInt32(Console.ReadLine());
            int toplam = ToplamBul(adet);
            Console.WriteLine($"Ortalama: {toplam / adet}");
            Console.ReadKey();
        }

        static int ToplamBul(int sayiAdedi, int tempAdet = 1)
        {
            if (sayiAdedi == 0)
            {
                return 0;
            }
            Console.Write($"{tempAdet}. Sayı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 0)
            {
                Console.WriteLine("Negatif değer giremezsiniz. Lütfen tekrar deneyin.");
                return ToplamBul(sayiAdedi, tempAdet);
            }

            return sayi + ToplamBul(sayiAdedi - 1, tempAdet + 1);
        }
    }
}

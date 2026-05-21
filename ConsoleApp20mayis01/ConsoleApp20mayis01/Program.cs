using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20mayis01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan kullanıcının istediği kadar sayıyıy
            // alarak ortalama bulan program
            // döngü ve dizi kullanamak yasak

            Console.Write("Kaç adet sayı gireceksiniz: ");
            int adet = Convert.ToInt32(Console.ReadLine());
            int sayi = 0;
            int toplam = 0;
            OrtalamaBul(adet, ref sayi, ref toplam);
            double ortalama = (double)toplam / adet;
            Console.WriteLine($"Ortalama: {ortalama}");
        }
        static void OrtalamaBul(int adet, ref int sayi, ref int toplam)
        {
            if (adet == 0)
            {
                return;
            }
            Console.Write($"{adet}. Sayıyı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            toplam += sayi;
            OrtalamaBul(adet - 1, ref sayi, ref toplam);
        }


    }
}

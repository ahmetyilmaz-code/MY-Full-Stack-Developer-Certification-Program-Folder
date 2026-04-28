using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart2602
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 10 adet sayı alarak
            // bu sayıların içerisindeki en büyük en küçük ve ortalama değeri bulan programı yazalım.

            int SBuyuk = 0, SKucuk = 0, Stoplam = 0, Sortalama = 0;
            Console.WriteLine("Lütfen 10 Adet Sayı Giriniz: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}.Sayıyı Giriniz: ");
                int Sayi = Convert.ToInt32(Console.ReadLine());
                Stoplam += Sayi;
                Sortalama = Stoplam / i;
                if (i == 1)
                {
                    SBuyuk = Sayi;
                    SKucuk = Sayi;
                }
                else
                {
                    if (Sayi > SBuyuk)
                    {
                        SBuyuk = Sayi;
                    }
                    if (Sayi < SKucuk)
                    {
                        SKucuk = Sayi;
                    }
                }
            }
            Console.WriteLine($"En Büyük Sayı: {SBuyuk}");
            Console.WriteLine($"En Küçük Sayı: {SKucuk}");
            Console.WriteLine($"Ortalama: {Sortalama}");
        }
    }
}

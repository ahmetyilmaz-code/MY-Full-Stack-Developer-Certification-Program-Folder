using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart1703
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Continue alıştırma
            // kullanıcıdan en fazla 10 sayı alarak toplam yapan program.
            // kullanıcı negatif değerleri toplama dahil etmeyen program
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}.Sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 0)
                {
                    Console.WriteLine("Negatif değer girdiğiniz için program bu değeri yok saydı");
                    continue;
                }
                toplam += sayi;
            }
            Console.WriteLine($"Toplam: {toplam}");
        }
    }
}

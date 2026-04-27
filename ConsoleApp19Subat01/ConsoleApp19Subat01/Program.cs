using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subat1901
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan 2 sayı alarak büyük sayıdan kücük sayıyı
            // çıkartarak sonucu ekrana yazdıran program

            Console.WriteLine("Lütfen 2 sayı giriniz:");
            Console.Write("Birinci sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
            }
            else if (sayi2 > sayi1)
            {
                Console.WriteLine("Sonuç: " + (sayi2 - sayi1));
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayılar eşit.");

            }
        }
    }
}
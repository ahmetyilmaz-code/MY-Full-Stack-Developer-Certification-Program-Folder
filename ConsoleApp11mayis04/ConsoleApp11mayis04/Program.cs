using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11mayis04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // faktoriyel hesaplayan metot for döngüsü kullanmadan
            Faktoriyel(6, 1);

            Console.ReadKey();
        }

        static void Faktoriyel(int sayi, int sonuc)
        {
            if (sayi == 0 || sayi == 1)
            {
                return;
            }
            sonuc *= sayi;
            Faktoriyel(--sayi, sonuc);
            Console.WriteLine(sonuc);
        }
    }
}
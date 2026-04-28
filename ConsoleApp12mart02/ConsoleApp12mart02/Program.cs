using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart1202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // fibonacci
            // 1 1 2 3 5 8 13 21 34 55 ...
            // kullanıcıdan bir sayı alarak o sayıdan büyük olan indexe kadar fibonacci yazdıran program
            // Sayı : 5
            // 1 1 2 3 5
            // Sayı : 7
            // 1 1 2 3 5 8

            Console.WriteLine("Girilen sayıdan büyük olan indexe kadar fibonacci yazdıran program");

            Console.Write("Sayı : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int a = 1, b = 1;

            while (a <= sayi)
            {
                Console.Write($"{a} ");
                int c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();

        }
    }
}

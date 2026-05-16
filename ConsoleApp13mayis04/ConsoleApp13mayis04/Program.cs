using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13mayis04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // fibonacci
            // parametrede gönderilen sayıya kadar veya gönderilen değerden sonraki ilk büyük sayıya kadar
            // 1, 1, 2, 3, 5, 8,
            // kendini döndüren metotolarak yapılacak.
            Fibonacci(7);

        }
        static void Fibonacci(int sayi)
        {
            int a = 1, b = 1;
            int c = 0;
            if (sayi == 1)
            {
                Console.Write($"{a} ");
            }
            else if (sayi <= 0)
            {
                Console.WriteLine("Fibonacci en küçük 1 den başlar");
            }
            else
            {
                Console.Write($"{a} ");
                Console.Write($"{b} ");
                while (c < sayi)
                {
                    c = a + b;
                    Console.Write($"{c} ");
                    a = b;
                    b = c;
                }


            }
        }
    }
}


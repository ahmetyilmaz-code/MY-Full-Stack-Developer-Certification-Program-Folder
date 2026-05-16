using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13mayis05
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
        static void Fibonacci(int son, params int[] sayilar)
        {
            if (sayilar.Length == 0)
            {
                Fibonacci(son, 0, 1);
                return;
            }

            int a = sayilar[0];
            int b = sayilar[1];
            Console.Write($"{b} ");
            if (b < son)
            {
                int c = a + b;
                Fibonacci(son, b, c);
            }

        }
    }
}


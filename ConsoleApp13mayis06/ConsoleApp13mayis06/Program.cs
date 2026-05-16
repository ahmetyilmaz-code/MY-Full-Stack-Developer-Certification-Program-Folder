using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13mayis06
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // fibonacci
            // parametrede gönderilen sayıya kadar veya gönderilen değerden sonraki ilk büyük sayıya kadar
            // 1, 1, 2, 3, 5, 8,
            // kendini döndüren metotolarak yapılacak.
            //fibnacciden çıkan elemanlar yeni dizide olcak
            int adet = FibonacciAdet(10, 0, 1);
            int[] dizi = new int[adet];
            FibonacciDoldur(10, dizi, 0, 0, 1);
            foreach (int sayi in dizi)
            {
                Console.Write(sayi + " ");
            }

        }

        static int FibonacciAdet(int sinir, int a, int b)
        {
            if (b > sinir)
            {
                return 0;
            }
            int c = a + b;
            return 1 + FibonacciAdet(sinir, b, c); // +1 çünkü [0] da ekledik
        }

        static void FibonacciDoldur(int sinir, int[] dizi, int index, int a, int b)
        {
            // sinir: üst sınır
            // dizi: doldurulacak dizi
            // index: dizideki konum
            // a: ilk sayı
            // b: ikinci sayı

            if (b > sinir)
            {
                return;
            }
            dizi[index] = b;
            int c = a + b;
            FibonacciDoldur(sinir, dizi, index + 1, b, c);
        }
    }
}



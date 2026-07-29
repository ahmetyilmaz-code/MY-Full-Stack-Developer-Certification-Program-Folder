using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25mayis02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hesapla{} sınıfında topla[} carp[] cikar[] bol[] işlemlerini yapan metot
            // her metoto iki int parametre alarak işlem yapar
            int a = Hesapla.topla(5, 10);
            int b = Hesapla.carp(5, 10);
            int c = Hesapla.cikar(10, 5);
            int d = Hesapla.bol(10, 5);

            Console.WriteLine("Hesapla sınıfı sonuçları:");
            Console.WriteLine($"Topla: {a}");
            Console.WriteLine($"Carp: {b}");
            Console.WriteLine($"Cikar: {c}");
            Console.WriteLine($"Bol: {d}");

            Hesapla2 hesapla2 = new Hesapla2();
            int e = hesapla2.topla(5, 10);
            int f = hesapla2.carp(5, 10);
            int g = hesapla2.cikar(10, 5);
            int h = hesapla2.bol(10, 5);

            Console.WriteLine("Hesapla2 sınıfı sonuçları:");
            Console.WriteLine($"Topla: {e}");
            Console.WriteLine($"Carp: {f}");
            Console.WriteLine($"Cikar: {g}");
            Console.WriteLine($"Bol: {h}");
            Console.ReadKey();
        }
    }
    class Hesapla
    {
        public static int topla(int a, int b)
        {
            return a + b;
        }
        public static int carp(int a, int b)
        {
            return a * b;
        }
        public static int cikar(int a, int b)
        {
            return a - b;
        }
        public static int bol(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a / b;
        }

    }
    class Hesapla2
    {
        public int topla(int a, int b)
        {
            return a + b;
        }
        public int carp(int a, int b)
        {
            return a * b;
        }
        public int cikar(int a, int b)
        {
            return a - b;
        }
        public int bol(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a / b;
        }

    }
}

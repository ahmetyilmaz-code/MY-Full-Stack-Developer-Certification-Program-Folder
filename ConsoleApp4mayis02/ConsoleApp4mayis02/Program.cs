using System;

namespace ConsoleAppDers4mayis02
{
    class Program
    {
        static void Main(string[] args)
        {
            // dorgen alan hesaplayan program
            // iki overload
            // eğer metotta 1 değer gönderirsek yükseklik = genişlik
            // eğer metotta 2 değer gönderirsek ilk yükseklik ikinci genişlik olsun

            Alan(10);
            Console.WriteLine("\n+++++++++");
            Alan(10, 20);

            Console.ReadKey();
        }

        static void Alan(int s1)
        {
            int s2 = s1;
            int sonuc = s1 * s2;
            Console.Write(sonuc);

        }
        static void Alan(int s1, int s2)
        {
            int sonuc = s1 * s2;
            Console.Write(sonuc);

        }



    }
}

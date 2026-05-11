using System;

namespace ConsoleAppDers4mayıs01
{
    class Program
    {
        static void Main(string[] args)
        {
            // bir diziyi büyükten küçüğe sıralayan metot
            Console.Write("Dizinin eleman sayısını giriniz : ");
            int adet = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[adet];

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write($"{i + 1}. eleman: ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Sıralanmamış dizi:");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine($"{i + 1}. eleman: {dizi[i]}");
            }

            SiralaDizi(dizi);
            Console.WriteLine("------------------");
            Console.WriteLine("Büyükten Küçüğe Sıralanmış dizi:");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine($"{i + 1}. eleman: {dizi[i]}");
            }

            Console.ReadKey();
        }

        static void SiralaDizi(int[] dizi)
        {
            Array.Sort(dizi);
            Array.Reverse(dizi);
        }



    }
}

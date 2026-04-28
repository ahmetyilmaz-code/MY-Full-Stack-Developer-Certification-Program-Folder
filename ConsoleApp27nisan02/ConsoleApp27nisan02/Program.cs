using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27Nisan02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kuvvet ve taban değerlerini alarak üssü hepaplayan
            // ve sonucu geri döndüren metot
            Console.Write("Taban değer: ");
            int Taban = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kuvvet değeri: ");
            int Kuvvet = Convert.ToInt32(Console.ReadLine());
            int sonuc = Power(Taban, Kuvvet);
            Console.WriteLine($"Sonuc :{sonuc}");
            Console.ReadKey();
        }
        static int Power(int taban, int kuvvet)
        {
            int sonuc = 1;
            for (int i = 0; i < kuvvet; i++)
            {
                sonuc *= taban;
            }
            return sonuc;
        }


    }
}

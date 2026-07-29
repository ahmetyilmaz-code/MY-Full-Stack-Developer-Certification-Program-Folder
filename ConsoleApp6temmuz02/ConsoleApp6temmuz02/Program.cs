using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6temmuz02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0;
            int sayi1 = Sayial();
            int sayi2 = Sayial();


        }
        public static int Sayial()
        {
            int sayi = 0;
            try
            {
                Console.WriteLine("Sayı :");
                sayi = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {

            }


            return sayi;
        }


    }
}


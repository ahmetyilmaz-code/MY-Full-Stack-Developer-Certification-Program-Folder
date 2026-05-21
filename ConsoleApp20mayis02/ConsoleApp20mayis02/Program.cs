using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20mayis02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ornek.DenemeStatic(); // Static methoda sınıf adıyla erişilir.

            Ornek ornek = new Ornek();// Non-static metoda erişmek için o sınıfın bir nesnesi oluşturulur.
            ornek.DenemeNonStatic();// Non-static metoda nesne adıyla erişilir.

            Ornek.sayi2 = 10; // Static fielda sınıf adıyla erişilir.
            int sayi = ornek.sayi1; // Non-static fielda nesne adıyla erişilir.
            Console.WriteLine(sayi);
            // Console.WriteLine(Ornek.sayi1); // Non-static fielda sınıf adıyla erişilemez.
            // Hata verir.

            ornek.sayi1 = 5;
            int sayi2 = ornek.sayi1;
            Console.WriteLine(sayi2);
            Console.WriteLine(Ornek.sayi2); // Static fielda sınıf adıyla erişilir.

            Console.ReadKey();
        }
    }

    class Ornek
    {

        public int sayi1;
        public static int sayi2;



        public static void DenemeStatic()
        {
            Console.WriteLine("Deneme Static");
        }

        public void DenemeNonStatic()
        {
            Console.WriteLine("Deneme Non-Static");
        }
    }





}

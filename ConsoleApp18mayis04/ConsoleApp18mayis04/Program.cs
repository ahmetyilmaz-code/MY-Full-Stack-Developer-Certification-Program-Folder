using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18mayıs04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
            Program.deneme();

            Ornek2.deneme();
            //Ornek2 deki deneme metodu public olmalıki başka sınıftan çağırabilinsin.
            // metot public değilse private otomatik olarak olur.


        }
        static void deneme()
        {
            Console.WriteLine(" sınıfı deneme");
        }
        class Ornek
        {

        }
        // sınıflar bu şekilde tanımlanır.

        // işlemler sınıf içindeki metotlarda yapılabişir if for while gibi
        // yapılar sınıf içinde tanımlanmaz. sadece metotlarda tanımlanır.       
    }

    class Ornek2
    {
        public static void deneme()
        {
            Console.WriteLine("Ornek2 sınıfı deneme");
        }
    }
}

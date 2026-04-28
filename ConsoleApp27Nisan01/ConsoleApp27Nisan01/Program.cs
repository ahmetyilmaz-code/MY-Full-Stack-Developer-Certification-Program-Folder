using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27Nisan01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // iki parametre alan bir metot 
            // bu metot biri char biri int olmak üzere iki parametre alır
            // aldığı char değeri int değeri kadar ekrana yanyana yazan ve bir alt satıra gider.
            Console.Write("Bir işarete basınız: ");
            char a = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Bir Sayı Giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());
            EkranaYaz(a, b);

            Console.ReadKey();
        }
        static void EkranaYaz(char tus, int sayı)
        {
            for (int i = 0; i < sayı; i++)
            {
                Console.Write(tus);
            }
            Console.WriteLine();
        }



    }
}

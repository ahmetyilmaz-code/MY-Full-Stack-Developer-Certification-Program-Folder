using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subat2602
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Onaylamak için O tuşuna basınız. Red için R tuşuna basınız.");
            Console.WriteLine("=>");
            char cevap = Console.ReadKey().KeyChar;

            if (cevap == 'O' || cevap == 'o')
            {
                Console.WriteLine("\nOnaylandı.");
            }
            else if (cevap == 'R' || cevap == 'r')
            {
                Console.WriteLine("\nRed edildi.");
            }
            else
            {
                Console.WriteLine("\nGeçersiz giriş.");
            }

            switch (cevap)
            {
                case 'O':
                case 'o':
                    Console.WriteLine("\nOnaylandı.");
                    break;
                case 'R':
                case 'r':
                    Console.WriteLine("\nRed edildi.");
                    break;
                default:
                    Console.WriteLine("\nGeçersiz giriş.");
                    break;
            }




        }
    }
}

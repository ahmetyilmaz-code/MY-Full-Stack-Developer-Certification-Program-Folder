using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11mayis01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //params ile bir metotda aynı türde istenilen sayıda parametre alabiliriz.
            Metot(1, 2, 12);
            Metot(2, 33);

            Console.ReadKey();
        }
        static void Metot(params int[] sayilar)
        {
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;

namespace ConsoleAppDers10mart02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            For döngüsü ile aşağadaki gibi üçgen çizen program

             *
            ***
           *****
          *******
         *********
          *******
           *****
            ***
             * 
             
             */

            Console.Write("Kaç basamak: ");
            int basamak = Convert.ToInt32(Console.ReadLine());



            for (int i = 1; i <= basamak; i++)
            {
                for (int j = 1; j <= basamak - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= basamak; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * (basamak - i) + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }




            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8temmuz06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B<int> b = new B<int>();
            b.dnmOzllik1 = 1;

            Console.ReadLine();
        }


        class B<U> where U : struct
        {
            public U dnmOzllik1 { get; set; }
        }
    }
}


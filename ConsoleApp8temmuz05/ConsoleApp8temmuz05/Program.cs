using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8temmuz05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B<string> b = new B<string>();
            b.dnmOzllik1 = "1";

            Console.ReadLine();
        }

        interface IA<T>
        {
            T dnmOzllik1 { get; set; }
        }
        class B<U> : IA<U>
        {
            public U dnmOzllik1 { get; set; }
        }
    }
}


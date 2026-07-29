using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8temmuz03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dnm<int, char> dnm = new dnm<int, char>();
            dnm.dnmOzllik1 = 12;
            dnm.dnmOzllik2 = 'u';

            Console.ReadLine();
        }

        class dnm<T, U>
        {
            public T dnmOzllik1 { get; set; }
            public U dnmOzllik2 { get; set; }

        }

    }
}


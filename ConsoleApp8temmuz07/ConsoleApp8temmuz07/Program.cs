using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8temmuz07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B<A> b = new B<A>();
            b.dnmOzllik1 = new A();

            Console.ReadLine();
        }
        interface Iinterface
        {

        }
        class A : Iinterface
        {

        }
        class B<U> where U : Iinterface
        {
            public U dnmOzllik1 { get; set; }
        }
    }
}


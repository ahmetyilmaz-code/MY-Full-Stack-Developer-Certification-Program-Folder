using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8temmuz02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dnm<int> dnm = new dnm<int>();
            dnm.dnmOzllik = 120;
            int sayi = dnm.DnmMetot();

            dnm<string> dnm1 = new dnm<string>();
            dnm1.dnmOzllik = "Yazi";
            string yazi = dnm1.DnmMetot();

            Console.ReadLine();
        }

        class dnm<T>
        {
            public T dnmOzllik { get; set; }
            public T DnmMetot()
            {
                return dnmOzllik;
            }
        }

    }





}


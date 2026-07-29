using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1haziran04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deneme d1 = new Deneme();
            Deneme d2 = new Deneme(5);
            Deneme d3 = new Deneme("Merhaba");

            Console.ReadKey();
        }
    }

    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme sınıfının parametresiz constructor'ı çalıştı.");
        }
        public Deneme(int a)
        {
            Console.WriteLine("Deneme sınıfının bir int parametreli constructor'ı çalıştı.");
        }

        public Deneme(string a)
        {
            Console.WriteLine("Deneme sınıfının bir string parametreli constructor'ı çalıştı.");
        }
    }


}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1haziran02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            deneme d = new deneme();
            Console.ReadKey();
        }
    }

    class deneme
    {
        public deneme()
        {
            Console.WriteLine("deneme sınıfının yapıcı metodu çalıştı");
        }
    }


}



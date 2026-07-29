using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3haziran01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            metot1();
            Console.ReadKey();
        }
        static void metot1()
        {
            Console.WriteLine("metot1 çalıştı");
            deneme d1 = new deneme();
            Console.WriteLine("metot1 bitti");
        }
    }

    class deneme
    {
        ~deneme()
        {
            Console.WriteLine("yıkıcı(destructor) metot  çalıştırıldı");
        }
    }
}



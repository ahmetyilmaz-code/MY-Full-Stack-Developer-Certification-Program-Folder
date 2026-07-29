using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp24haziran04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sayilar = "12,23,4,5,,,34,6,61,,37";
            string[] _sayilar = sayilar.Split(',');
            int toplam = 0;
            foreach (string _say in _sayilar)
            {
                if (!string.IsNullOrEmpty(_say))
                {
                    toplam += Convert.ToInt32(_say);
                }

            }
            Console.WriteLine(toplam);
            Console.ReadKey();
        }

    }
}

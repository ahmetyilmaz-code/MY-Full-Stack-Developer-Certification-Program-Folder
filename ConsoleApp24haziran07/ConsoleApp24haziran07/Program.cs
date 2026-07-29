using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp24haziran07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sayilar = "12,23,4,5,,,34,6,61,,37";
            string filtre = @",+";
            Regex regex = new Regex(filtre);
            string[] _sayilar = regex.Split(sayilar);
            int toplam = 0;
            foreach (var item in _sayilar)
            {
                toplam += Convert.ToInt32(item);
            }


            Console.WriteLine(toplam);

            Console.ReadKey();
        }

    }
}

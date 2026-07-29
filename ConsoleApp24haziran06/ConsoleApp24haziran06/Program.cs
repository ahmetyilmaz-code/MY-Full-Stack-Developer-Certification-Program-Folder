using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp24haziran06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin = "Ahmet Iban: TR 1234 1234 1234 23";
            string filtre = @"TR \d{4} \d{4} \d{4} \d{2}";
            Regex regex = new Regex(filtre);
            string sansurlu = regex.Replace(metin, "********");
            Console.WriteLine(sansurlu);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp24haziran05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sayilar = "12,23,4,5,,,34,6,61,,37";
            string filtre = @"\d+";
            Regex regex = new Regex(filtre);
            Match match = regex.Match(sayilar);
            int toplam = 0;
            while (match.Success)
            {
                toplam += Convert.ToInt32(match.Value);
                match = match.NextMatch();
            }
            Console.WriteLine(toplam);

            Console.ReadKey();
        }

    }
}

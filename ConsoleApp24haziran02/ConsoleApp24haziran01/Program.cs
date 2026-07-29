using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp24haziran02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string filtreleri
            // IBAN filtresi
            // TR 1234 1234 1234 12
            // TR \d{4} \d{4} \d{4} \d{2}

            string metin = "Merhaba iban bilgim TR 1234 1234 1234 12";
            string filtre = @"TR \d{4} \d{4} \d{4} \d{2}";
            Console.WriteLine(metin);
            Regex regex = new Regex(filtre); // Regex sınıfı eşleşme yapmak için kullanılan bir sınıftır.
            Match match = regex.Match(metin); // Match sınıfı regex sınıfından eşleşen değerleri almaktadır.
            while (match.Success) // match.Success true ise eşlesşen değer var demektir
            {
                Console.WriteLine(match.Value); // match.Value eşleşmenin yapıldığı değer.
                match = match.NextMatch(); // match.NextMatch(); bir sonraki eşleşmeye geç.
            }
            Console.ReadKey();
        }
    }
}

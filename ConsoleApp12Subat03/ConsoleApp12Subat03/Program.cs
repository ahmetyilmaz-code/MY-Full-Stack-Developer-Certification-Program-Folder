using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12Subat03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = 10, s2 = 20, s3 = 30;
            s3 = -s1; // s3 is now -10
            s3 = s3 + s2; // s3 is now 10

            string metin1 = "Merhaba";
            string metin2 = "Ben";
            string metin3 = "C# Programlama Dili";
            string sonuc = metin1 + " " + metin2 + " " + metin3; // sonuc is "Merhaba Ben C# Programlama Dili"
            Console.WriteLine("{0} {1} {2}", metin1, metin2, metin3); // Output: "Merhaba Ben C# Programlama Dili"
            string sonuc2 = $"{metin1}, {metin2}, {metin3}"; // sonuc2 is "Merhaba, Ben, C# Programlama Dili"

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17Subat01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = 10, s2 = 20, s3 = 30;
            bool sonuc = s1 != s2 || s1 < s3; // true || true => true
            Console.WriteLine(sonuc);
            sonuc = s2 > s3 || s1 != s2; // false || true => true
            Console.WriteLine(sonuc);
            sonuc = s2 > s3 || s1 == s2; // false || false => false
            Console.WriteLine(sonuc);

            s1 = 10; s2 = 20;
            s1 += s2;
            s1 += s2;
            Console.WriteLine(s1);
        }
    }
}

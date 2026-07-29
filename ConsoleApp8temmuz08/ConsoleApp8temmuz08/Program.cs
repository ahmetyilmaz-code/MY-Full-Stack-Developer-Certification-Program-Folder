using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8temmuz08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int? sayi = 10;
            sayi = null;

            Nullable<int> sayi2 = 10;
            sayi = null;

            int? sayi3 = sayi == null ? 0 : sayi;
            int sayi4 = sayi ?? 0;
            // ?? operatörü eğer değişken null ise sağdaki değeri 
            // null değil ise değişkenin kendi değerini döndürür
            Console.ReadLine();
        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1haziran01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            deneme.sayi = 5; // set bloğu çalışır
            int a = deneme.sayi; // get bloğu çalışır
            Console.WriteLine(a); // get bloğundan dönen değeri ekrana yazdırır


            Console.WriteLine(deneme.sayi);
            deneme.sayi = 10;
            Console.WriteLine(deneme.sayi);
            deneme.sayi = -50;
            Console.WriteLine(deneme.sayi);
            Console.ReadKey();
        }
    }

    class deneme
    {
        private static int _sayi { get; set; }
        public static int sayi //
        {
            set // set bloğu, sayi property'sine değer atandığında çalışır
            {
                Console.WriteLine("sayi set edildi");
                int deger = value;// set bloğunda atanan değeri bir değişkene atayabiliriz
                if (deger >= 0)
                {
                    _sayi = value;
                }
                else
                {
                    Console.WriteLine("Negatif değer ataması yapılamaz");
                }
            }
            get // get bloğu, sayi property'sine erişildiğinde çalışır
            {
                Console.WriteLine("sayi get edildi");
                if (_sayi == 0)
                {
                    return -1; // sayi property'si 0 ise -1 döndürür
                }
                return _sayi;
            }
        }
    }


}



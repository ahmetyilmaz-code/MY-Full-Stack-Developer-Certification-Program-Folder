using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25mayis04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hesapla{} sınıfında topla[} carp[] cikar[] bol[] işlemlerini yapan metot
            // her metoto iki int parametre alarak işlem yapar

            // hesapla sınıfı içinde iki tane özellik olacak ve sayi1 sayi2 adında
            //bu iki özelliği değer ataması yapılacak ve diğer tüm metotlar bu sayılar üzerinden işlem yapacaklar

            hesapla h1 = new hesapla();
            h1.s1 = 10;
            hesapla h2 = new hesapla();
            h2.s2 = 10;
            int toplam = h1.s1 + h2.s2;
            Console.WriteLine(toplam);
            Console.ReadKey();
        }
    }

    class hesapla
    {
        public int s1;
        public int s2;
    }



}

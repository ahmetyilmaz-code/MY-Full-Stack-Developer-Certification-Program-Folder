using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1haziran03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kişi sınıfında bir nesne oluşturulacak ise mutlaka TC değeri olmalı
            Kisi kisi1 = new Kisi("12345678901"); // TC değeri zorunlu hale geldi

            Console.ReadKey();
        }
    }

    class Kisi
    {
        public Kisi(string TC) // Constructor (yapıcı metot) ile TC değeri zorunlu hale getirildi
        {
            this.TC = TC;
        }
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }



    }


}



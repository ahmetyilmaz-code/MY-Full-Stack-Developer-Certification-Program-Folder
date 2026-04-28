using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27Nisan03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan sayı alan metot
            //kullanıcı sayısal bir tuş haricinde bir tuşa basarsa hata vererek
            //son bastığı tuşu saymayan program
            //kullanıcı enter tuşuna basana kadar değer alsın
            //145a
            //sadece sayılsal değer giriniz...
            //14587D
            //sadece sayılsal değer giriniz...
            //14587

            int sayı = SayıAl();
            Console.WriteLine(sayı);
            Console.ReadKey();
        }
        static int SayıAl()
        {
            string sonuc = "";
            while (true)
            {
                Console.Clear();
                Console.Write($"Sayı: {sonuc}");
                var Tus = Console.ReadKey();
                if (Tus.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (Tus.KeyChar < '0' || Tus.KeyChar > '9')
                {

                    Console.WriteLine("\nSadece sayılsal değer giriniz...\n");
                    Console.ReadKey();
                }
                else
                {
                    sonuc += Tus.KeyChar;
                }

            }
            if (sonuc == "")
            {
                return 0;
            }
            else
            {

                int sayı = Convert.ToInt32(sonuc);
                return sayı;
            }

        }





    }
}

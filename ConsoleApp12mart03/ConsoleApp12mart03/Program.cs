using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart1203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan şifre ve kullanıcı adı isteyelim ve iki değer doğru girene kadar kullanıcıdan değerleri alalım
            // Kullanıcı Adı : admin             // Şifre : 123

            // Kullanıcı Adı : Asa
            // Şifre : 12
            // Kullanıcı bilgileri hatalı

            // Kullanıcı Adı : admin
            // Şifre : 123
            // Kullanıcı bilgileri doğru Hoşgeldiniz..

            string username = "admin", password = "123";
            while (true)
            {
                string KullaniciAdi, Sifre;
                Console.Write("Kullanıcı Adı : ");
                KullaniciAdi = Console.ReadLine();
                Console.Write("Şifre : ");
                Sifre = Console.ReadLine();
                if (KullaniciAdi == username && Sifre == password)
                {
                    Console.WriteLine("Kullanıcı bilgileri doğru Hoşgeldiniz..");
                    break;
                }
                else if (KullaniciAdi == username && Sifre != password)
                {
                    Console.WriteLine("Kullanıcı şifresi hatalı");
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı hatalı");
                }

            }
            Console.ReadKey();

        }
    }
}

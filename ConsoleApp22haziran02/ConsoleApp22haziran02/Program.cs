using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22haizran02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ödev
            // Kullanici adında bir sınıf olacak.
            // Bu sınıfta KullanıcıAdı, Şifre ve KullanıcıNumarası olacak şekilde 3 özellik olacak.
            // Kullanici kullanici = " BehlulMese ,1234, 9019   ";
            // kullanıcı.KullanıcıAdı = "BehlulMese"
            // kullanıcı.Sifre = "1234"
            // string kullanıcıBilgileri = (string)kullanici;
            // "Kullanıcı Adı: BehlulMese\nŞifre: 1234\nKullanıcı Numarası: 9019"

            Kullanici kullanici = " BehlulMese ,1234, 9019   ";
            Console.WriteLine(kullanici.KullaniciAdi);
            Console.WriteLine(kullanici.Sifre);
            Console.WriteLine(kullanici.KullaniciNumarasi);


            string kullaniciBilgileri = (string)kullanici;
            Console.WriteLine();
            Console.WriteLine(kullaniciBilgileri);



        }

        class Kullanici
        {
            public string KullaniciAdi { get; set; }
            public string Sifre { get; set; }
            public string KullaniciNumarasi { get; set; }

            // string -> Kullanici
            public static implicit operator Kullanici(string deger) // implicit - bilinçli 
            {
                string[] bilgiler = deger.Split(',');

                return new Kullanici
                {
                    KullaniciAdi = bilgiler[0].Trim(),
                    Sifre = bilgiler[1].Trim(),
                    KullaniciNumarasi = bilgiler[2].Trim()
                };
            }


            // Kullanici -> string
            public static explicit operator string(Kullanici kullanici) // explicit - bilinçsiz
            {
                return $"Kullanıcı Adı: {kullanici.KullaniciAdi}\nŞifre: {kullanici.Sifre}\nKullanıcı Numarası: {kullanici.KullaniciNumarasi}";
            }

        }



    }
}

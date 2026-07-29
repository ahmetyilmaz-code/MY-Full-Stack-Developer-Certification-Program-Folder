using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp24haziran03
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


            // Bir tane Kullanıcı sınıfı nesnesi olsun
            // Ad , Soyad , telefonNumarasi olsun string
            string metin2 = "Behlül MEŞE 0555 234 67 12 Uğur Pekmezci 0543 123 45 65 Ahmet Yılmaz 0567 343 56 34";
            // yukarıdaki metni filtreleyerek 3 adet kullanici nesnesi oluştur.
            string filtre2 = @"\D+ \D+ \d{4} \d{3} \d{2} \d{2}";

            Kullanici[] kullanicilar = new Kullanici[3];
            Regex regex2 = new Regex(filtre2);
            Match match2 = regex2.Match(metin2);
            int index = 0;
            while (match2.Success)
            {
                kullanicilar[index] = match2.Value;
                match2 = match2.NextMatch();
                index++;
            }


            Console.ReadKey();
        }

        class Kullanici
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string TelefonNumarasi { get; set; }

            public static implicit operator Kullanici(string deger)
            {
                char[] ayraclar = { ' ' };
                string[] degerler = deger.Split(ayraclar, 3);
                return new Kullanici
                {
                    Ad = degerler[0],
                    Soyad = degerler[1],
                    TelefonNumarasi = degerler[2],

                };
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15haziran01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OgrenciYapı ogrenciYapı = new OgrenciYapı();
            ogrenciYapı.Ad = "Ahmet";
            ogrenciYapı.Soyad = "Yılmaz";
            ogrenciYapı.OgrenciNo = 12345;
            YapiOgrenci(ogrenciYapı); // Yapı örneği bir metoda parametre olarak geçirildiğinde,
                                      // yapının bir kopyası oluşturulur ve
                                      // metodun içinde yapılan değişiklikler orijinal yapıyı etkilemez.
            Console.WriteLine("Öğrenci Bilgileri (Yapı):");
            Console.WriteLine($"Öğrenci Adı: {ogrenciYapı.Ad}\nSoyadı: {ogrenciYapı.Soyad}\nÖğrenci No: {ogrenciYapı.OgrenciNo}");


            OgrenciSinif ogrenciSinif = new OgrenciSinif();
            ogrenciSinif.Ad = "Ahmet";
            ogrenciSinif.Soyad = "Yılmaz";
            ogrenciSinif.OgrenciNo = 12345;
            SinifOgrenci(ogrenciSinif); // Sınıf örneği bir metoda parametre olarak geçirildiğinde,
                                        // sınıfın referansı metodun içine geçirilir ve
                                        // metodun içinde yapılan değişiklikler orijinal sınıfı etkiler.
            Console.WriteLine("\nÖğrenci Bilgileri (Sınıf):");
            Console.WriteLine($"Öğrenci Adı: {ogrenciSinif.Ad}\nSoyadı: {ogrenciSinif.Soyad}\nÖğrenci No: {ogrenciSinif.OgrenciNo}");

            Console.ReadKey();
        }

        static void SinifOgrenci(OgrenciSinif ogrenciSinif)
        {
            ogrenciSinif.OgrenciNo = 0;
        }
        static void YapiOgrenci(OgrenciYapı ogrenciYapı)
        {
            ogrenciYapı.OgrenciNo = 0;
        }


        // (sturct) Yapılar değer tipleridir ve bellekte stack üzerinde saklanır.
        // Bu nedenle, bir yapı örneği bir metoda parametre olarak geçirildiğinde,
        // yapının bir kopyası oluşturulur ve
        // metodun içinde yapılan değişiklikler orijinal yapıyı etkilemez.
        struct OgrenciYapı
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int OgrenciNo { get; set; }
        }

        class OgrenciSinif
        {

            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int OgrenciNo { get; set; }
        }


    }
}
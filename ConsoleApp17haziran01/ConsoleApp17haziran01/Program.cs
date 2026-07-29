using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17haziran01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] karakterler = { 'K', 'O', 'D', 'İ', 'T' };

            string yazi1 = new string(karakterler);
            Console.WriteLine(yazi1);

            string yazi2 = new string('*', 50); // 50 tane * dan oluşan string oldu
            Console.WriteLine(yazi2);


            string yazi11 = "Yazılım";
            string yazi22 = "Dersleri";
            string birlesim = string.Concat(yazi11, " ", yazi22); // parametreden gönderilen stringleri birleştirerek tek bir string yapar.
            Console.WriteLine(birlesim);



            Console.WriteLine("Bir değer gir: ");
            string deger = Console.ReadLine();
            bool degerVarMi = string.IsNullOrEmpty(deger); // gelen string null veya boş string ("") mi diye kontrol eder ve
                                                           // true false değer döner.
            degerVarMi = string.IsNullOrWhiteSpace(deger); // Burada sadece boşluk olan stringlerde true değerini döndürür.

            string yazi = "Deneme yapıyorum";
            int baslangicDegeri = yazi.IndexOf('y'); // içinde y karakteri var mı varsa
                                                     // kaçıncı sırada eğer aranan değer yoksa negatif değer döner.
            Console.WriteLine(baslangicDegeri);
            baslangicDegeri = yazi.IndexOf("me");
            Console.WriteLine(baslangicDegeri);
            char karakter = yazi[2];




            string yazi3 = "Deneme yapıyorum";
            baslangicDegeri = yazi3.IndexOf('e'); // ilk e karakteri kaçıncı indexte
            Console.WriteLine(baslangicDegeri);
            int sonBulunanDeger = yazi3.LastIndexOf("e"); // son e karakteri kaçıncı indexte,
                                                          // eğer aranan değer yoksa negatif döner IndexOf gibi
            Console.WriteLine(sonBulunanDeger);




            yazi = "Deneme yapıyorum";
            bool basliyorMu = yazi.StartsWith("Deneme"); // string ilgili ifade ile mi başlıyor? 
            Console.WriteLine(basliyorMu);
            basliyorMu = yazi.StartsWith("yapıyorum");
            Console.WriteLine(basliyorMu);




            yazi = "Deneme yapıyorum";
            bool bitiyorMu = yazi.EndsWith("Deneme"); // string ilgili ifade ile mi bitiyor? 
            Console.WriteLine(bitiyorMu);
            bitiyorMu = yazi.EndsWith("yapıyorum");
            Console.WriteLine(bitiyorMu);


            string Ad = "    Behlül    ";
            string Soyad = "   MEŞE  ";
            string bosluksuzAd = Ad.Trim(); // Trim string başındaki ve sonundaki boşlukları siler.
            string bosluksuzSoyad = Soyad.Trim();
            Console.WriteLine($"{bosluksuzAd} {bosluksuzSoyad}.");



            string[] Menu = { "Çorba", "Salata", "Pirinç Pilavı", "Tavuk Yemeği" };
            for (int i = 0; i < Menu.Length; i++)
            {
                string menuItem = Menu[i].PadRight(15); // PadRight string sonuna top uzunluk parametrede belirtilen adette olana kadar boşluk ekler
                Console.WriteLine($"{menuItem} |");
            }
            Console.WriteLine(new string('*', 50));
            for (int i = 0; i < Menu.Length; i++)
            {
                string menuItem = Menu[i].PadRight(15, '.'); // PadRight string sonuna top uzunluk parametrede belirtilen adette ikinci parametrede olan char ı ekler
                Console.WriteLine($"{menuItem} |");
            }



            yazi = "C# derleri string bölme";
            string[] bolunmus = yazi.Split(); // stringi boşluklarına göre böler ve bir string dizisi oluşturur.
            foreach (string line in bolunmus)
            {
                Console.WriteLine(line);
            }



            yazi = "C#,derleri,string,bölme";
            bolunmus = yazi.Split(','); // stringi parametrede gönderilen char karaktere göre böler göre böler ve bir string dizisi oluşturur. oluşan dizide parametereden gönderilen karakter silinir.
            foreach (string line in bolunmus)
            {
                Console.WriteLine(line);
            }


            yazi = "C#,derleri,string.bölme";
            char[] ayraclar = { ',', '.' };
            bolunmus = yazi.Split(ayraclar); // dizi içindeki elemanlara göre bölüm işlemini yapar.
            foreach (string line in bolunmus)
            {
                Console.WriteLine(line);
            }


            Console.Write("Evet/Hayır => ");
            string _cevap = Console.ReadLine();
            string cevap = _cevap.ToLower(); // string içindeki tüm karakterlerin küçük oldu yeni bir string oluşturur.
            cevap = _cevap.ToUpper(); // string içindeki tüm karakterlerin BÜYÜK oldu yeni bir string oluşturur.



            string tarih = "17/06/2026";
            Console.WriteLine(tarih);
            string noktaTarih = tarih.Replace('/', '.'); // ilk parametrede gönderilen char ı ikinci parameterede gönderilen char ile değiştirir.
            Console.WriteLine(noktaTarih);



            string metin = "js çok güzel bir programlama dilidir. js öğrenin.";
            string dogruMetin = metin.Replace("js", "C#"); // ilk parametrede gönderilen string ı ikinci parameterede gönderilen string ile değiştirir.
            Console.WriteLine(dogruMetin);



            // Ödev
            // Kullanici adında bir sınıf olacak.
            // Bu sınıfta KullanıcıAdı, Şifre ve KullanıcıNumarası olacak şekilde 3 özellik olacak.
            // Kullanici kullanici = " BehlulMese ,1234, 9019   ";
            // kullanıcı.KullanıcıAdı = "BehlulMese"
            // kullanıcı.Sifre = "1234"
            // string kullanıcıBilgileri = (string)kullanici;
            // "Kullanıcı Adı: BehlulMese\nŞifre: 1234\nKullanıcı Numarası: 9019"


            Console.ReadKey();
        }
    }
}

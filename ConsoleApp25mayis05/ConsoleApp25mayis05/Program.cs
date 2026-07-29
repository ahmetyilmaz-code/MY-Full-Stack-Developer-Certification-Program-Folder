using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25mayis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BankaHesap {} bakiye double özellik, HesapNumarasi string özellik,
            // Kullanici Adi ve Soyadi, BakiyeYukle() 
            // BakiyeSorgula(), BakiyedenCek()
            // kullanıcı istediğinde hesap bilgilerini görecek,
            // isterse para yükleyecek isterse para çekecek
            // isterse bakiyesini görecek


            BankaHesap yenihesap = new BankaHesap();
            Console.Write("Hesap adı girin: ");
            yenihesap.KullaniciAdi = Console.ReadLine();
            Console.Write("Hesap soyadı girin: ");
            yenihesap.KullaniciSoyadi = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hesap oluşturuldu. Hesap bilgileri: ");
            yenihesap.HesapBilgileriniGoster();

            Console.WriteLine("Herhangi bir tuşa basarak işlem yapmaya başlayabilirsiniz.");
            Console.ReadKey();

            while (true)
            {
                Console.WriteLine("Banka Hesap İşlemleri: ");
                Console.WriteLine("1 bakiye yükle");
                Console.WriteLine("2 bakiye sorgula");
                Console.WriteLine("3 bakiyeden çek");
                Console.WriteLine("4 hesap bilgilerini göster");
                Console.WriteLine("5 çıkış");
                Console.WriteLine("0 menüye dönüş");
                char secim = Console.ReadKey().KeyChar;
                if (secim == '1')
                {
                    Console.Write("Yüklenecek miktarı girin: ");
                    double miktar = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                    yenihesap.BakiyeYukle(miktar);


                }
                else if (secim == '2')
                {
                    yenihesap.BakiyeSorgula();

                }
                else if (secim == '3')
                {
                    Console.Write("Çekilecek miktarı girin: ");
                    double miktar = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                    yenihesap.BakiyedenCek(miktar);

                }
                else if (secim == '4')
                {
                    yenihesap.HesapBilgileriniGoster();
                }
                else if (secim == '5')
                {
                    break;
                }
                else if (secim == '0')
                {
                    Console.Clear();
                    continue;
                }
                Console.WriteLine("Başka bir işlem yapmak için tuşuna basınız...");
                Console.ReadKey();
                Console.Clear();

            }
            Console.WriteLine("Çıkış yapılıyor herhangi bir tuşa basınız...");
            Console.ReadKey();
        }
    }

    class BankaHesap
    {
        private double Bakiye = 0;
        private string HesapNumarasi = "12345";
        public string KullaniciAdi = "";
        public string KullaniciSoyadi = "";
        public void BakiyeYukle(double miktar)
        {
            Bakiye += miktar;
        }

        public void BakiyeSorgula()
        {
            Console.WriteLine($"Bakiye: {Bakiye}");
        }

        public void BakiyedenCek(double miktar)
        {

            if (Bakiye >= miktar)
            {
                Bakiye -= miktar;
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }

        public void HesapBilgileriniGoster()
        {
            Console.WriteLine($"Hesap Numarası: {HesapNumarasi}");
            Console.WriteLine($"Kullanıcı Adı: {KullaniciAdi} {KullaniciSoyadi}");
            Console.WriteLine($"Mevcut bakiye: {Bakiye}");
        }


    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8temmuz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcı sınıfı olsun içinde kullanıcı adı , şifre , tc numarası
            // bir kullanıcı sınıfı nesnesi oluşturulurken 
            // 1 kullanıcı adı en az 3 karakter olmalı
            // 2 şifre içinde 1 sayı 1 büyük 1 k.harf olmalı ve en az 6 karakter olmalı
            // 3 tc 11 haneli olmalı ve hepsi sayısal değer olmalı
            // bu kontroller özelliklere değer ataması yapıldığı zaman kontrol edilecek ve
            // exception ile hata verilecek.
            // ister kendi sınıfını oluştur ister trow ile hazır olanı fırlat.

            try
            {
                Kullanici k1 = new Kullanici(
                    "Ahmet",
                    "Abc123",
                    "12345678901");

                Console.WriteLine("Kullanıcı başarıyla oluşturuldu.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata : {ex.Message}");
            }

            Console.ReadLine();
        }


    }

    class Kullanici
    {
        private string kullaniciAdi;
        private string sifre;
        private string tcNo;

        public string KullaniciAdi
        {
            get => kullaniciAdi;
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("Kullanıcı adı en az 3 karakter olmalıdır.");
                }
                kullaniciAdi = value;
            }
        }

        public string Sifre
        {
            get => sifre;
            set
            {
                if (value.Length < 6)
                {
                    throw new Exception("Şifre en az 6 karakter olmalıdır.");
                }
                bool buyukHarf = false;
                bool kucukHarf = false;
                bool sayi = false;

                foreach (char karakter in value)
                {
                    if (char.IsUpper(karakter))
                        buyukHarf = true;

                    if (char.IsLower(karakter))
                        kucukHarf = true;

                    if (char.IsDigit(karakter))
                        sayi = true;
                }

                if (!(buyukHarf && kucukHarf && sayi))
                {
                    throw new Exception("Şifre en az 1 büyük harf, 1 küçük harf ve 1 rakam içermelidir.");
                }

                sifre = value;
            }
        }

        public string TcNo
        {
            get { return tcNo; }
            set
            {
                if (value.Length != 11)
                {
                    throw new Exception("TC Kimlik Numarası 11 haneli olmalıdır.");
                }

                foreach (char karakter in value)
                {
                    if (!char.IsDigit(karakter))
                    {
                        throw new Exception("TC Kimlik Numarası sadece rakamlardan oluşmalıdır.");
                    }

                }

                tcNo = value;
            }
        }

        public Kullanici(string kullaniciAdi, string sifre, string tcNo)
        {
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
            TcNo = tcNo;
        }
    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8haziran02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zaman {}
            // Saat, Dakika, Saniye 3 int özellik olacak
            // Bir yapıcı metotta saat dakika ve saniye özelliklerini alarak bu değerleri 24 saat dilimine göre ayarlayıp özelliklere değerecek
            // Bir yapıcı metot ise sadece saniye değerini aral 24 saatlik dilime göre atama yapacak
            // Sadece okuna bilen değer ataması yapılamayan 2 özellik olacak
            // TamSaniye int içide bulunduğu nesnenin tüm değerlerini toplayak saniyesini döndürür
            // ZamanOku string = 3:12:5
            Zaman zaman1 = new Zaman(2, 70, 125);
            zaman1.EkranaYaz();

            Zaman zaman2 = new Zaman(111200);
            zaman2.EkranaYaz();

            Zaman zaman3 = zaman1 - zaman2;
            zaman3.EkranaYaz();



            Console.ReadKey();
        }
    }

    class Zaman
    {
        // Bir operatöre aşırı yüklenmek için aşağıdaki gibi bir metot oluşturulmalı.
        // operatörler nesneden nesne farklı özellik gösteremez ve bir nesne ile çağıralamaz onda statik olmalı.
        // burada yazılan operator ifadesi sabit bir değerdir ve operatöre aşırı yüklenen metotlardan yazılması zorunlu
        public static Zaman operator +(Zaman z1, Zaman z2)
        {
            int saniye = z1.TamSaniye + z2.TamSaniye;
            return new Zaman(saniye);
        }
        public static Zaman operator -(Zaman z1, Zaman z2)
        {

            int saniye = Math.Abs(z1.TamSaniye - z2.TamSaniye);
            return new Zaman(saniye);
        }

        //public static "Geriye dönülecek değer" operator "Hangi öperatöre aşırı yükleniyor"(operatürün sağındaki değer, operatürün solundaki değer)
        //{
        //    int saniye = z1.TamSaniye + z2.TamSaniye;
        //    return new Zaman(saniye);
        //}

        // Diğer metotlarda olduğu gibi operator metotlarınada overload yapılabilir.
        public static Zaman operator +(Zaman z1, int Saniye)
        {
            int saniye = z1.TamSaniye + Saniye;
            return new Zaman(saniye);
        }

        public Zaman(int saat, int dakika, int saniye)
        {
            Saniye = saniye % 60;
            Dakika = dakika + saniye / 60;
            Saat = saat + Dakika / 60;
            Dakika %= 60;
        }
        public Zaman(int saniye) : this(0, 0, saniye)
        {

        }
        public int Saat { get; set; }
        public int Dakika { get; set; }
        public int Saniye { get; set; }

        public int TamSaniye { get => (Saat * 3600) + (Dakika * 60) + Saniye; }

        public string ZamanOku { get => $"{Saat}:{Dakika}:{Saniye}"; }

        public void EkranaYaz()
        {
            Console.WriteLine($"Toplam Saniye: {TamSaniye}");
            Console.WriteLine(ZamanOku);
        }


    }
}

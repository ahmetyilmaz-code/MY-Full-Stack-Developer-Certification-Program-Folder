using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8haziran02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zaman{} diye bir sınıf
            // Saat, Dakika, Saniye diye 3 int özellik
            // 2 yapıcı metot bir yapıcı metotta saat dakika ve saniye özelliklerini alarak
            // bu değerleri 24 saat dilimine göre ayarlayıp özelliklere değer verecek.

            // 2. yapıcı metot ise sadece saniye değerini alarak 24 saatlık dilime göre atama yapacak.
            // Zaman zaman1 = new Zaman(2, 70, 125); //3, 12, 5
            // Zaman zaman2 = new Zaman(1200); //0, 20, 0

            //Sadece okunabilen değer ataması yapılamayan 2 özellik olacak
            //TamSaniye int içinde bulunduğu nesnenin tüm değerlerini toplayarak sayiyeye döndürür.
            //ZamaniOku string 3:12:5 çıktısı olcak

            Zaman zaman1 = new Zaman(2, 70, 125);
            Console.WriteLine(zaman1.ZamaniOku);

            Zaman zaman2 = new Zaman(11525);
            Console.WriteLine(zaman2.ZamaniOku);




            Zaman zaman4 = zaman1 + zaman2;
            Console.WriteLine(zaman4.ZamaniOku);
        }

        class Zaman
        {
            public static Zaman operator +(Zaman z1, Zaman z2)
            {
                int saniye = z1.TamSaniye + z2.TamSaniye;
                return new Zaman(saniye);
            }


            public Zaman(int Saat, int Dakika, int Saniye)
            {
                this.saat = Saat;
                this.dakika = Dakika;
                this.saniye = Saniye;

                while (saniye >= 60)
                {
                    saniye -= 60;
                    dakika++;
                }

                while (dakika >= 60)
                {
                    dakika -= 60;
                    saat++;
                }
            }
            public Zaman(int Saniye) : this(0, 0, Saniye) { }
            public int saat { get; set; }
            public int dakika { get; set; }
            public int saniye { get; set; }

            public int TamSaniye { get => (saat * 3600) + (dakika * 60) + saniye; }
            public string ZamaniOku { get => $"{saat}:{dakika}:{saniye} == {TamSaniye} saniyedir."; }
        }
    }

}

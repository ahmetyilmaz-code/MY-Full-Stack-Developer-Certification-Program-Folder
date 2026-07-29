using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10haziran06
{
    class Program
    {
        static void Main(string[] args)
        {
            // == ve != operatörlerini overload ettik.
            // Zaman sınıfından bir nesne ile int türünde bir değeri karşılaştırabiliyoruz.
            // Karşılaştırma sonucunda bool türünde bir değer döndürür.

            Zaman zaman1 = new Zaman(2, 70, 125);
            zaman1.EkranaYaz();
            int dakika = zaman1["Dakika"];
            zaman1.EkranaYaz();
            zaman1["Dakika"] = dakika + dakika;
            zaman1.EkranaYaz();
            Console.ReadKey();
        }
    }

    class Zaman
    {
        public int this[string ozellik]
        {
            get
            {
                switch (ozellik)
                {
                    case "Saat":
                        return Saat;
                    case "Dakika":
                        return Dakika;
                    case "Saniye":
                        return Saniye;
                    default:
                        return 0;
                }
            }
            set
            {
                switch (ozellik)
                {
                    case "Saat":
                        Saat = value;
                        break;
                    case "Dakika":
                        Dakika = value;
                        break;
                    case "Saniye":
                        Saniye = value;
                        break;
                }
            }

        }

        public Zaman(int saat, int dakika, int saniye)
        {
            Saniye = saniye % 60;
            Dakika = dakika + saniye / 60;
            Saat = saat + Dakika / 60;
            Dakika %= 60;
            ToplamSaniye = (Saat * 3600) + (Dakika * 60) + Saniye;
            ZamanFormat = $"{Saat}:{Dakika}:{Saniye}";
        }
        public Zaman(int saniye) : this(0, 0, saniye)
        {


        }
        public int Saat { get; set; }
        public int Dakika { get; set; }
        public int Saniye { get; set; }
        public int ToplamSaniye { get; set; }
        public string ZamanFormat { get; set; }
        public void EkranaYaz()
        {
            Console.WriteLine($"Toplam Saniye: {ToplamSaniye}");
            Console.WriteLine(ZamanFormat);
        }


    }
}

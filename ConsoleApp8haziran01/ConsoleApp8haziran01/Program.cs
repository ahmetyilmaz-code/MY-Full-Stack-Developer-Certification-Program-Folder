using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8haziran01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci = new Ogrenci(234);
            ogrenci.AdSoyad = "Behlül MEŞE";
            Console.WriteLine(ogrenci.OgrenciNo);
            // ogrenci.OgrenciNo = 444; yapıcı metot haricinde hiç bir yerde tanımlama yapamam.
            ogrenci = ogrenci.OgrenciNoDegistir(444);
            Console.WriteLine(ogrenci.OgrenciNo);
            Console.ReadKey();

        }
        class Ogrenci
        {
            public Ogrenci(int ogrenciNo)
            {
                // readonly burada değer ataması yapabilirim.
                OgrenciNo = ogrenciNo;

            }
            // readonly const ta benzer ama ondan farklı olarak tanımlama anında null bırakılabilir ve sadece yapıcı metottan değer alabilir. Buda ilgili özelliğin sadece nesne oluşturulurken değer alabilmesine olanaktadır.
            public readonly int OgrenciNo;
            public string AdSoyad { get; set; }

            public Ogrenci OgrenciNoDegistir(int yeniNo)
            {
                Ogrenci newogrenci = new Ogrenci(yeniNo);
                newogrenci.AdSoyad = this.AdSoyad;
                return new Ogrenci(yeniNo);
            }
        }
    }

}

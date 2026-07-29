using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22haizran01
{
    class Ekran
    {
        public static void EkraniYenile()
        {
            Console.Clear();
            Console.WriteLine($"Kullanıcı Adı: {Global.Oyuncu.OyuncuAdi}");
            Console.WriteLine($"Puan : {Global.Oyuncu.Puan}");
            Console.WriteLine($"Can : {Global.Oyuncu.Can}");
            Console.WriteLine(new string('*', 50));
            Console.WriteLine(Global.AktifKelime.PadLeft(10));
            Console.WriteLine(new string('*', 50));
            
           
        }
        public static void Mesaj(string mesaj)
        {
            Console.WriteLine(mesaj);
            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadKey();
        }
       
    }
}

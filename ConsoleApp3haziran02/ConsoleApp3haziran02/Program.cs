using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3haziran02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oyun oyuncu1 = new Oyun("Ali");
            Oyun oyuncu2 = new Oyun("Ahmet");
            Oyun oyuncu3 = new Oyun("Ayşe");
            Console.WriteLine($"Toplam oyun sayısı: {Oyun.OyunSayisi}");

            Console.ReadKey();
        }

    }

    class Oyun
    {
        static Oyun()
        {
            Console.WriteLine("Oyun başlatıldı");
        }
        public Oyun(string kullanıcıAdı)
        {
            KullanıcıAdı = kullanıcıAdı;
            OyunSayisi++;
            Console.WriteLine($"{KullanıcıAdı} oyunda katıldı. ");
        }

        public static int OyunSayisi { get; set; }
        public string KullanıcıAdı { get; set; }

    }



}



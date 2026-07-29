using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15haziran05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir sayaç olsun 
            // yukarı ok tuluna bastıkça değer bir artacak
            // aşağı ok tuşuma nasında değer bir azalacak
            // sağ tuşa basın değer 2 artıcak
            // sol tuşa basınca değer 2 azalacak

            //LeftArrow = 37,
            //UpArrow = 38,
            //RightArrow = 39,
            //DownArrow = 40,
            //Escape = 27
            //Enter = 13
            //Spacebar = 32
            Sayac.Basla();
            Console.ReadKey();
        }

        enum Yon
        {
            Sola = 37,
            Yukari = 38,
            Saga = 39,
            Asagi = 40,
            Kapat = 27,
            //Enter = 13,
            Bosluk = 32,
        }


        class Sayac
        {
            public static int SayacDegeri { get; set; }


            public static void Basla()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Yukarı ok 1 arttıracak.");
                    Console.WriteLine("Aşağı ok 1 azaltacak.");
                    Console.WriteLine("Sağ ok 2 arttıracak.");
                    Console.WriteLine("Sol ok 2 azaltacak.");
                    Console.WriteLine("Boşluk tuşu sayaç değerini sıfırlayacak.");
                    Console.WriteLine("Kapatmak için Escape tuşuna basın.");
                    Console.WriteLine("\n***************\n");
                    Console.WriteLine(SayacDegeri);
                    Console.WriteLine("\n***************\n");
                    Yon yon = (Yon)Console.ReadKey().Key;
                    if (yon == Yon.Kapat)
                    {
                        break;
                    }
                    switch (yon)
                    {
                        case Yon.Yukari:
                            SayacDegeri++;
                            break;
                        case Yon.Asagi:
                            SayacDegeri--;
                            break;
                        case Yon.Saga:
                            SayacDegeri += 2;
                            break;
                        case Yon.Sola:
                            SayacDegeri -= 2;
                            break;
                        case Yon.Bosluk:
                            SayacDegeri = 0;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

    }
}

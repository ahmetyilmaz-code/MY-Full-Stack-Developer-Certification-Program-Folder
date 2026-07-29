using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29haziran01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan gelen 12 + 14 - 20 * 5
            // İşlemler soldan sağa sırayla yapılsın yani işlem önceliğini hesap etmeyelim


            Console.Write("İşlem giriniz: ");
            string metin = Console.ReadLine();
            string[] metinler = metin.Split(' ');
            int sonuc = Convert.ToInt32(metinler[0]);

            for (int i = 1; i < metinler.Length; i += 2)
            {
                string islem = metinler[i];
                int sayi = Convert.ToInt32(metinler[i + 1]);
                switch (islem)
                {
                    case "+":
                        sonuc += sayi;
                        break;

                    case "-":
                        sonuc -= sayi;
                        break;

                    case "*":
                        sonuc *= sayi;
                        break;

                    case "/":
                        sonuc /= sayi;
                        break;

                    default:
                        Console.WriteLine("Geçersiz işlem.");
                        return;
                }
            }
            Console.WriteLine($"sonuc = {sonuc}");
        }


    }
}

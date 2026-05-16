using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11mayis03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İstenildiği kadar sayı alarak ekrana arasına - koyarak yazan metot
            // ama ondalıklı bir değer gönderilirse 1.2547 = 1,25


            SayilariYaz(1.2244, 3, 4, 3.1422);
            Console.ReadKey();
        }
        static void SayilariYaz(params double[] sayilar)
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                double sayi = sayilar[i];
                int _sayi = (int)(sayi);
                if (_sayi < sayi)
                {
                    string metin = $"{_sayi},";
                    int ondalik = (int)((sayi - _sayi) * 100);
                    metin += ondalik;
                    Console.Write(metin);
                }
                else
                {
                    Console.Write(sayi);
                }
                if (i < sayilar.Length - 1)
                {
                    Console.Write("-");
                }

            }

        }
    }
}
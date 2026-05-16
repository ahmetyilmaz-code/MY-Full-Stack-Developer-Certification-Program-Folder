using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11mayis02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Islem() bu metot gönderilen ilk parametredeki matematik işlemini 
            //yapar ve istenildiği kadar sayı gönderilebilir.


            Islem("+", 1, 2, 3, 4, 5, 6, 7); // 1+2+3+4+5+6+7 = 28
            Islem("-", 1, 2, 3); // 0-1-2-3 = -6
            Islem("*", 1, 2, 3, 4, 5, 6, 7, 8); // 1*2*3*4*5*6*7*8 = 40320
            Islem("/", 1, 2, 0, 4, 5); // 1/2/1/4/5 = 0.025 0


            Console.ReadKey();
        }
        static void Islem(string islem, params int[] sayilar)
        {
            int sonuc = 0;
            switch (islem)
            {
                case "+":
                    for (int i = 0; i < sayilar.Length; i++)
                    {
                        sonuc += sayilar[i];
                    }
                    break;
                case "-":
                    for (int i = 0; i < sayilar.Length; i++)
                    {
                        sonuc -= sayilar[i];
                    }
                    break;
                case "*":
                    sonuc = 1;
                    for (int i = 0; i < sayilar.Length; i++)
                    {
                        sonuc *= sayilar[i];
                    }
                    break;
                case "/":
                    sonuc = 1;
                    for (int i = 0; i < sayilar.Length; i++)
                    {
                        if (sayilar[i] == 0)
                        {
                            Console.WriteLine("Sıfıra bölme hatası! değer 1 arttırıldı");
                            sayilar[i] += 1;
                        }
                        sonuc /= sayilar[i];
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem!");
                    return;
            }
            Console.WriteLine($"Sonuç: {sonuc}");



        }
    }
}
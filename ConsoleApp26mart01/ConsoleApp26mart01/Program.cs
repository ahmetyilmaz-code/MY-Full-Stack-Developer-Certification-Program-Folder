using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26mart01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcı D veya d tuşuna bastığı sürece sayı alan ve aldığı sayılardan en büyük tek ve çift sayıyı en küçük tek ve çift sayıyı buluna ve büyük olanı küçükten çıkartan programı yazalım

            int buyukTek, kucukTek, buyukCift, kucukCift, sayi;

            Console.Write("Sayı: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            buyukCift = sayi;
            kucukCift = sayi;
            buyukTek = sayi;
            kucukTek = sayi;

            char cevap = 'd';

            while (cevap == 'd' || cevap == 'D')
            {
                Console.Write("Sayı: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0) // yeni girilen sayı çiftmi değilmi ?
                {
                    if (buyukCift % 2 == 1) // yeni girilen çift ve eski girilen tek ise
                                            // bu yeni sayı bizim ilk çift sayı olduğunu kontrolünü yaptığımız kısım
                    {
                        buyukCift = sayi;
                        kucukCift = sayi;
                    }
                    else if (sayi > buyukCift)
                    {
                        buyukCift = sayi;
                    }
                    else if (sayi < kucukCift)
                    {
                        kucukCift = sayi;
                    }
                }
                else
                {
                    if (buyukTek % 2 == 0) // yeni girilen çift değil ve eski girilen çift ise
                                           // bu yeni sayı bizim ilk tek sayı olduğunun kontrolünü yaptığımız kısım
                    {
                        buyukTek = sayi;
                        kucukTek = sayi;
                    }
                    else if (sayi > buyukTek)
                    {
                        buyukTek = sayi;
                    }
                    else if (sayi < kucukTek)
                    {
                        kucukTek = sayi;
                    }
                }
                Console.Write("Devam etmek için D tuşuna basın: ");
                cevap = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            int buyukFark = buyukCift > buyukTek ? buyukCift - buyukTek : buyukTek - buyukCift;
            int kucukFark = kucukCift > kucukTek ? kucukCift - kucukTek : kucukTek - kucukCift;

            Console.WriteLine($"Büyük Tek Sayı: {buyukTek}\nKüçük Tek Sayı: {kucukTek}\nBüyük Çift Sayı: {buyukCift}\nKüçük Çift Sayı: {kucukCift}\nBüyük sayıların farkı: {buyukFark}\nKüçük sayıların farkı: {kucukFark}");

            Console.ReadKey();

        }
    }
}

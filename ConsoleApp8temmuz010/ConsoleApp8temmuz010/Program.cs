using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace ConsoleApp8temmuz010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yapılacaklar Programı
            // Çıktı Görüntüsü :
            // 1. Evi Topla
            // 2. Yemek Yap
            // 3. Bulaşıkları Topla
            // ==> Evi Topla

            // Kullanıcın girdiği değer listede varsa listeden çıkartalım
            // Kullnaıcın girdiği değer listede yoksa ekleyelim
            // büyük küçük duyarlı olmasın, boşluklarıda saymasın

            List<string> yapilacaklar = new List<string>();
            yapilacaklar.Add("Evi Topla");
            yapilacaklar.Add("Yemek Yap");
            yapilacaklar.Add("Bulaşıkları Topla");

            Console.WriteLine("Yapılacaklar Listesi");
            for (int i = 0; i < yapilacaklar.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {yapilacaklar[i]}");
            }

            Console.Write("\nİşlem yapılacak görev: ");
            string giris = Console.ReadLine().Trim();

            bool bulundu = false;

            for (int i = 0; i < yapilacaklar.Count; i++)
            {
                string trim = yapilacaklar[i].Trim();
                if (trim.ToLower() == giris.ToLower())
                {
                    yapilacaklar.RemoveAt(i);
                    Console.WriteLine("\nGörev listeden silindi.");
                    bulundu = true;
                    break;
                }
            }

            if (!bulundu)
            {
                yapilacaklar.Add(giris);
                Console.WriteLine("\nGörev listeye eklendi.");
            }

            Console.WriteLine("\nGüncel Liste");

            for (int i = 0; i < yapilacaklar.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {yapilacaklar[i]}");
            }

            Console.ReadLine();
        }
    }
}


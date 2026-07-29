using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace ConsoleApp8temmuz011
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

            YapilacaklarProgram.Basla();



            Console.ReadLine();
        }
        class YapilacaklarProgram
        {
            static List<string> yapilacaklar = new List<string>();
            static List<string> yapilacaklarFormat = new List<string>();
            public static void Basla()
            {
                Ekran();
            }
            public static void Ekran()
            {
                Console.Clear();
                for (int i = 0; i < yapilacaklar.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{yapilacaklar[i]}");
                }
                Console.Write("==> ");
                DegerAl();
            }
            static void DegerAl()
            {
                string deger = Console.ReadLine();
                string degerformat = DegerKontrolFormat(deger);
                int degerindex = yapilacaklarFormat.IndexOf(DegerKontrolFormat(deger));
                if (degerindex > -1)
                {
                    yapilacaklar.Remove(yapilacaklar[degerindex]);
                    yapilacaklarFormat.Remove(degerformat);
                }
                else
                {
                    yapilacaklar.Add(deger);
                    yapilacaklarFormat.Add(degerformat);
                }
                Ekran();
            }

            static string DegerKontrolFormat(string deger)
            {
                string format = deger.ToLower();
                Regex regex = new Regex(@"\s+");
                format = regex.Replace(format, "");
                return format;

            }
        }
    }
}


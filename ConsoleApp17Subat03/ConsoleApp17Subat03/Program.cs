using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subat1703
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan isim soy isim ve yaş bilgisini alarak ekrana 
            //çıktısı : Merhaba ahmet yılmaz 
            // yaşınız : 28 18 den büyük veya eşitsiniz
            // yaşınızı onaylıyormusunuz. (Evet: E)
            // Bilgiler onaylandı E ise değilse Bilgiler onaylanmadı, kayıt başarısız.

            Console.WriteLine("İsminiz : ");
            int isim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Soy isminiz :");
            int soyisim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yaşınız :");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Merhaba {isim} {soyisim}");

            string yas2 = yas => 18 ? "Yaşınız 18'e eşit veya büyüktür. " : "Yaşınız 18 den küçüktür."
            Console.WriteLine("Yaşınızı Onaylamak için Evet ise E'ye basınız.")
            string onay = Console.ReadLine();









        }
    }
}

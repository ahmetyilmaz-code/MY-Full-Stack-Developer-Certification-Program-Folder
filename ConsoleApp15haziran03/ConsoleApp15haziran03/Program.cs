using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15haziran03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gun = 1;
            if (gun == (int)HaftaninGünleri.Sali)
            {
                Console.WriteLine("Gün Salı");
            }

            Console.WriteLine(HaftaninGünleri.Sali);
            HaftaninGünleri gun1 = HaftaninGünleri.Pazartesi;
            Console.WriteLine(gun1);

            GunYaz(HaftaninGünleri.Cuma);
            GunYaz((HaftaninGünleri)6);
            Console.ReadKey();
        }

        static void GunYaz(HaftaninGünleri gun)
        {
            Console.WriteLine(gun);
        }

    }

    enum HaftaninGünleri // 0,1,2,3,4,5,6
    {
        Pazartesi,
        Sali,
        Carşamba,
        Perşembe,
        Cuma = 10,
        Cumartesi = 6,
        Pazar
    } // enum yapısı içerisinde tanımlanan her bir eleman sırasıyla
      // 0,1,2,3,4,5,6 değerlerini alır.
      // Eğer istenirse bu değerler elle de atanabilir.




}
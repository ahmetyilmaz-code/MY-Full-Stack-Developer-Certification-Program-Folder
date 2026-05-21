using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18mayıs03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vergisiz tutar alarak kdv ve ötv ekleyerek tutar hesaplayan program
            // KDV varsayılan %10, ÖTV varsayılan %8 olarak kabul edilsin

            double vergi = vergiHesapla(100);
            Console.WriteLine($"Toplam vergi tutarı: {vergi}");
            double vergiKdvsiz = vergiHesapla(100, 0);
            Console.WriteLine($"Vergisiz tutar: {vergiKdvsiz}");
            double vergiOtvVeKdvsiz = vergiHesapla(100, 0, 0);
            Console.WriteLine($"Ötv ve Kdv'siz tutar: {vergiOtvVeKdvsiz}");


            double t = vergiHesapla(vergisizTutar: 100, otvOrani: 0.07);
            Console.WriteLine($"Toplam tutar: {t}");
            Console.ReadKey();

        }

        static double vergiHesapla(double vergisizTutar, double kdvOrani = 0.10, double otvOrani = 0.08)
        {
            double kdvTutar = vergisizTutar * kdvOrani;
            double otvTutar = vergisizTutar * otvOrani;
            double toplamTutar = vergisizTutar + kdvTutar + otvTutar;
            return toplamTutar;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart032
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanucudan baz değer alarak vergili halini hesaplayan program
            // KDV oranı %18 , OTV oranı %20 , MTV oranı %10 olsun
            // KDV sadece KDV
            // ÖTV seçerse ÖTV sonra KDV
            // MTV önce MTV sonra ÖTV sonra KDV

            Console.Write("Lütfen baz değeri giriniz: ");
            double bazDeger = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vergi türünü seçiniz: KDV (K) , ÖTV (Ö) , MTV (M)");
            char vergiTuru = Convert.ToChar(Console.ReadLine().ToUpper());
            string sonuc = " ";

            switch (vergiTuru)
            {
                case 'K':
                case 'k':
                    double kdv = bazDeger * 0.18;
                    double kdvliFiyat = bazDeger + kdv;
                    sonuc += "KDV'li fiyat: " + kdvliFiyat;
                    break;
                case 'Ö':
                case 'ö':
                    double otv = bazDeger * 0.20;
                    double otvliFiyat = bazDeger + otv;
                    kdv = otvliFiyat * 0.18;
                    kdvliFiyat = otvliFiyat + kdv;
                    sonuc += "ÖTV'li fiyat: " + kdvliFiyat + " ";
                    break;
                case 'M':
                case 'm':
                    double MTV = bazDeger * 0.10;
                    double MTVlifiyat = MTV + bazDeger;
                    otv = MTVlifiyat * 0.20;
                    otvliFiyat = MTVlifiyat + otv;
                    kdv = otvliFiyat * 0.18;
                    kdvliFiyat = otvliFiyat + kdv;
                    sonuc += "MTV'li fiyat: " + kdvliFiyat + " ";
                    break;
            }
            Console.WriteLine(sonuc);
        }
    }
}
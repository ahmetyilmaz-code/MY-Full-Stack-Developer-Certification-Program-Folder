using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp29haziran02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan gelen 12 + 14 - 20 * 5
            // İşlemler soldan sağa sırayla yapılsın yani işlem önceliğini hesap etmeyelim
            Console.WriteLine("işlem giriniz :");
            string _islem = Console.ReadLine();

            MatematikIslem islem = new MatematikIslem(_islem);
            Console.WriteLine(islem.Sonuc);

        }

        class MatematikIslem
        {
            public MatematikIslem(string islem)
            {
                IslemTxt = islem;
                Islem();
            }
            private int _Sonuc { get; set; }

            public int Sonuc => _Sonuc;

            private string IslemTxt { get; set; }

            private char[] Operatorler { get; set; }

            private void Islem()
            {
                Regex regex = new Regex(@"\s+"); //bütün boşlukları filtrele
                IslemTxt = regex.Replace(IslemTxt, string.Empty); //string.empty == "" //boşlukları boş string yap
                regex = new Regex(@"\d+"); // birden fazla sayı olabilir ile filtreledik
                Match sayilarMatch = regex.Match(IslemTxt);
                if (sayilarMatch.Success)
                {
                    _Sonuc = Convert.ToInt32(sayilarMatch.Value); //ilk sayım sonuçtur
                }
                sayilarMatch = sayilarMatch.NextMatch();
                Operatorler = regex.Replace(IslemTxt, string.Empty).ToCharArray(); // bütün sayıları sildik sadece işlemler kaldı
                int index = 0;
                while (sayilarMatch.Success)
                {
                    int sayi = Convert.ToInt32(sayilarMatch.Value);
                    Hesapla(sayi, Operatorler[index]);
                    sayilarMatch = sayilarMatch.NextMatch();
                    index++;
                }
            }
            private void Hesapla(int sayi, char islem)
            {
                switch (islem)
                {
                    case '+':
                        _Sonuc += sayi;
                        break;
                    case '-':
                        _Sonuc += sayi;
                        break;
                    case '*':
                        _Sonuc += sayi;
                        break;
                    case '/':
                        _Sonuc += sayi;
                        break;
                }
            }

        }
    }
}

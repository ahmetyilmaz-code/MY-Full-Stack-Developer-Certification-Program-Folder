using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25mayis03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hesapla{} sınıfında topla[} carp[] cikar[] bol[] işlemlerini yapan metot
            // her metoto iki int parametre alarak işlem yapar

            // hesapla sınıfı içinde iki tane özellik olacak ve sayi1 sayi2 adında
            //bu iki özelliği değer ataması yapılacak ve diğer tüm metotlar bu sayılar üzerinden işlem yapacaklar

            //Hesapla1 Sınıfında tüm metotlar static olacak ve parametre olarak iki sayı alacaklar
            int a = Hesapla1.topla(10, 5);
            int b = Hesapla1.carp(10, 5);
            int c = Hesapla1.cikar(10, 5);
            int d = Hesapla1.bol(10, 5);

            Console.WriteLine("Hesapla1 sınıfı sonuçları:");
            Console.WriteLine($"Topla: {a}");
            Console.WriteLine($"Carp: {b}");
            Console.WriteLine($"Cikar: {c}");
            Console.WriteLine($"Bol: {d}");

            //Hesapla2 Sınıfında tüm metotlar static olmayacak ve static parametre olarak iki sayı alacaklar
            Hesapla2 hesapla2 = new Hesapla2();
            int e = hesapla2.topla(Hesapla2.sayi1, Hesapla2.sayi2);
            int f = hesapla2.carp(Hesapla2.sayi1, Hesapla2.sayi2);
            int g = hesapla2.cikar(Hesapla2.sayi1, Hesapla2.sayi2);
            int h = hesapla2.bol(Hesapla2.sayi1, Hesapla2.sayi2);

            Console.WriteLine("Hesapla2 sınıfı sonuçları:");
            Console.WriteLine($"Topla: {e}");
            Console.WriteLine($"Carp: {f}");
            Console.WriteLine($"Cikar: {g}");
            Console.WriteLine($"Bol: {h}");

            //Hesapla3 Sınıfında tüm metotlar static olmayacak ve static olmayan parametre olarak iki sayı alacaklar
            Hesapla3 hesapla3 = new Hesapla3();
            int i = hesapla3.topla(hesapla3.sayi1, hesapla3.sayi2);
            int j = hesapla3.carp(hesapla3.sayi1, hesapla3.sayi2);
            int k = hesapla3.cikar(hesapla3.sayi1, hesapla3.sayi2);
            int l = hesapla3.bol(hesapla3.sayi1, hesapla3.sayi2);

            Console.WriteLine("Hesapla3 sınıfı sonuçları:");
            Console.WriteLine($"Topla: {i}");
            Console.WriteLine($"Carp: {j}");
            Console.WriteLine($"Cikar: {k}");
            Console.WriteLine($"Bol: {l}");

            //Hesapla4 Sınıfında tüm metotlar static  ve static  parametre olarak iki sayı alacaklar
            Hesapla4 hesapla4 = new Hesapla4();
            int m = Hesapla4.topla(Hesapla4.sayi1, Hesapla4.sayi2);
            int n = Hesapla4.carp(Hesapla4.sayi1, Hesapla4.sayi2);
            int o = Hesapla4.cikar(Hesapla4.sayi1, Hesapla4.sayi2);
            int p = Hesapla4.bol(Hesapla4.sayi1, Hesapla4.sayi2);

            Console.WriteLine("Hesapla4 sınıfı sonuçları:");
            Console.WriteLine($"Topla: {m}");
            Console.WriteLine($"Carp: {n}");
            Console.WriteLine($"Cikar: {o}");
            Console.WriteLine($"Bol: {p}");

            Console.ReadKey();
        }
    }


}
    }
    class Hesapla1
{
    public static int topla(int a, int b)
    {
        return a + b;
    }
    public static int carp(int a, int b)
    {
        return a * b;
    }
    public static int cikar(int a, int b)
    {
        return a - b;
    }
    public static int bol(int a, int b)
    {
        if (b == 0)
        {
            return 0;
        }
        return a / b;
    }

}
class Hesapla2
{
    public static int sayi1 = 10;
    public static int sayi2 = 5;
    public int topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public int carp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }
    public int cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
    public int bol(int sayi1, int sayi2)
    {
        if (sayi2 == 0)
        {
            return 0;
        }
        return sayi1 / sayi2;
    }
}
class Hesapla4
{
    public static int sayi1 = 10;
    public static int sayi2 = 5;
    public static int topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public static int carp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }
    public static int cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
    public static int bol(int sayi1, int sayi2)
    {
        if (sayi2 == 0)
        {
            return 0;
        }
        return sayi1 / sayi2;
    }
}
class Hesapla3
{
    public int sayi1 = 10;
    public int sayi2 = 5;
    public int topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public int carp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }
    public int cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
    public int bol(int sayi1, int sayi2)
    {
        if (sayi2 == 0)
        {
            return 0;
        }
        return sayi1 / sayi2;
    }
}


}

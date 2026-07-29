using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8temmuz09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list sınıfı diziler mantığında çalışır ama
            // dizilerden farkı eleman sayısı belli değildir
            // Add metodu ile içerisine istenildiği kadar değer eklenebilir.
            List<string> list = new List<string>();
            list.Add("Değer 1");
            list.Add("Değer 2");
            list.Add("Değer 3");
            list.Add("Değer 4");
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
            Console.WriteLine(list[3]);

            Console.WriteLine("**********");
            list[2] = "3 Değer";
            Console.WriteLine(list.Count);
            Console.WriteLine("**********");
            //list.Count eleman sayısını gösterir length gibi
            list.Sort();
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            // list.Clear(); listeyi temizler
            List<string> list2 = new List<string>();
            list2.Add("Değer 1");
            list2.Add("Değer 2");
            list2.Add("Değer 3");
            list2.Add("Değer 4");
            list2.AddRange(list2);

            list.Sort();
            // IndexOf listedeki değeri döndürür yoksa negatif 
            int index = list.IndexOf("3 Değer");
            int index2 = list.IndexOf("Değer 5"); //-1 değer yok

            Console.ReadLine();
        }
    }
}


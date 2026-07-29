using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10haziran07
{
    class Program
    {
        static void Main(string[] args)
        {


            Kup kup1 = new Kup()
            {
                Genislik = 10,
                Yukseklik = 5
            };
            kup1.Ciz();
            Console.WriteLine();
            kup1[0] = 10;
            kup1[1] = 5;
            kup1.Ciz();


            Console.ReadKey();
        }
    }

    class Kup
    {

        public int this[int index]
        {

            set
            {
                switch (index)
                {
                    case 0:
                        Genislik = value;
                        break;
                    case 1:
                        Yukseklik = value;
                        break;

                }
            }

            get
            {
                switch (index)
                {
                    case 0:
                        return Genislik;
                    case 1:
                        return Yukseklik;
                    default:
                        return 0;

                }
            }
        }

        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        public void Ciz()
        {
            string satir = "";
            for (int i = 0; i < Genislik; i++)
            {
                satir += "*";
            }
            for (int i = 0; i < Yukseklik; i++)
            {
                Console.WriteLine(satir);
            }
        }
    }


}

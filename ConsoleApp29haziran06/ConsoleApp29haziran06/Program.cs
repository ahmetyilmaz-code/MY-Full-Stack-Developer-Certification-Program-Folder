using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp29haziran06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Bsayi2 = 1; //public
            //b.Bsayi = 1; //private
            b.Asayi2 = 1; //public
            //b.Asayi3 = 1; //protected
        }

        class A
        {
            public int Asayi2 { get; set; }
            private int Asayi { get; set; }
            protected int Asayi3 { get; set; }


            void Deneme()
            {
                Asayi2 = 1; //public
                Asayi = 1;  //private
                Asayi3 = 1; //protected
            }
        }
        class B : A
        {
            public int Bsayi2 { get; set; }
            private int Bsayi { get; set; }
            void Deneme()
            {
                Bsayi2 = 1; //public
                Bsayi = 1;  //private
                Asayi2 = 1; //public
                Asayi3 = 1; //protected kalıtımla erişilir
            }
        }

    }
}

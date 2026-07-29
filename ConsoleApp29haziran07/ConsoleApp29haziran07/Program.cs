using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp29haziran07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yapıcı metotlard önce kalıtım ile gelenin nesnesi oluşturulmalı
            B b = new B();

        }

        class A
        {
            public A(int a)
            {
                Console.WriteLine("yapıcı metot A");
            }
        }
        class B : A
        {
            public B() : base(10)
            {
                Console.WriteLine("yapıcı metot B");
            }
        }
        class C : B
        {
            public C(int a)
            {
                Console.WriteLine("yapıcı metot C");
            }
            public C() : this(10)
            {
                Console.WriteLine("yapıcı metot C");
            }
        }
    }
}

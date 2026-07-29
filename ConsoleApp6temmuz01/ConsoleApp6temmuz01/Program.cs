using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6temmuz01
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }
    // bu class içinder herşey abstract 
    // bu sını miras alan sınıfların bir şablon görevi olur.
    // o zaman bu aslında bir interface tir. 
    /* abstract class A
   {
        public abstract void Run();
        public abstract int Timer { get; set; }

    }
    */
    interface IA //interfaceler geleneksel olarak I ile başlar isimlendirilirken şart değil
    {
        // interface içinde yazılı olan bütün metotlar ve özellikler
        // abstract ve public olmak zorunda olduğu için
        // belirtmeye bile kızıyor.

        // public abstract void Run();
        void Run();

        // public abstract int Timer { get; set; }
        int Timer { get; set; }
    }
    interface IB //interface IB : IA yapılarak miras alındırılabilir
    {
        void Run2();
        int Timer2 { get; set; }
    }
    class B : IA, IB
    {
        public int Timer { get; set; }
        public void Run()
        {

        }
        public void Run2()
        {

        }
        public int Timer2 { get; set; }

    }


}



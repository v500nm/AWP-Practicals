using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Demo
{
    class Son : Father
    {
        public void DisplayTwo()
        {
            Console.WriteLine("Son.. ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Mangaonkar 333");
            Son s = new Son();
            s.Display();
            s.DisplayOne();
            s.DisplayTwo();
            Console.Read();
        }
    }
    class Grandfather
    {
        public void Display()
        {
            Console.WriteLine("Grandfather...");
        }
    }
    class Father : Grandfather
    {
        public void DisplayOne()
        {
            Console.WriteLine("Father...");
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Hello_Word
{
    class baseClass
    {
        public virtual void Greetings()
        {
            Console.WriteLine("baseClass Saying Hello!");
        }
    }
    class subClass : baseClass
    {
        public override void Greetings()
        {
            base.Greetings();
            Console.WriteLine("subClass Saying Hello!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Mangaonkar 333");
            baseClass obj1 = new subClass();
            obj1.Greetings();
            Console.ReadLine();
        }
    }
}

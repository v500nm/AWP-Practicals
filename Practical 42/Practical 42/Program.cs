using System;
namespace Constructor
{
    class paraconstrctor
    {
        public int a, b;
        public paraconstrctor(int x, int y)  // decalaring Paremetrized Constructor with ing x,y parameter
        {
            a = x;
            b = y;
        }
    }
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("Adnan Mangaonkar 333");
            paraconstrctor v = new paraconstrctor(100, 175);   // Creating object of Parameterized Constructor and ing values
            Console.WriteLine("-----------parameterized constructor example by vithal wadje---------------");
            Console.WriteLine("\t");
            Console.WriteLine("value of a=" + v.a);
            Console.WriteLine("value of b=" + v.b);
            Console.Read();
        }
    }
}
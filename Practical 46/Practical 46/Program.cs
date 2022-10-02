using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVirtualOverride
{
    // Base Class    
    class Parent
    {
        public virtual void SayHello()
        {
            Console.WriteLine("Hello from Parent function!!!");
        }
    }

    class Child : Parent
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello from Child class function!!!");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Mangaonkar 333");
            Parent pObj = new Parent();
            pObj.SayHello();
            Child cObj = new Child();
            cObj.SayHello();
            Parent pcObj = new Child();
            pcObj.SayHello();


            Console.ReadLine();
        }
    }
}

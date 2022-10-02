using System;
namespace MethodHiding
{
    public class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class Show Method");
        }
        public void Display()
        {
            Console.WriteLine("Parent Class Display Method");
        }
    }
    public class Child : Parent
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Mangaonkar 333");
            Child obj = new Child();
            obj.Show();
            obj.Display();
            Console.ReadKey();
        }
    }
}
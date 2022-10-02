

// C# Program to show use of
// the private access modifier
using System;

namespace PrivateAccessModifier
{

    class Parent
    {

        // Member is declared as private
        private int value;

        // value is Accessible
        // only inside the class
        public void setValue(int v)
        {
            value = v;
        }

        public int getValue()
        {
            return value;
        }
    }
    class Child : Parent
    {

        public void showValue()
        {
            // Trying to access value
            // Inside a derived class
            // Console.WriteLine( "Value = " + value );
            // Gives an error
        }
    }

    // Driver Class
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Mangaonkar 333");
            Parent obj = new Parent();

            // obj.value = 5;
            // Also gives an error

            // Use public functions to assign
            // and use value of the member 'value'
            obj.setValue(4);
            Console.WriteLine("Value = " + obj.getValue());
        }
    }
}

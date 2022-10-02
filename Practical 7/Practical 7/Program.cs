using System;
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Adnan Mangaonkar 333");
        int i;
            Console.WriteLine("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
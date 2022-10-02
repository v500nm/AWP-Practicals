using System;
class program
{
    public static void Main()
    {
        Console.WriteLine("Adnan Mangaonkar 333");
        Console.WriteLine("Arithmetic Operator Program");
        int a, b;
        Console.WriteLine("Enter 2 Numbers :");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Addition = " + (a + b));
        Console.WriteLine("Subtraction = " + (a - b));
        Console.WriteLine("Multiplication = " + (a * b));
        Console.WriteLine("Division = " + (a / b));
        Console.WriteLine("Mode = " + (a % b));
        Console.Read();

    }

}

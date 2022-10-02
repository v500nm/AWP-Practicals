using System;
class program
{
    public static void Main()
    {
        Console.WriteLine("Adnan Mangaonkar 333");
        Console.WriteLine("Logical Operator Program");
        bool a = true,
           b = false,
            result;


        result = a && b;
        Console.WriteLine("AND Operator: " + result);
        result = a || b;
        Console.WriteLine("OR Operator: " + result);
        result = !a;
        Console.WriteLine("NOT Operator: " + result);
        result = a & b;
        Console.WriteLine("Bitwise AND: " + result);
        result = a | b;
        Console.WriteLine("Bitwise OR: " + result);
        result = a ^ b;
        Console.WriteLine("Bitwise XOR: " + result);
       
        Console.Read();
    }

}


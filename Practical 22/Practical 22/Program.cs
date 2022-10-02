using System;
public class ReverseExample
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Adnan Mangaonkar 333");
        int n, reverse = 0, rem;
        Console.Write("Enter a number: ");
        n = int.Parse(Console.ReadLine());
        while (n != 0)
        {
            rem = n % 10;
            reverse = reverse * 10 + rem;
            n /= 10;
        }
        Console.Write("Reversed Number: " + reverse);
    }
}


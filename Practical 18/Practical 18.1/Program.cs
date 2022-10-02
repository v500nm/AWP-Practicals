using System.IO;
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Adnan Mangaonkar 333");
        partA();
        partB();    
        partC();
        partD();
        partE();
        Console.ReadLine();
    }
    static void partA()
    {
        int i, j, k;
        int n = 6;
        // loop to print the series
        for (i = 1; i <= n; i++)
        {
            for (j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
    static void partB()
    {
        for (int i = 6; i >= 1; --i)
        {
            for (int j = 1; j >= i; ++j)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void partC()
    {
        int a = 1, spaces, k = 6, i = 0, j = 0;
        spaces = k - 1;
        for (i = 1; i < k * 2; i++)
        {
            for (j = 1; j <= spaces; j++)
            {
                Console.Write(" ");
            }
            for (j = 1; j < a * 2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            if (i < k)
            {
                spaces--;
                a++;
            }
            else
            {
                spaces++;
                a--;
            }
        }
    }
    static void partD()
    {
        for (int i = 1; i <= 6; ++i)
        {
            for (int j = 1; j <= i; ++j)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void partE()
    {
        int x, y;
        for (x = 5; x >= 1; x--)
        {
            for (y = 1; y <= x; y++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
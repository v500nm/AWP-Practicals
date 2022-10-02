using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Adnan Mangaonkar 333");
        int i, j, k = 1;
        for (i = 1; i <= 10; i++)
        {
            for (j = 1; j < i + 1; j++)
            {
                Console.Write(k++ + " ");
            }

            Console.Write("\n");
        }
        Console.ReadLine();
    }
}
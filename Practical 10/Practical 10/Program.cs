﻿using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Mangaonkar 333");
            int x = 5, y = 20;
            if (x > y)
            {
                if (x >= 10)
                {
                    Console.WriteLine("x value greater than or equal to 10");
                }
                else
                {
                    Console.WriteLine("x value less than 10");
                }
            }
            else
            {
                if (y <= 20)
                {
                    Console.WriteLine("y value less than or equal to 20");
                }
                else
                {
                    Console.WriteLine("y value greater than 20");
                }
            }
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}

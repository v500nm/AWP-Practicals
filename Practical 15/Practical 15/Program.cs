﻿using System;

namespace ArmstrongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Mangaonkar 333");
            int number, rem, temp, sum = 0;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("          Check Number Is Armstrong Or Not             ");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Enter Your Number To Check :: ");
            number = int.Parse(Console.ReadLine());

            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;
            }

            if (temp == sum)
                Console.WriteLine(temp + " Is A Armstrong Number");
            else
                Console.WriteLine(temp + " Is Not A Armstrong Number");
            Console.ReadKey();
            Console.WriteLine("Adnan Mangaonkar 333");
        }
    }
}
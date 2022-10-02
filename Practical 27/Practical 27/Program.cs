using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Mangaonkar 333");
            //Multi-Dimensional array Example  
            /* Array with 4 rows and 2 columns*/
            int[,] _MultiDimentionArray = new int[4, 2] { { 3, 7 }, { 2, 9 }, { 0, 4 }, { 3, 1 } };
            int i, j;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, _MultiDimentionArray[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
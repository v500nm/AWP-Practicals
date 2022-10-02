using System;

namespace Conditional
{
    class IfElseStatementNamu
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adnan Mangaonkar 333");
            int no = 20;

            if (no < 5)
            {
                Console.WriteLine("{0} is less than 5", no);
            }
            else
            {
                Console.WriteLine("{0} is greater than or equal to 5", no);
            }

            Console.Read();
        }
    }
}

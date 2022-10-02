using System;

class program
{

    static public void Main()
    {
        Console.WriteLine("Adnan Mangaonkar 333");
        partA();
        partB();
        partC();
    }
    static void partA()
    {
        Console.WriteLine("Q14.a");
        for (int i = 1; i < 4; i++)
        {
            if (i == 3)
                break;

            Console.WriteLine("Bullet");
        }

    }
    static void partB()
    {
        Console.WriteLine("Q14.b");
        int number = 20;
        switch (number)
        {

            case 5:
                Console.WriteLine("case 5");
                break;
            case 10:
                Console.WriteLine("case 10");
                break;
            case 20:
                Console.WriteLine("case 20");


                goto case 5;

            default:
                Console.WriteLine("No match found");
                break;
        }
    }
    static void partC()
    {
        Console.WriteLine("Q14.c");
        for (int i = 1; i <= 10; i++)
        {

            if (i == 4)
                continue;

            Console.WriteLine(i);
        }
    }
}
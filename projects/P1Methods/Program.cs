class program
{
    static void Main()
    {
        Console.WriteLine("First count 0 - 5");
        drawUp();
        Console.WriteLine("First count 5 - 0");
        drawDown();
        Console.WriteLine("Second count 0 - 5");
        drawUp();
        Console.WriteLine("Second count 5 - 0");
        drawDown();
    }

    static void drawUp()
    {
        int number = 0;
        Console.WriteLine(number);
        number += 1;
        Console.WriteLine(number);
        Console.WriteLine(number + 1);
        Console.WriteLine(number + 2);
        Console.WriteLine(number + 3);
        Console.WriteLine(number + 4);



    }

    static void drawDown()
    {
        int number = 5;
        Console.WriteLine(number);
        number -= 1;
        Console.WriteLine(number);
        Console.WriteLine(number-1);
        Console.WriteLine(number-2);
        Console.WriteLine(number-3);
        Console.WriteLine(number-4);
    }
}



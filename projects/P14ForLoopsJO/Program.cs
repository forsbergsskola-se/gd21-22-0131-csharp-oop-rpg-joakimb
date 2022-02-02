int counter = 1; 
while (counter < 1000) 
{
    Console.ReadLine();
    for (int i = 1; i <= 1000; i++)
    {
        Console.WriteLine("Iteration" + i);
    }


    for (int i = 200; i >= 100; i--)
    {
        Console.WriteLine("Iteration" + i);
    }

    for (int i = 1024; i >= 1; i /= 2)
    {
        Console.WriteLine("Iteration" + i);
    }
}    
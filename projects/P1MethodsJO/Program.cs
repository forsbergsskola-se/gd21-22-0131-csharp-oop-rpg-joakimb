

class P1MethodsJO
{

    static void Main()
    {
        Console.WriteLine("Counting from 0 - 5");
        countUp();
        Console.WriteLine(" Counting from 5 - 0");
        countDown();
        Console.WriteLine(" Counting from 0 - 5");
        countUp();
        Console.WriteLine("Counting from 5 - 0 ");
        countDown();
    }

    static void countUp()
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

    static void countDown()
    {
        int number = 5;
        Console.WriteLine(number); 
        number -= 1;
        Console.WriteLine(number);
        Console.WriteLine(number - 1);
        Console.WriteLine(number - 2);
        Console.WriteLine(number - 3);
        Console.WriteLine(number - 4); 
    }
}
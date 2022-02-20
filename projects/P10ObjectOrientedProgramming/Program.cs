


string[] names = new string[3];
for (int num = 0; num < names.Length; num++)
{

    Console.WriteLine("Give me a name.");
    
    if (num == 0)
    {
        names[0] = Console.ReadLine();
    }
    if (num == 1)
    {
        names[1] = Console.ReadLine();
    }
     if (num == 2)
    {
        names[2] = Console.ReadLine();
    }
}
Console.WriteLine(names[0]+" "+ names[1] +" "+ names[2]);
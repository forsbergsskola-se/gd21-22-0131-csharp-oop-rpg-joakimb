

Console.WriteLine("I will roll 10.000 numbers between 0 and 10");            
int[] array = new int[11];
Random random = new Random();            
for (int i = 0; i < 10000; i++)
{
    
    int numRandom = random.Next(0, 11);
    array[numRandom]++;
}
            
for (var i = 0; i < array.Length; i++)
{
    var numRandom = random.Next(0, 11);
    Console.WriteLine("I rolled " + i +" "+ array [i] + " times" );
}


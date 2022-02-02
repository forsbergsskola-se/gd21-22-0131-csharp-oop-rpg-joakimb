using System.Diagnostics.Metrics;

Console.WriteLine(" I will roll 10.000 numbers between 0 and 10: ");
Console.ReadKey();


int[] array = new int[10000];
var randomGenerator = new Random();


for (int i = 0; i < 10000; i++)
{
    int randomInt = randomGenerator.Next(0, 10);
    array[i] = randomInt;
}

for (int i = 0; i < 10; i++)
{
    int occurrences = array.Count(x => x == i);
    Console.WriteLine(" I rolled " + array[i] + " of a total of " + occurrences + " Times " );
}

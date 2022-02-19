using System.Runtime.CompilerServices;

static class Program
{
    static void Main()
    {
        Unit leet = new Unit("leet", 1337);
        Unit Skeleton = new Unit("Skeleton",456);
        Unit Necromancer = new Unit("Necromancer",789);

        while (leet.IsAlive)
        {
          Console.WriteLine("How much damage do you want to deal to Leet?");
          leet.Damage(int.Parse(Console.ReadLine()));
        }
    }
}
public class Unit
{
    public string Name { get; }
    public int id;
    public static int nextId;
    public bool IsAlive
    {
        get
        {
            if (health >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    private int maxHealth;
    private int health;
    public Unit(string name, int maxHealth)
    {
        Name = name;
        id = nextId++;
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        //make sure this is the last line of the constructor:
        ReportStatus();
    }
    public void ReportStatus()
    {
        Console.WriteLine($"unit #{id}: {Name} - {health}/{maxHealth} Health");
    }
    public int Health
    {
        private set
        {
            health = Math.Clamp(value, 0, maxHealth);
            ReportStatus();
        }
        get
        {
            return health;
        }
    }
    public void Damage(int value)
    {
        Health -= value;
    }
}

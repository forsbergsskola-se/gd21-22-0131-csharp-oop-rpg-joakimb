


Person per = new Person();
Car car = new Car();
Animal anim = new Animal();

per.talk();
anim.wild();
car.gas();
class Person
{
    public void talk()
    {
        Console.WriteLine("Person");
    }
}
class Animal
{
    public void wild()
    {
        Console.WriteLine("Animal");
    }
}
class Car
{
    public void gas()
    {
        Console.WriteLine("Car");
    }
}
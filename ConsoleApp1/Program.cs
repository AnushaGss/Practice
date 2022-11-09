using System;

class Animal
{
    public virtual void animalsound()
    {
        Console.WriteLine("The Animal makes a sound");
    }
}
class Dog : Animal
{
    public override void animalsound()
    {
        Console.WriteLine("bark");
    }
}
class Cat : Animal
{
    public override void animalsound()
    {
        Console.WriteLine("mewww");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.animalsound();
        myDog.animalsound();
        myCat.animalsound();
    }
}
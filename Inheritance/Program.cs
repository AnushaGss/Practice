using System;
using System.Security.Cryptography.X509Certificates;

class Employee // base class  
{
    public float salary = 40000;
}
class Programer : Employee
{
    public float bonus = 10000;
}
class TestInheritance
{
    public static void Main(string[] args)
    {
        Programer p1 = new Programer();

        Console.WriteLine("Salary: " + p1.salary);
        Console.WriteLine("Bonus: " + p1.bonus);

    }
}


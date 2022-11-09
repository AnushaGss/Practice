class School
{
    public string name;
    public string standard;
    public int age;

    public School(string studentName, string studentStandard, int studentage)
    {
        name = studentName;
        standard = studentStandard;
        age = studentage;
    }


    static void Main(string[] args)
    {
        School Scl = new School("ac", "second", 8);
        Console.WriteLine("Name:" + Scl.name);
        Console.WriteLine("Standard:" + Scl.standard);
        Console.WriteLine("Age:" + Scl.age);
    }
}

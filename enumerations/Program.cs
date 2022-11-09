class Program
{
    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
    }
    static void Main (string[] args)
    {
        int myNum=(int) Months.July;
        Console.WriteLine (myNum);
    }
}
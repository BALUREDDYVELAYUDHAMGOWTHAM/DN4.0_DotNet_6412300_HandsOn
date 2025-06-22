
using System;

class Program
{
    //main function
    static void Main(string[] args)
    {
        Console.WriteLine("Singleton Pattern Example in C#");

        // Instance one creation
        Singleton s1 = Singleton.GetInstance();
        s1.ShowMessage("Instance 1 created.");

        // Instance two creation
        Singleton s2 = Singleton.GetInstance();
        s2.ShowMessage("Instance 2 created.");

        // checking whether two instances are pointing towards same instance
        Console.WriteLine($"Are both instances same? {object.ReferenceEquals(s1, s2)}");
    }
}

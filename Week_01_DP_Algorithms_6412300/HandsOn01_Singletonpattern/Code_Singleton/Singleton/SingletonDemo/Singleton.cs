using System;

public class Singleton
{
    private static Singleton _instance;
    private static readonly object _lock = new object();

    // Private constructor for Singleton to prevent any external instantiation
    private Singleton()
    {
        Console.WriteLine("Singleton Instance Created!");
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock) // thread-safety
            {
                // double checking whether the instance is null so to create only one instance
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
        }
        return _instance;
    }

    public void ShowMessage(string msg)
    {
        Console.WriteLine("Message from Singleton: " + msg);
    }
}

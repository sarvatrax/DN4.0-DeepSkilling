using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("First message");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("Second message");

        if (object.ReferenceEquals(logger1, logger2))
        {
            Console.WriteLine("Both logger instances are the same.");
        }
        else
        {
            Console.WriteLine("Different logger instances exist!");
        }
    }
}

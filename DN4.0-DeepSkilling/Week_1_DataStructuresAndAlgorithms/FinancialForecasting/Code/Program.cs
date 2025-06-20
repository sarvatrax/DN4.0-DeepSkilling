using System;

class Program
{
    static double FutureValue(int years, double value, double rate)
    {
        if (years == 0) return value;
        return FutureValue(years - 1, value, rate) * (1 + rate);
    }

    static void Main()
    {
        double presentValue = 10000;
        double growthRate = 0.1;
        int years = 3;

        double result = FutureValue(years, presentValue, growthRate);
        Console.WriteLine("Recursive Future Value: " + Math.Round(result, 2));
    }
}

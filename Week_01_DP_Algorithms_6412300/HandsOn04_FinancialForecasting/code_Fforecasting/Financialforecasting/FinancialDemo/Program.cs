using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<FinancialData> revenueHistory = new List<FinancialData>
        {
            new FinancialData(1, 10000),
            new FinancialData(2, 12000),
            new FinancialData(3, 15000),
            new FinancialData(4, 17000),
            new FinancialData(5, 20000)
        };

        Console.WriteLine("Financial Forecasting ");
        Console.Write("Enter the month number for predicting revenue (e.g., 6 for June): ");
        if (int.TryParse(Console.ReadLine(), out int futureMonth))
        {
            forecastservice forecaster = new forecastservice();
            double predicted = forecaster.PredictRevenue(revenueHistory, futureMonth);
            Console.WriteLine($"\nPredicted Revenue for Month {futureMonth}: ₹{predicted:F2}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}

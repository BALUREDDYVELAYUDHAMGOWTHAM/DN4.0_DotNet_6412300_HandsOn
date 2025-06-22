using System;
using System.Collections.Generic;
using System.Linq;

public class forecastservice
{
    public double PredictRevenue(List<FinancialData> history, int futureMonth)
    {
        int n = history.Count;
        if (n == 0) throw new Exception("No data available.");

        double sum1 = history.Sum(d => d.MonthNumber);
        double sum2 = history.Sum(d => d.Revenue);
        double sum12 = history.Sum(d => d.MonthNumber * d.Revenue);
        double sumX2 = history.Sum(d => d.MonthNumber * d.MonthNumber);

        double slope = (n * sum12 - sum1 * sum2) / (n * sumX2 - sum1 * sum1);
        double intercept = (sum2 - slope * sum1) / n;

        return slope * futureMonth + intercept;
    }
}

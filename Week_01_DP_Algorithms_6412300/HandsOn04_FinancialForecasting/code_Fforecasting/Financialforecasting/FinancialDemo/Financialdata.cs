public class FinancialData
{
    public int MonthNumber { get; set; }  
    public double Revenue { get; set; }

    public FinancialData(int monthNumber, double revenue)
    {
        MonthNumber = monthNumber;
        Revenue = revenue;
    }
}

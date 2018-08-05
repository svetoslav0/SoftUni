using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double currentPercentage = Percentage(firstPrice, nextPrice);
            bool isSignificantDifference = isNotMinor(currentPercentage, threshold);
            string message = PrintResult(nextPrice, firstPrice, currentPercentage, isSignificantDifference);
            Console.WriteLine(message);
            firstPrice = nextPrice;
        }
    }

    static string PrintResult(double currentPrice, double previousPrice, double diff, bool isbigEnough)
    {
        string result = "";
        if (diff == 0)
        {
            result = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isbigEnough)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, diff);
        }
        else if (isbigEnough && (diff > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, diff);
        }
        else if (isbigEnough && (diff < 0))
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, diff);
        return result;
    }
    static bool isNotMinor(double threshold, double diff)
    {
        if (Math.Abs(threshold) >= diff * 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static double Percentage(double last, double current)
    {
        double result = ((current - last) / last) * 100;
        return result;
    }
}

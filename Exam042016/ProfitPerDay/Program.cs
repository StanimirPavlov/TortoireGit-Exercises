using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitPerDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysMonth = int.Parse(Console.ReadLine());
            double dailyProfit = double.Parse(Console.ReadLine());
            double dollarRate = double.Parse(Console.ReadLine());

            double monthlyProfit = workingDaysMonth * dailyProfit;
            double EBIT = (monthlyProfit * 12) + (monthlyProfit * 2.5);
            double TAXes = EBIT * 0.25;
            double profitPerYear = EBIT - TAXes;
            double dailyIncomesDollars = profitPerYear / 365;
            double daylyIncomesBGN = dailyIncomesDollars * dollarRate;

            Console.WriteLine("{0:F2}", daylyIncomesBGN); 
        }
    }
}

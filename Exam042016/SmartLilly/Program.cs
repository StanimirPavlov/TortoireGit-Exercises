using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double priceWashingMashine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            int savingsMoneyGifted = 0;
            int moneyGift = 10;
            int toyGift = 0;

            for (int i = 1; i <= years; i++)
            {
                if (i % 2 == 0)
                {
                    savingsMoneyGifted += (moneyGift - 1);
                    moneyGift += 10;
                }
                else
                {
                    toyGift += 1;
                }
            }

            int savingsToyGifted = toyGift * priceToy;
            int totalSavings = savingsMoneyGifted + savingsToyGifted;
            double difference = totalSavings - priceWashingMashine;

            if (difference >= 0)
            {
                Console.WriteLine("Yes! {0:F2}", difference);
            }
            else
            {
                Console.WriteLine("No! {0:F2}", Math.Abs(difference));
            }
        }
    }
}

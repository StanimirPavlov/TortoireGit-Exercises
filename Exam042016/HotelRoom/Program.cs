using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            decimal nights = int.Parse(Console.ReadLine());
            decimal offerApp = 0;
            decimal offerStudio = 0;

            if (month == "May" || month == "Octomber")
            {
                if (nights <= 7)
                {
                     offerApp = nights * 65;
                     offerStudio = nights * 50;
                }
                else if (nights > 7 && nights <= 14)
                {
                     offerApp = nights * 65;
                     offerStudio = nights * (50 * 5)/100;
                }
                else if (nights > 14)
                {
                     offerApp = nights * (65 * 10) / 100;
                     offerStudio = nights * (50 * 30 ) / 100;
                }
            }
            if (month == "June" || month == "September")
            {
                if (nights <= 14)
                {
                    offerApp = nights * 6870/100;
                    offerStudio = nights * 7520/100;
                }
                else if (nights > 14)
                {
                     offerApp = nights * (6870/100 * (10/100));
                     offerStudio = nights * (7520/100 * (20/100));
                }
            }
            if (month == "July" || month == "August")
            {
                if (nights <= 14)
                {
                     offerApp = nights * 77;
                     offerStudio = nights * 76;
                }
                else if (nights > 14)
                {
                     offerApp = nights * (77 * 0.90);
                     offerStudio = nights * 76;
                }
            }
            
            Console.WriteLine("Apartment: {0:F2} lv.", offerApp);
            Console.WriteLine("Studio: {0:F2} lv.", offerStudio);
        }      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            double workingDays = days - (days * 0.1);
            double workingHours = workingDays * 8;
            double extraTime = (employees * days) * 2;
            double totalHours = Math.Floor(workingHours + extraTime);
            double differens = totalHours - hours;

            if (differens >= 0)
            {
                Console.WriteLine("Yes!{0} hours left.", differens);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(differens));
            }
        }
    }
}

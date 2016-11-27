using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepycatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int workingDays = 365 - holidays;
            int playing = (holidays * 127) + (workingDays * 63);
            int difference = 30000 - playing;
            int hours = difference / 60;
            int minutes = difference - (hours * 60);

            if (difference > 0)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
            else
            {
                hours = hours * (-1);
                minutes = minutes * (-1);
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
             
        }
    }
}

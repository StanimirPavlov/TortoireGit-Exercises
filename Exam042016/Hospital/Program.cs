using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int patients;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= period; i++)
            {
                patients = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctors++;
                }

                if (patients <= doctors)
                {
                    treatedPatients = treatedPatients + patients;
                }
                else
                {
                    treatedPatients = treatedPatients + doctors;
                    untreatedPatients = untreatedPatients + (patients - doctors);
                }
            }
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.",untreatedPatients);
        }
    }
}

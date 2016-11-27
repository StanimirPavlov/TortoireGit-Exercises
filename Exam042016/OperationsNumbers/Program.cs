using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operatorN1N2 = Console.ReadLine();
            double result = 0;

            if (operatorN1N2 == "+")
            {
                result = N1 + N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", N1, operatorN1N2, N2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", N1, operatorN1N2, N2, result);
                }
            }
            if (operatorN1N2 == "-")
            {
                result = N1 - N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", N1, operatorN1N2, N2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", N1, operatorN1N2, N2, result);
                }
            }
            if (operatorN1N2 == "*")
            {
                result = N1 * N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", N1, operatorN1N2, N2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", N1, operatorN1N2, N2, result);
                }
            }
            if (operatorN1N2 == "/")
            {
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    result = (N1 / (double)N2);
                    Console.WriteLine("{0} {1} {2} = {3:f2}", N1, operatorN1N2, N2, result);
                }
            }
            if (operatorN1N2 == "%")
            {
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    result = N1 % N2;
                    Console.WriteLine("{0} {1} {2} = {3}", N1, operatorN1N2, N2, result);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            for (int row = 1; row <= (first + second); row++)
            {
                for (int col = 1; col <= (first + third); col++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - first;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - second;
                    }
                    else
                    {
                        n = n + third;
                    }
                    Console.Write("{0} ", n);
                }
                Console.WriteLine();
            }



        }
    }
}

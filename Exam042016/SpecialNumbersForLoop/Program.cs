using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbersForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int firsNum = 1; firsNum <= 9; firsNum ++)
            {
                for (int secondNum = 1; secondNum <= 9; secondNum ++)
                {
                    for (int thirdNum = 1; thirdNum <= 9; thirdNum ++)
                    {
                        for (int fourthNum = 1; fourthNum <= 9; fourthNum ++)
                        {
                            if (N % fourthNum == 0 && N % thirdNum == 0 && N % secondNum == 0 && N % firsNum == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", firsNum, secondNum, thirdNum, fourthNum);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

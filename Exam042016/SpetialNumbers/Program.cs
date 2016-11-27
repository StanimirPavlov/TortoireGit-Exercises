using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpetialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                bool specialNum = true;
                int curNum = i;

                do
                {
                    int lastDig = curNum % 10;
                    curNum = curNum / 10;

                    if (lastDig == 0 || N % lastDig != 0)
                    {
                        specialNum = false;
                        break;
                    }
                } while (curNum > 0);
                if (specialNum)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}

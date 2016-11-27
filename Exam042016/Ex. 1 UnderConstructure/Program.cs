using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_UnderConstructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var O = int.Parse(Console.ReadLine());

            var NN = N * N;
            var WL = W * L;
            var MO = M * O;

            var num = (NN - MO) / WL;
            var time = num * 0.2;

            Console.WriteLine(num);
            Console.WriteLine(time);
        }
    }
}

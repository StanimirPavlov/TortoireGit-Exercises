using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOP_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int singWidth = (2 * (n + 1)) + ((2 * n) + 1);

            Console.Write(new string ('.', n + 1));
            Console.Write(new string('_', 2*n + 1));
            Console.WriteLine(new string('.', n + 1));

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string ('.', n - i));
                Console.Write(new string('/', 2));
                Console.Write(new string('_', (singWidth - 2*(n - i) - 4)));
                Console.Write(new string('\\', 2));
                Console.WriteLine(new string('.', n - i));
            }

            Console.Write(new string ('/', 2));
            Console.Write(new string ('_', (singWidth -9) / 2));
            Console.Write("STOP!");
            Console.Write(new string('_', (singWidth - 9) / 2));
            Console.WriteLine(new string('\\', 2));

            for (int j = n; j >= 1; j--)
            {
                Console.Write(new string ('.', n - j));
                Console.Write(new string('\\', 2));
                Console.Write(new string('_', (singWidth - 2 * (n - j) - 4)));
                Console.Write(new string('/', 2));
                Console.WriteLine(new string('.', n - j));
            }
        }
    }
}

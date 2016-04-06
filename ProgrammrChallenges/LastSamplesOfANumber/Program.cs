using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSamplesOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value for M: ");
            int m = 0;
            int.TryParse(Console.ReadLine(), out m);

            Console.Write("Enter a value for N: ");
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);

            Console.Write("Result: ");
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write(m - i + " ");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

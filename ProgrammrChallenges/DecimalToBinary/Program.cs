using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            decimal num = 0;
            decimal.TryParse(Console.ReadLine(), out num);

            if (num > 0)
            {

            }
        }
    }
}

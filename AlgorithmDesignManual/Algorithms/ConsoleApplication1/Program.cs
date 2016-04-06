using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 3;
            string binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = {"1","2","3","4","5","6","7","8","9" };
            var counter = arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(arr[(arr.Length-1)-i]);
            }

            Console.WriteLine("Program has finished running.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

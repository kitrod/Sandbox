using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = { 10, 8, 27, 22, 19, 4, 16, 3 };

            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("");
            collection = BubbleSort(collection, collection.Length);

            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n\nPress any key to exit...");
            Console.ReadKey();
        }

        static int[] BubbleSort(int[] dataset, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j=n -1; j>i; j--)
                {
                    if (dataset[j] < dataset[j - 1])
                    {
                        int temp = dataset[j];
                        dataset[j] = dataset[j - 1];
                        dataset[j - 1] = temp;
                    }
                }
            }
            return dataset;
        }
    }
}

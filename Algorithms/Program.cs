using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
          int[] input = { 4, 5, 7, 6 };
          input=BubbleSort.Sort(input);

            PrintArray(input);
            Console.ReadKey();
        }

        public static void PrintArray(int[] input)
        {
            foreach (int i in input)
            {
                Console.Write("{0}", i);
            }
        }
    }
}

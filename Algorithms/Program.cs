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
            //int[] input = { 4, 5, 7, 6 };
            Console.WriteLine("Enter the numbers to be sorted separated by comma:");
            string numbers = Console.ReadLine();
            int[] input = Utility.GetIntegerfromString(numbers);
            input = BubbleSort.Sort(input);
            Utility.PrintArray(input);
            Console.ReadKey();
        }

        
       
    }
}

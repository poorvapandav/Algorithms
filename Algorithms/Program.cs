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
            int[] input = GetIntegerfromString(numbers);
            input = BubbleSort.Sort(input);            
            PrintArray(input);
            Console.ReadKey();
        }

        public static void PrintArray(int[] input)
        {
            foreach (int i in input)
            {
                Console.WriteLine("{0}", i);
            }
        }

        public static int[] GetIntegerfromString(string input)
        {
            int[] numbers = null;
            string[] numbersInString = input.Split(',');
            numbers = Array.ConvertAll(numbersInString, int.Parse);
            return numbers;
        }
    }
}

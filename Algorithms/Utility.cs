using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Utility
    {
        public static void  Swap(ref int x,ref  int y)
        {
            int temp = x;
            x = y;
            y = temp;           
        }

        public static  int[] GetIntegerfromString(string input)
        {
            int[] numbers = null;
            string[] numbersInString = input.Split(',');
            numbers = Array.ConvertAll(numbersInString, int.Parse);
            return numbers;
        }

        public static void PrintArray(int[] input)
        {
            foreach (int i in input)
            {
                Console.WriteLine("{0}", i);
            }
        }

    }
}

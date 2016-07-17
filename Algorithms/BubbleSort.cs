using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BubbleSort
    { 

        public static int[] Sort(int[] input)
        {
            bool isSwitched = false;
            do
            {
                isSwitched = false;
                // one iteration for switching through array
                for (int i=0;i<=input.Length-2;i++)
                {
                    if(input[i]>input[i+1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        isSwitched = true;
                    }
                }

            } while (isSwitched); //iterate till it is not switched in for loop
            return input;
        }
    }
}

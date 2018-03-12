using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Good morning. Here's your coding interview problem for today.
 * 
 * Given an array of numbers, return whether any two sums to K.
 * 
 * For example, given [10, 15, 3, 7] and K of 17, return true since 10 + 7 is 17. 
 */


namespace DCP_1_12Mar2018
{
    class Program
    {
        static void Main(string[] args)
        {
            testInput();
        }

        static void testInput()
        {
            // Should be true, 10 + 7
            int[] numArray = new int[]{ 10, 15, 3, 7};
            System.Console.WriteLine(anyAddEquals(numArray, 17));

            // Should be false, no numbers
            numArray = new int[] { };
            System.Console.WriteLine(anyAddEquals(numArray, 17));

            // Should be false, no numbers but also adding to 0
            numArray = new int[] { };
            System.Console.WriteLine(anyAddEquals(numArray, 0));

            // Should be true, 2 + 18 = 20
            numArray = new int[] { 1, 2, 18, 95, 10, 55, 22, 16, 18, 16, 18, 11, 42};
            System.Console.WriteLine(anyAddEquals(numArray, 20));

            // Should be false
            numArray = new int[] { 1, 2, 18, 95, 10, 55, 22, 16, 18, 16, 18, 11, 42 };
            System.Console.WriteLine(anyAddEquals(numArray, 0));

            // Should be false
            numArray = new int[] { 1, 2, 18, 95, 10, 55, 22, 16, 18, 16, 18, 11, 42 };
            System.Console.WriteLine(anyAddEquals(numArray, 100));

        }

        static bool anyAddEquals(int[] NumberSet, int K)
        {
            for(int i = 0; i < NumberSet.Length; i++)
            {
                for(int j = 0; j < NumberSet.Length; j++)
                {
                    if(i != j)
                    {
                        if(NumberSet[i] + NumberSet[j] == K)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}

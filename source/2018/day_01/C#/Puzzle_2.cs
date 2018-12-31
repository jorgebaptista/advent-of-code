using System;
using System.Collections.Generic;

namespace Day_01
{
    class Puzzle_2
    {
        public static int Solve(int[] input)
        {
            int result = 0;
            //Declares a HashSet to save unique elements
            HashSet<int> frequencies = new HashSet<int>();

            while (true)
            {
                foreach (int number in input)
                {
                    result += number;

                    //checks if current sum(result) already exists inside the HashSet and if not to add
                    if (!frequencies.Add(result))
                    {
                        //Breaks out of all loops (and function) and returns the result
                        return result;
                    }
                }
            }
        }
    }
}
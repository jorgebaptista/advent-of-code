using System;
using System.Collections;
using System.Collections.Generic;

namespace Day_01
{
    class Puzzle_2
    {
        public static int Solve(string[] input)
        {
            int result = 0;
            List<int> frequencies = new List<int>();

            //runs loop until a duplicate sum is found
            while (true)
            {
                foreach (string number in input)
                {
                    result += Convert.ToInt32(number);

                    foreach (int frequency in frequencies)
                    {
                        //Checks if list already contains current sum(result)
                        if (result == frequency)
                        {
                            //Breaks out of all loops (and function) and returns the result
                            return result;
                        }
                    }
                    //Adds current sum(result) to the list
                    frequencies.Add(result);
                }
            }
        }
    }
}
using System;

namespace Day_01
{
    class Puzzle_1
    {
        public static int Solve(int[] input)
        {
            int result = 0;

            //Iterates through each element in the input array
            foreach (int number in input)
            {
                //Adds the value to result variable
                result += number;
            }

            return result;
        }
    }
}

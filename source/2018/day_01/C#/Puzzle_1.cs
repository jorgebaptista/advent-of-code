using System;

namespace Day_01
{
    class Puzzle_1
    {
        public static int Solve(string[] input)
        {
            int result = 0;

            foreach (string number in input)
            {
                //Converts string to int to prevent errors and sums with current result
                result += Convert.ToInt32(number);
            }

            return result;
        }
    }
}

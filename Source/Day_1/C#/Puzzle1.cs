using System;

namespace Day_1
{
    class Puzzle1
    {
        public static int Solve(string[] args)
        {            
            string[] inputs = args;

            int result = 0;

            foreach (string number in inputs)
            {
                //Converts string to int to prevent errors and sums with current result
                result += Convert.ToInt32(number);
            }

            return result;
        }
    }
}

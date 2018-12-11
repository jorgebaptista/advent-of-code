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
                result += Convert.ToInt32(number);
            }

            return result;
        }
    }
}

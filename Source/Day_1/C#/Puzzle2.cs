using System;
using System.Collections;
using System.Collections.Generic;

namespace Day_1
{
    class Puzzle2
    {
        public static int Solve(string[] args)
        {
            string[] inputs = args;

            List<int> frequencies = new List<int>();
            int result = 0;

            bool done = false;

            while (!done)
            {
                foreach (string number in inputs)
                {
                    frequencies.Add(result);

                    result += Convert.ToInt32(number);

                    foreach (int frequency in frequencies)
                    {
                        if (result == frequency)
                        {
                            done = true;
                            return result;
                        }
                    }
                }
            }
            return result;
        }
    }
}
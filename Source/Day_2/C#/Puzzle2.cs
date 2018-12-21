using System;
using System.Collections;
using System.Collections.Generic;

namespace Day_2
{
    class Puzzle2
    {
        public static string Solve(string[] args)
        {
            string[] inputs = args;

            string result = null;

            for (int i = 0; i < inputs.Length; i++)
            {
                for (int j = i + 1; j < inputs.Length; j++)
                {
                    int differentChars = 0;

                    for (int k = 0; k < inputs[j].Length; k++)
                    {
                        if (inputs[i][k] != inputs[j][k])
                        {
                            differentChars++;
                        }
                    }

                    if (differentChars == 1)
                    {
                        List<char> commonID = new List<char>();

                        for (int k = 0; k < inputs[i].Length; k++)
                        {
                            if (inputs[i][k] == inputs[j][k])
                            {
                                commonID.Add(inputs[i][k]);
                            }
                        }

                        result = new string(commonID.ToArray());
                    }
                }
            }

            return result;
        }
    }
}
using System;

namespace 2018
{
    class Puzzle_1
    {
        public static int Solve(string[] args)
        {
            string[] inputs = args;

            string[,] fabric = new string[1000, 1000];
            string[] delimiters = { "#", " @ ", ",", ": ", "x" };

            int fabricArea = 0;

            foreach (string input in inputs)
            {
                string[] separatedInput = input.Split(delimiters, System.StringSplitOptions.RemoveEmptyEntries);

                int xPadding = Int32.Parse(separatedInput[1]);
                int yPadding = Int32.Parse(separatedInput[2]);
                int width = Int32.Parse(separatedInput[3]);
                int height = Int32.Parse(separatedInput[4]);

                for (int x = xPadding; x < xPadding + width; x++)
                {
                    for (int y = yPadding; y < yPadding + height; y++)
                    {
                        if (fabric[x, y] != "x")
                        {
                            if (fabric[x, y] != "#") fabric[x, y] = "#";
                            else
                            {
                                fabric[x, y] = "x";
                                fabricArea++;
                            }
                        }
                    }
                }
            }

            return fabricArea;
        }
    }
}

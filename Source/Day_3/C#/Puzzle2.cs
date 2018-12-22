using System;

namespace Day_3
{
    class Puzzle2
    {
        struct Claim
        {
            public int id;
            public string inch;
        }

        public static int Solve(string[] args)
        {
            string[] inputs = args;

            Claim[,] fabric = new Claim[1000, 1000];
            string[] delimiters = { "#", " @ ", ",", ": ", "x" };

            int correctClaimID = 0;

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
                        if (fabric[x, y].inch != "x")
                        {
                            if (fabric[x, y].inch != "#")
                            {
                                fabric[x, y].inch = "#";
                                fabric[x, y].id = Int32.Parse(separatedInput[0]);
                            }
                            else fabric[x, y].inch = "x";
                        }
                    }
                }
            }

            foreach (string input in inputs)
            {
                string[] separatedInput = input.Split(delimiters, System.StringSplitOptions.RemoveEmptyEntries);

                int xPadding = Int32.Parse(separatedInput[1]);
                int yPadding = Int32.Parse(separatedInput[2]);
                int width = Int32.Parse(separatedInput[3]);
                int height = Int32.Parse(separatedInput[4]);

                int overlappedInches = 0;

                for (int x = xPadding; x < xPadding + width; x++)
                {
                    for (int y = yPadding; y < yPadding + height; y++)
                    {
                        if (fabric[x, y].inch == "x") overlappedInches++;
                    }
                }
                
                if (overlappedInches == 0) correctClaimID = fabric[xPadding, yPadding].id;
            }

            return correctClaimID;
        }
    }
}

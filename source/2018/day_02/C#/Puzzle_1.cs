using System;
using System.Collections;
using System.Collections.Generic;

namespace Day_02
{
    class Puzzle_1
    {
        public static int Solve(string[] args)
        {
            string[] inputs = args;

            int doubleLetterID = 0, tripleLetterID = 0;

            foreach (string input in inputs)
            {
                List<char> checkedLetters = new List<char>();

                bool checkedDouble = false, checkedTriple = false;

                foreach (char letter in input)
                {
                    if (!checkedLetters.Contains(letter))
                    {
                        checkedLetters.Add(letter);

                        int nIdenticalLetters = 0;

                        foreach (char subLetter in input)
                        {
                            if (subLetter == letter) nIdenticalLetters++;
                        }

                        if (nIdenticalLetters == 3 && !checkedTriple)
                        {
                            tripleLetterID++;
                            checkedTriple = true;
                        }
                        else if (nIdenticalLetters == 2 && !checkedDouble)
                        {
                            doubleLetterID++;
                            checkedDouble = true;
                        }
                    }
                }
            }

            return doubleLetterID * tripleLetterID;
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;

namespace Day_2
{
    class Puzzle1
    {
        public static int Solve(string[] args)
        {
            string[] inputs = args;

            int doubleLetterID = 0, tripleLetterID = 0;

            foreach (string input in inputs)
            {
                List<char> checkedLetters = new List<char>();

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

                        if (nIdenticalLetters == 3) tripleLetterID++;
                        else if (nIdenticalLetters == 2) doubleLetterID++;
                    }
                }
            }

            Console.WriteLine("double {0}, Triple {1}", doubleLetterID, tripleLetterID);

            return doubleLetterID * tripleLetterID;
        }
    }
}
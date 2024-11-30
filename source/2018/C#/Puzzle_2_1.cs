using System;
using System.Collections;
using System.Collections.Generic;

namespace 2018
{
    class Puzzle_1
    {
        public static int Solve(string[] input)
        {
            //create variables to store number of IDs with exactly 2 or 3 letters, respectively
            int doubleLetterIDs = 0, tripleLetterIDs = 0;

            foreach (string iD in input)
            {
                //Declares HashSet to save unique elements
                HashSet<char> checkedLetters = new HashSet<char>();

                bool hasDouble = false, hasTriple = false;

                //Iterates through each letter of the ID
                foreach (char letter in iD)
                {
                    //Checks if current letter has already been checked and if not to add to the HashSet
                    if (!checkedLetters.Add(letter))
                    {
                        int identicalLetters = 0;

                        foreach (char comparingLetter in iD)
                        {
                            if (comparingLetter == letter) identicalLetters++;
                        }

                        //To reduce unnecessary iterations checks if the ID already has double or triple identical letters
                        if (!hasDouble || !hasTriple)
                        {
                            //Checks if it's the first time it has been found 2 identical letters in this ID
                            if (identicalLetters == 2 && !hasDouble)
                            {
                                hasDouble = true;
                                doubleLetterIDs++;
                            }
                            if (identicalLetters == 3 && !hasTriple)
                            {
                                hasTriple = true;
                                tripleLetterIDs++;
                            }
                        }
                        //Breaks out of the loop
                        else break;
                    }
                }
            }
            //Returns multiplication of double and triple letter IDs as asked by the puzzle
            return doubleLetterIDs * tripleLetterIDs;
        }
    }
}
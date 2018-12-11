using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gets the INPUTS file containing the information to solve the puzze and converts it into an array of strings
            string[] inputs = System.IO.File.ReadAllLines(@"../INPUTS.txt");

            //Creates variables for each of the puzzles and assigns respective functions to it (see Puzzle1 and Puzzle2 csharp files for each function)
            int puzzleSolution_1 = Puzzle1.Solve(inputs);
            int puzzleSolution_2 = Puzzle2.Solve(inputs);

            //Prints both solutions
            Console.WriteLine("Puzzle 1 solution: " + puzzleSolution_1);
            Console.WriteLine("Puzzle 2 solution: " + puzzleSolution_2);
        }
    }
}
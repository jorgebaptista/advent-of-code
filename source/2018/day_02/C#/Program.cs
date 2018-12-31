using System;

namespace Day_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gets the input file containing the ids required to solve the puzzle and separates values into a string array
            string[] input = System.IO.File.ReadAllLines(@"../input.txt");

            //Declares variables for each of the puzzles solutions and assigns respective functions to it 
            //(See Puzzle_1 and Puzzle_2 csharp files for each function code)
            int puzzleSolution_1 = Puzzle_1.Solve(input);
            string puzzleSolution_2 = Puzzle_2.Solve(input);

            //Prints both solutions
            Console.WriteLine("Puzzle 1 Solution: {0}.", puzzleSolution_1);
            Console.WriteLine("Puzzle 2 Solution: {0}.", puzzleSolution_2);
        }
    }
}

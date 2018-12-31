using System;

namespace Day_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gets the input file containing the information to solve the puzzle, separates values into a string array and converts it to int
            int[] inputs = Array.ConvertAll(System.IO.File.ReadAllLines(@"../input.txt"), int.Parse);

            //Declares variables for each of the puzzles solutions and assigns respective functions to it 
            //(See Puzzle_1 and Puzzle_2 csharp files for each function code)
            int puzzleSolution_1 = Puzzle_1.Solve(inputs);
            int puzzleSolution_2 = Puzzle_2.Solve(inputs);

            //Prints both solutions
            Console.WriteLine("Puzzle 1 solution: " + puzzleSolution_1);
            Console.WriteLine("Puzzle 2 solution: " + puzzleSolution_2);
        }
    }
}
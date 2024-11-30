using System;

namespace 2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gets the input file containing the information to solve the puzzle, separates values into a string array and converts it to int
            int[] input1 = Array.ConvertAll(System.IO.File.ReadAllLines(@"../input1.txt"), int.Parse);
            int[] input2 = Array.ConvertAll(System.IO.File.ReadAllLines(@"../input2.txt"), int.Parse);
            int[] input3 = Array.ConvertAll(System.IO.File.ReadAllLines(@"../input3.txt"), int.Parse);
            int[] input4 = Array.ConvertAll(System.IO.File.ReadAllLines(@"../input4.txt"), int.Parse);

            //Declares variables for each of the puzzles solutions and assigns respective functions to it 
            //(See Puzzle_1 and Puzzle_2 csharp files for each function code)
            int puzzleSolution_1_1 = Puzzle_1_1.Solve(input1);
            int puzzleSolution_1_2 = Puzzle_1_2.Solve(input1);
            int puzzleSolution_2_1 = Puzzle_2_1.Solve(input2);
            string puzzleSolution_2_2 = Puzzle_2_2.Solve(input2);
            int puzzleSolution_3_1 = Puzzle_3_1.Solve(input3);
            int puzzleSolution_3_2 = Puzzle_3_2.Solve(input3);
            int puzzleSolution_4_1 = Puzzle_4_1.Solve(input4);
            int puzzleSolution_4_2 = Puzzle_4_2.Solve(input4);

            //Prints both solutions
            Console.WriteLine("Puzzle 1 - 1 solution: " + puzzleSolution_1_1);
            Console.WriteLine("Puzzle 1 - 2 solution: " + puzzleSolution_1_2);
            Console.WriteLine("Puzzle 2 - 1 solution: " + puzzleSolution_2_1);
            Console.WriteLine("Puzzle 2 - 2 solution: " + puzzleSolution_2_2);
            Console.WriteLine("Puzzle 3 - 1 solution: " + puzzleSolution_3_1);
            Console.WriteLine("Puzzle 3 - 2 solution: " + puzzleSolution_3_2);
            Console.WriteLine("Puzzle 4 - 1 solution: " + puzzleSolution_4_1);
            Console.WriteLine("Puzzle 4 - 2 solution: " + puzzleSolution_4_2);
        }
    }
}
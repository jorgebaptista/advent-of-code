using System;

namespace Day_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = System.IO.File.ReadAllLines(@"../input.txt");

            int puzzleSolution_1 = Puzzle_1.Solve(inputs);
            int puzzleSolution_2 = Puzzle_2.Solve(inputs);

            Console.WriteLine("Puzzle 1 Solution: {0}.", puzzleSolution_1);
            Console.WriteLine("Puzzle 2 Solution: {0}.", puzzleSolution_2);
        }
    }
}

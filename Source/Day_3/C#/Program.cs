using System;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = System.IO.File.ReadAllLines(@"../INPUTS.txt");

            int puzzleSolution_1 = Puzzle1.Solve(inputs);
            int puzzleSolution_2 = Puzzle2.Solve(inputs);

            Console.WriteLine("Puzzle 1 Solution: {0}.", puzzleSolution_1);
            Console.WriteLine("Puzzle 2 Solution: {0}.", puzzleSolution_2);
        }
    }
}

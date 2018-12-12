using System;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = System.IO.File.ReadAllLines(@"../INPUTS.txt");

            int puzzleSolution_1 = Puzzle1.Solve(inputs);

            Console.WriteLine("Puzzle 1 Solution: " + puzzleSolution_1);
        }
    }
}

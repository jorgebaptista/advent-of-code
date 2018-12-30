import puzzle_1
import puzzle_2

# Read lines from input file and assign them to a list called input
with open("../input.txt", "r") as information:
    input = information.readlines()
    
# Turn into a list of int
data = list(map(int, input))

# Declares variables for each of the puzzles solutions and assigns respective functions to it 
# (See puzzle_1 and puzzle_2 python files for each function code)
puzzle1_solution = puzzle_1.solve(data)
puzzle2_solution = puzzle_2.solve(data)

# Prints both solutions
print("Puzzle 1 Solution :" , puzzle1_solution)
print("Puzzle 2 Solution :" , puzzle2_solution)
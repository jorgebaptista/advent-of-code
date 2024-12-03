import puzzle_1_1
import puzzle_1_2
import puzzle_2_1
import puzzle_2_2

# Read lines from input file and assign them to a list called input
with open("../input1.txt", "r") as information:
    input1 = information.readlines()
with open("../input2.txt", "r") as information:
    input2 = information.readlines()
    
# Turn into a list of int
data1 = list(map(int, input1))
data2 = list(map(int, input2))

# Declares variables for each of the puzzles solutions and assigns respective functions to it 
# (See puzzle_1 and puzzle_2 python files for each function code)
puzzle1_1_solution = puzzle_1_1.solve(data1)
puzzle1_2_solution = puzzle_1_2.solve(data1)
puzzle2_1_solution = puzzle_2_1.solve(data2)
puzzle2_2_solution = puzzle_2_2.solve(data2)


# Prints both solutions
print("Puzzle 1 - 1 Solution :" , puzzle1_1_solution)
print("Puzzle 1 - 2 Solution :" , puzzle1_2_solution)
print("Puzzle 2 - 1 Solution :" , puzzle2_1_solution)
print("Puzzle 2 - 2 Solution :" , puzzle2_2_solution)
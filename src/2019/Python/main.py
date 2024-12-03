import puzzle_1_2
import puzzle_1_2
import puzzle_2_1
import puzzle_2_2
import puzzle_4_1
import puzzle_4_2


with open("../input1.txt", "r") as information:
    data1 = list(map(int, information.readlines()))
    
with open("../input2.txt", "r") as information:
    data2 = list(map(int, information.readlines()))
    
with open("../input4.txt", "r") as information:
    data4 = list(map(int, information.readlines()))

puzzle1_1_solution = puzzle_1_2.solve(data1)
puzzle1_2_solution = puzzle_1_2.solve(data1)
puzzle2_1_solution = puzzle_2_1.solve(data2)
puzzle2_2_solution = puzzle_2_2.solve(data2)
puzzle4_1_solution = puzzle_4_1.solve(data4)
puzzle4_2_solution = puzzle_4_2.solve(data4)

print("Puzzle 1 - 1 Solution:", puzzle1_1_solution)
print("Puzzle 1 - 2 Solution:", puzzle1_2_solution)
print("Puzzle 2 - 1 Solution:", puzzle2_1_solution)
print("Puzzle 2 - 2 Solution:", puzzle2_2_solution)
print("Puzzle 4 - 1 Solution:", puzzle4_1_solution)
print("Puzzle 4 - 2 Solution:", puzzle4_2_solution)
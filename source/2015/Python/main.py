import puzzle_1_1
import puzzle_1_2
import puzzle_2_1

with open("../input1.txt", "r") as information:
    data1 = information.read()
with open("../input2.txt", "r") as information:
    data2 = information.read()

puzzle1_1_solution = puzzle_1_1.solve(data1)
puzzle1_2_solution = puzzle_1_2.solve(data1)
puzzle2_1_solution = puzzle_2_1.solve(data2)

print("Puzzle 1 - 1 Solution:", puzzle1_1_solution)
print("Puzzle 1 - 2 Solution:", puzzle1_2_solution)
print("Puzzle 2 - 1 Solution:", puzzle2_1_solution)

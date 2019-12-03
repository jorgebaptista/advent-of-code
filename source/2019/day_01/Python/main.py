import puzzle_1
import puzzle_2

with open("../input.txt", "r") as information:
    input = information.readlines()

data = list(map(int, input))

puzzle1_solution = puzzle_1.solve(data)
puzzle2_solution = puzzle_2.solve(data)

print("Puzzle 1 Solution:", puzzle1_solution)
print("Puzzle 2 Solution:", puzzle2_solution)

import puzzle_1

with open("../input.txt", "r") as information:
    data = information.readlines()

puzzle1_solution = puzzle_1.solve(data)

print("Puzzle 1 Solution: ", puzzle1_solution)
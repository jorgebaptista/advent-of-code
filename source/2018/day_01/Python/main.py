with open("../input.txt", "r") as information:
    input = information.readlines()
    
data = list(map(int, input))

def solve_puzzle1():
    result = 0
    
    for number in data:
        result += number
    
    return result
        

def solve_puzzle2():
    result = 0
    unique_frequencies = set()

    while True:
        for number in data:
            result += number

            if result in unique_frequencies:
                return result

            unique_frequencies.add(result)


puzzle1_solution = solve_puzzle1()
puzzle2_solution = solve_puzzle2()

print("Puzzle 1 Solution :" , puzzle1_solution)
print("Puzzle 2 Solution :" , puzzle2_solution)

with open("../input.txt", "r") as information:
    input = information.readlines()

def solve_puzzle1():
    result = 0
    
    for data in input:
        result += int(data)
    
    return result
        

def solve_puzzle2():
    result = 0
    unique_frequencies = set()
    data = list(map(int, input))

    while True:
        for i in data:
            result += i

            if result in unique_frequencies:
                return result

            unique_frequencies.add(result)


puzzle1_solution = solve_puzzle1()
puzzle2_solution = solve_puzzle2()

print("Puzzle 1 Solution :" , puzzle1_solution)
print("Puzzle 2 Solution :" , puzzle2_solution)

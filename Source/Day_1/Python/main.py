with open("../INPUTS.txt", "r") as information:
    inputs = information.readlines()


def solve_puzzle1():
    result = 0
    
    for data_input in inputs:
        result += int(data_input)
    
    return result
        

def solve_puzzle2():
    result = 0
    frequencies = []

    while True:
        for data_input in inputs:
            result += int(data_input)

            if result in frequencies:
                return result

            frequencies.append(result)


puzzle1_solution = solve_puzzle1()
puzzle2_solution = solve_puzzle2()

print("Puzzle 1 Solution :" + puzzle1_solution)
print("Puzzle 2 Solution :" + puzzle2_solution)

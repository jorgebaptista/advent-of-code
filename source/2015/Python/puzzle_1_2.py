def solve(data):
    index = 0
    floor = 0

    while index < len(data):
        if data[index] == '(':
            floor += 1
        elif data[index] == ')':
            floor -= 1
        else:
            print("Something went wrong.")
        
        if floor == -1:
            return index + 1
        else:
            index += 1
    
    print("Something went wrong.")
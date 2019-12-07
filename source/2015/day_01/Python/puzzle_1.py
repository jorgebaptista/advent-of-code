def solve(data):
    result = 0

    for char in data:
        if char == '(':
            result += 1
        elif char == ')':
            result -= 1
        else:
            print("Something went wrong.")
    
    return result
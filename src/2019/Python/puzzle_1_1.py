def solve(data):
    result = 0

    for number in data:
        number = int(number/3)
        number -= 2
        result += number
    
    return result
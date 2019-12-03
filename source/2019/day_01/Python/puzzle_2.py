def solve(data):
    result = 0

    for number in data:
        while number > 0:
            number = int(number/3)
            number -= 2
            if number > 0:
                result += number
    
    return result
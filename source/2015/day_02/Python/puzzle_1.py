def solve(data):

    result = 0

    for lines in data:
        dimensions = list(map(int, lines.split('x')))

        l = dimensions[0]
        w = dimensions[1]
        h = dimensions[2]

        dimensions[0] = l * w
        dimensions[1] = w * h
        dimensions[2] = h * l

        smallest_side = min(dimensions)

        for dimension in dimensions:
            result += dimension * 2
        
        result += smallest_side
    
    return result
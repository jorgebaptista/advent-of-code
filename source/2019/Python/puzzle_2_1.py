def solve(original_data):
    data = list(original_data)
    op_code = 0
    current_index = 0

    op_code = data[current_index]

    data[1] = 12
    data[2] = 2

    while op_code != 99:
        if op_code == 1:
            data[data[current_index + 3]] = data[data[current_index + 1]] + data[data[current_index + 2]]
        elif op_code == 2:
            data[data[current_index + 3]] = data[data[current_index + 1]] * data[data[current_index + 2]]

        current_index += 4
        op_code = data[current_index]

    return data[0]
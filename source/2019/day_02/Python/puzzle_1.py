def solve(data):
    current_num = 0
    current_opcode = 0

    current_num = data[current_opcode]

    data[1] = 12
    data[2] = 2

    while current_num != 99:
        
        
        # print(data[current_opcode])
        if current_num == 1:
            data[data[current_opcode + 3]] = data[data[current_opcode + 1]] + data[data[current_opcode + 2]]
            current_opcode += 4
        elif current_num == 2:
            data[data[current_opcode + 3]] = data[data[current_opcode + 1]] * data[data[current_opcode + 2]]
            current_opcode += 4
        else:
            current_opcode += 1

        current_num = data[current_opcode]

    return data[0]
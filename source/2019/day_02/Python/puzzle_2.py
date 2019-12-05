def solve(original_data):
    data = list(original_data)
    op_code = 0

    address1 = 0
    address2 = 0

    while True:
        data = list(original_data)
        data[1] = address1
        data[2] = address2    

        current_index = 0
        op_code = data[current_index]

        while op_code != 99:
            if op_code == 1:
                data[data[current_index + 3]] = data[data[current_index + 1]] + data[data[current_index + 2]]
            elif op_code == 2:
                data[data[current_index + 3]] = data[data[current_index + 1]] * data[data[current_index + 2]]
            
            if data[0] == 19690720:
                return 100 * data[1] + data[2]

            current_index += 4
            op_code = data[current_index]

        address1 += 1

        if address1 > 99:
            address1 = 0
            address2 += 1
            if address2 > 99:
                print("Something's wrong.")
                break
def solve(data):
    min_num = data[0]
    max_num = data[1]    

    possible_passwords = 0

    current_num = min_num    

    while current_num <= max_num:
        converted_num = str(current_num)

        is_possible_password = False

        last_char = 0
        current_char = 0
        current_index = 0

        while current_index < len(converted_num):

            current_char = converted_num[current_index]

            if current_index > 0:
                if current_char < last_char:
                    is_possible_password = False
                    break
                elif current_char == last_char:
                    is_possible_password = True
            
            last_char = converted_num[current_index]
            
            current_index += 1

        if is_possible_password:
            possible_passwords += 1

        current_num += 1

    return possible_passwords
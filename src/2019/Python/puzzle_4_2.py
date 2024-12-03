def solve(data):
    min_num = data[0]
    max_num = data[1]

    possible_passwords = 0

    current_num = min_num

    while current_num <= max_num:
        converted_num = str(current_num)

        is_sorted = True
        has_double = False

        last_char = 0
        current_char = 0
        current_index = 0

        multiple_chars = list()

        while current_index < len(converted_num):

            current_char = converted_num[current_index]

            if current_index > 0:
                if current_char < last_char:
                    is_sorted = False
                    break
                elif current_char == last_char:
                    if current_char not in multiple_chars:
                        multiple_chars.append(current_char)

            last_char = converted_num[current_index]

            current_index += 1

        for char in multiple_chars:
            if converted_num.count(char) == 2:
                has_double = True

        if is_sorted and has_double:
            possible_passwords += 1

        current_num += 1

    return possible_passwords

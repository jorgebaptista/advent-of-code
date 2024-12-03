def solve(data):
    #Declares variables for number of ids with double and triple identical letters
    double_letter_ids = 0
    triple_letter_ids = 0

    for line in data:
        has_double = False
        has_triple = False

        for letter in line:
            #To reduce unnecessary iterations checks if the ID already has double or triple identical letters
            if not has_double or not has_triple:
                #Checks if it's the first time it has been found 2 identical letters in this ID
                if line.count(letter) == 2 and not has_double:
                    double_letter_ids += 1
                    has_double = True
                if line.count(letter) == 3 and not has_triple:
                    triple_letter_ids += 1
                    has_triple = True
            else:
                #Breaks out of the loop
                break
    # Returns multiplication of double and triple letter IDs as asked by the puzzle
    return double_letter_ids * triple_letter_ids

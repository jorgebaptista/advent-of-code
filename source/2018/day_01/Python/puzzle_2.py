def solve(data):
    result = 0
    # Creates and unordered collection of unique elements
    unique_frequencies = set()

    while True:
        for number in data:
            result += number

            # Checks if current sum(result) already exists in the collection
            if result in unique_frequencies:
                # Breaks out of the function and returns the result
                return result

            # Adds current sum(result) to the collection
            unique_frequencies.add(result)
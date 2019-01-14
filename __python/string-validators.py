if __name__ == '__main__':
    s = input()
    true = "True"
    false = "False"
    result_is_alnum = True in [True for i in s if i.isalnum()]
    result_is_isalpha = True in [True for i in s if i.isalpha()]
    result_is_isdigit = True in [True for i in s if i.isdigit()]
    result_is_islower = True in [True for i in s if i.islower()]
    result_is_isupper = True in [True for i in s if i.isupper()]

    print(True if result_is_alnum else False);
    print(True if result_is_isalpha else False);
    print(True if result_is_isdigit else False);
    print(True if result_is_islower else False);
    print(True if result_is_isupper else False);


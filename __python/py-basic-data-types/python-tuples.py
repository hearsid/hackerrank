if __name__ == '__main__':
    n = int(input())
    integer_list = input().split()
    integer_list = [int(x) for x in integer_list]
    tp = tuple(integer_list)
    print(hash(tp))

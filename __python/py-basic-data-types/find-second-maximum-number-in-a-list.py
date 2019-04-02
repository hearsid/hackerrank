if __name__ == '__main__':
    n = int(input())
    arr = map(int, input().split())
   
arr = set(arr)
arr = sorted(arr)
print(arr[len(arr)-2])

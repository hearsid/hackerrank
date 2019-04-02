from itertools import product
# Enter your code here. Read input from STDIN. Print output to STDOUT
A = map(int, input().split())
B = map(int, input().split())

ls = list(product(A, B))
result = ''
for i in ls:
    result += str(i)+' '

print(result)

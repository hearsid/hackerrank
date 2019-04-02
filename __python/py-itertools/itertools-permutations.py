# Enter your code here. Read input from STDIN. Print output to STDOUT
from itertools import permutations

letters, count = input().split()

perm = permutations(letters, int(count))
result = list()
for i in perm:
    result.append(''.join(i))

result.sort()
for j in result:
    print(''.join(j))


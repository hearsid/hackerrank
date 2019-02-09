# Enter your code here. Read input from STDIN. Print output to STDOUT
from itertools import combinations
if __name__ == '__main__':
    s,c = input().split()

comb = combinations(s,int(c))
comb = list(comb)
result = list()

for i in comb:
    result.append(''.join(i))

result.sort()

s = list(s)
s.sort()
for j in s:
    print(j);

for k in result:
    print(''.join(k))


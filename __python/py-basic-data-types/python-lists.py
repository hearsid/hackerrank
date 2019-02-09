if __name__ == '__main__':
    N = int(input())
    
ls = list()
for i in range(0, N):
    line = input()
    line = line.split(' ')
    op = line[0]
    if op == 'insert':
        loc = line[1]
        val = line[2]
        ls.insert(int(loc), int(val));
    elif op == 'print':
        print(ls);
    elif op == 'remove':
        loc = line[1]
        ls.remove(int(loc));
    elif op == 'sort':
        ls.sort();
    elif op == 'reverse':
        ls.reverse();
    elif op == 'pop':
        ls.pop();
    elif op == 'append':
        el = line[1]
        ls.append(int(el))
        
        

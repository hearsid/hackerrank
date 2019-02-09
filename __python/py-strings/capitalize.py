
from functools import reduce
# Complete the solve function below.
def solve(s):
   # summy = lambda x,y: x+" "+y
    ls = s.split()
    ls = [ i.capitalize() for i in ls]
   # result = reduce(summy, ls)
    mod_s = ''
    for i in ls:
        if i.lower() in s:
            s = s.replace(i.lower(), i)
    return s



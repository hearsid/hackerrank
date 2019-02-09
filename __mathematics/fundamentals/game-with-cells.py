#!/bin/python3

import os
import sys

#
# Complete the gameWithCells function below.
#
def gameWithCells(n, m):
    return int((n+n%2)*(m+m%2)/4)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    nm = input().split()

    n = int(nm[0])

    m = int(nm[1])

    result = gameWithCells(n, m)

    fptr.write(str(result) + '\n')

    fptr.close()


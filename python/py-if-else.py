#!/bin/python3

N = int(input())
weird = 'Weird';
notWeird = 'Not Weird';

if N%2 == 0:
    if N>=2 and N<=5:
        print(notWeird);
    elif N>=6 and N<=20:
        print(weird);
    else:
        print(notWeird);
else:
    print(weird);
    



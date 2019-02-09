using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int getTriangleHeight(int a, int b) {
        int h = 2*a/b;
        return h;
    }

    static int lowestTriangle(int b, int area){
        // area of triangle a = h*b /2
        // we get the height from above formula
        // area at least a so can consider more values 
        int height = getTriangleHeight(area, b);
        int minIntHeight = height;
        int newAreaRemainder = (2*area)%b;
        if (newAreaRemainder != 0) { // if the area is not completely divisible by base then area can be increase and thus height as well.
            minIntHeight +=1;
        }
        return minIntHeight;
    }

    static void Main(String[] args) {
        string[] tokens_base = Console.ReadLine().Split(' ');
        int b = Convert.ToInt32(tokens_base[0]);
        int area = Convert.ToInt32(tokens_base[1]);
        int height = lowestTriangle(b, area);
        Console.WriteLine(height);
    }
}



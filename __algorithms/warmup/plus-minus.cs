using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the plusMinus function below.
       static void plusMinus(int[] arr)
    {
        float negativeCount = 0;
        float positiveCount = 0;
        float zeroCount = 0;
        foreach(int a in arr)
        {
            if(a>0)
            {
                positiveCount += 1;
            } else if (a<0)
            {
                negativeCount += 1;
            } else if (a == 0)
            {
                zeroCount += 1;
            }
        }
        float total = arr.Length;
        Console.WriteLine(positiveCount / total);
        Console.WriteLine(negativeCount / total);
        Console.WriteLine(zeroCount / total);


    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}


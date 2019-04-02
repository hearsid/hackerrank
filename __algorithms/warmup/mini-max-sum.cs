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

    // Complete the miniMaxSum function below.
     static void miniMaxSum(int[] arr)
    {
        Array.Sort(arr);
        // List<int> lst = arr.OfType<int>().ToList();
        long minSum = (long)arr[0] + arr[1] + arr[2] + (long)arr[3];
        long maxSum = (long)arr[1] + (long)arr[2] + (long)arr[3] + (long)arr[4];
        Console.WriteLine(minSum + " " + maxSum);
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}


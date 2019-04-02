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

    // Complete the arrayManipulation function below.
      static long arrayManipulation(int n, int[][] queries, int m)
    {
 long[] matrix = new long[n+1]; // getting index error
        for (int i = 0; i < m; i++)
        {
            int[] entity = queries[i];
            int firstIndex = entity[0];
            int secondIndex = entity[1];
            int val = entity[2];
            matrix[firstIndex] += val;
            if ((secondIndex + 1) <= n) matrix[secondIndex + 1] -= val;

        }

        long tempMax = 0;
        long max = 0;
        for (int i = 1; i <= n; i++)
        {
            tempMax += matrix[i];
            if (tempMax > max) max = tempMax;
        }       
        
        return max;
      

      

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++) {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries,m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}


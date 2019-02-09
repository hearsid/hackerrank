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

        static int birthdayCakeCandles(int[] ar)
    {
        Array.Sort(ar);
        int greatestNumber = ar[ar.Length - 1];
        int totalCandles = 0;
        for (int i = 0; i <= ar.Length -1 ; i++)
        {
            int entity = ar[ar.Length -i-1 ];
            if (entity == greatestNumber)
                totalCandles += 1;
            else
                break;
        }
        return totalCandles;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}


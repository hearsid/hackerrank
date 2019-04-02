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

  static long repeatedString(string s, long n)
    {
        long leftChars = (long)n % s.Length;
        string leftOutCharsString = s.Substring(0, (int)leftChars);
        long AInLeftout = leftOutCharsString.Where(a => a == 'a').Count();
        long noOfMainA = s.Where(a => a == 'a').Count();
        long totalA = noOfMainA * ((long)n / s.Length) + AInLeftout;
        return totalA;
    }

  

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}


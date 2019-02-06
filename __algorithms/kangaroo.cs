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

     static string kangaroo(int x1, int v1, int x2, int v2)
    {
        // number of steps are same
        // take atleast one step
        // after every step check if their position is same
        // when to stop matching (NO) ? if the position and vel of one is greater than lower one
        int p1 = x1 + v1;
        int p2 = x2 + v2;
        Boolean keepMatching = true;
        String result = "";
        int iters = 0;
        while (keepMatching)
        {
            iters+=1;
            if (p1 == p2)
            {
                keepMatching = false;
                result = "YES";
                break;
            }

            p1 += v1;
            p2 += v2;

            if ((p1 > p2 && v1 > v2) || (p2 > p1 && v2 > v1) || (iters > Math.Pow(10,3) && v1==v2))
            {
                keepMatching = false;
                result = "NO";
                break;
            }
        }
        return result;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = kangaroo(x1, v1, x2, v2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}


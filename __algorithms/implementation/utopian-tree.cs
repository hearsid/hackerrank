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

    // Complete the utopianTree function below.
    static int utopianTree(int n) {
        int initialHeight = 1;
        if (n == 0)
        {
            return initialHeight;
        }
        else
        {
            bool doubled = false;
            for (int i = 1; i <= n; i++)
            {
                if (!doubled)
                {
                    initialHeight = initialHeight * 2;
                    doubled = true;
                }
                else
                {
                    initialHeight = initialHeight + 1;
                    doubled = false;
                }
            }

            return initialHeight;
        }

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = utopianTree(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}


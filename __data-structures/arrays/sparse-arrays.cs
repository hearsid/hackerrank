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

        // Complete the matchingStrings function below.
    static int[] matchingStrings(string[] strings, string[] queries)
    {
               Dictionary<string, int> dicStrings = new Dictionary<string, int>();
        // have to make a lot of queries so convert string to map to reduce time complexity
        for(int i=0; i<strings.Length; i++)
        {
            string curString = strings[i];
            if(dicStrings.ContainsKey(curString))
            {
                dicStrings[curString] += 1;
            }
            else
            {
                dicStrings[curString] = 1;
            }

        }

        int querylen = queries.Length;
        int[] result = new int[querylen];
        for(int j=0; j<querylen; j++)
        {
            string str = queries[j];
            if (dicStrings.ContainsKey(str))
                result[j] = dicStrings[str];
            else
                result[j] = 0;
        }
        return result;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int stringsCount = Convert.ToInt32(Console.ReadLine());

        string[] strings = new string [stringsCount];

        for (int i = 0; i < stringsCount; i++) {
            string stringsItem = Console.ReadLine();
            strings[i] = stringsItem;
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine());

        string[] queries = new string [queriesCount];

        for (int i = 0; i < queriesCount; i++) {
            string queriesItem = Console.ReadLine();
            queries[i] = queriesItem;
        }

        int[] res = matchingStrings(strings, queries);

        textWriter.WriteLine(string.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}


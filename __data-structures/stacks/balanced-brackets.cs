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

      static string yes = "YES";
    static string no = "NO";
    // Complete the isBalanced function below.
    static string isBalanced(string s)
    {
        char[] brakets = s.ToCharArray();
        Stack<char> st = new Stack<char>();
          for(int i = 0; i<brakets.Length; i++)
        {
            char curBraket = brakets[i];
            if (st.Count() > 0 && isPair(st.Peek(), curBraket))
            {
                st.Pop();
            }
            else
            {
                st.Push(curBraket);
            }
        }

        if (st.Count() == 0)
            return yes;

        return no;
    }

    static Boolean isPair(char braket1, char braket2) 
    {
        if(braket1 == '(' && braket2 == ')')
        {
            return true;

        }
        if (braket1 == '[' && braket2 == ']')
            return true;

        if (braket1 == '{' && braket2 == '}')
            return true;

        return false;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string s = Console.ReadLine();

            string result = isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}


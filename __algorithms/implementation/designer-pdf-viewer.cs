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

    // Complete the designerPdfViewer function below.
    static int designerPdfViewer(int[] h, string word) {
       var wordArray = word.ToCharArray();
        char[] alphabet = Enumerable.Range(97, 26).Select(x => (char)x).ToArray(); // 97 is small a ascii and english lang has 26 alpas

        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int i = 0; i < h.Length; i++)
        {
            dict[alphabet[i]] = h[i];
        }

        var max = 0;

        for (int i = 0; i < wordArray.Length; i++)
        {
            if (dict.ContainsKey(word[i]))
            {
                int val = dict[wordArray[i]];
                if (val > max)
                    max = val;
            }
        }

        return (word.Length * max);

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
        ;
        string word = Console.ReadLine();

        int result = designerPdfViewer(h, word);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}


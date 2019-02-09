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

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores) {
        /*1. keep track of the highest and lowest score
          2. when highest score is less than last highest add to highestIncreased
          3. when the lowest score is less than last lowest add to lowestDescreased
          4. first score is highest and lowest
          */

        int highestScore = scores[0];
        int lowestScore = scores[0];
        int highestIncreasedCount = 0;
        int lowestDescreasedCount = 0;
        for(int i=0; i<scores.Length; i++) {
            int curScore = scores[i];
            if(curScore>highestScore) {
                highestIncreasedCount +=1;
                highestScore = curScore;
            } 
            if (curScore< lowestScore) {
                lowestDescreasedCount +=1;
                lowestScore = curScore;
            }
        }
        int[] result = new int[]{ highestIncreasedCount, lowestDescreasedCount};
        return result;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}


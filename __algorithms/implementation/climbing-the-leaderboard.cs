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

class Solution
{

       // Complete the climbingLeaderboard function below.
    static int[] climbingLeaderboard(int[] scores, int[] alice)
    {
        /*
         * 1. create a hashmap of the players based on score 
         * 2. key -> rank and value -> playername, for two players for one rank override with Alice
         * 3. can priority queue help? Person with more ranking goes to top of queue
         *  OR
         * 4. sort the scores and create a set of them 
         * 5. see the alice score position in that for rank
         */
        int[] aliceRanks = new int[alice.Length];
        int[] allScores = new int[scores.Length + 1];
        for (int i = 0; i < scores.Length; i++)
        {
            allScores[i] = scores[i]; // just clone
        }
        for (int i = 0; i < alice.Length; i++)
        {
            int curAliceScore = alice[i];
            allScores[scores.Length] = curAliceScore; // last new added element
            int[] sortedScoresArr = allScores.Distinct().ToArray();
            Array.Sort<int>(sortedScoresArr);
            aliceRanks[i] = sortedScoresArr.Length - Array.BinarySearch(sortedScoresArr, curAliceScore);
        }

        return aliceRanks;
    }
      


   

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int scoresCount = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int aliceCount = Convert.ToInt32(Console.ReadLine());

        int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        ;
        int[] result = climbingLeaderboard(scores, alice);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}


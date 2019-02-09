using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

      static int parseGrade(int grade)
    {
        int remainder = grade % 5;
        if (5 - remainder <  3)
        {
            return grade + 5 - remainder;
        }
        else
        {
            return grade;
        }
    }
    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades)
    {
        /*
         * Write your code here.
         */
        int[] roundedGrades = new int[grades.Length];
        for (int i = 0; i <= grades.Length - 1; i++)
        {
            var grade = grades[i];
           
                int roundedGrade = parseGrade(grade);
                if(grade < 40 && roundedGrade < 40) {
                    roundedGrades[i] = grade;
                } else {
                 roundedGrades[i] = roundedGrade;
                }
        }

        return roundedGrades;

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}


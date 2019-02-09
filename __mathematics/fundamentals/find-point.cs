using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

       static int[] findPoint(int px, int py, int qx, int qy)
    {
        int disX = qx - px;
        int disY = qy - py;
        int reflectionPointX = disX + qx;
        int reflectionPointY = disY + qy;
        int[] result = new int[2] { reflectionPointX, reflectionPointY };

        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        for (int nItr = 0; nItr < n; nItr++) {
            string[] pxPyQxQy = Console.ReadLine().Split(' ');

            int px = Convert.ToInt32(pxPyQxQy[0]);

            int py = Convert.ToInt32(pxPyQxQy[1]);

            int qx = Convert.ToInt32(pxPyQxQy[2]);

            int qy = Convert.ToInt32(pxPyQxQy[3]);

            int[] result = findPoint(px, py, qx, qy);

            textWriter.WriteLine(string.Join(" ", result));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}


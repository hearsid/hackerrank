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

     static int[] moveElement(int[] arr,int arrLen, int noOfShifts)
    {
        int[] newArr = new int[arrLen];
        // Left Rotation
        for (int i=0; i< arrLen; i++)
        {
            newArr[(i + (arrLen - noOfShifts)) % arrLen] = arr[i];
        }
        return newArr;
    }


    static void Main(string[] args) {
        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] newArr = new int[n];
        newArr = moveElement(a, n, d);
        Console.WriteLine(string.Join(" ", newArr));
    }
}


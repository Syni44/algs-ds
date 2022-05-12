// https://www.hackerrank.com/challenges/minimum-swaps-2/problem?h_r=profile
// 06-10-2021

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

    static int minimumSwaps(int[] arr) {        
        // init
        int[] orderedArray = Enumerable.Range(arr.Min(), arr.Max()).ToArray();
        int swaps = 0;
        int iterator = 0;
        
        while (iterator < arr.Length - 1) {
            int num = arr[iterator];
            if (iterator + 1 == num) {
                iterator++;
                continue;
            }
            
            int temp = arr[iterator];            
            arr[iterator] = arr[num - 1];
            arr[num - 1] = temp;
            swaps++;
        }
        
        return swaps;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}

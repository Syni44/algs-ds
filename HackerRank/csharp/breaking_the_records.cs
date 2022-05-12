// https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem?h_r=profile
// 08-13-2018

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
        int[] result = new int[2] { 0, 0 };
        int highest = scores[0], lowest = scores[0];
        
        for (int i = 1; i < scores.Length; i++) {
            if (scores[i] > highest) {
                result[0]++;
                highest = scores[i];
            }
            else if (scores[i] < lowest) {
                result[1]++;
                lowest = scores[i];
            }
        }
        
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

// https://www.hackerrank.com/challenges/the-hurdle-race/problem?h_r=profile
// 08-28-2019

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

    // Complete the hurdleRace function below.
    static int hurdleRace(int k, int[] height) {
        if (k >= height.Max()) {
            return 0;
        }

        return height.Max() - k;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
        ;
        int result = hurdleRace(k, height);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

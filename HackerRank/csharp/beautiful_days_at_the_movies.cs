// https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem?h_r=profile
// 03-02-2020

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

    // Complete the beautifulDays function below.
    static int beautifulDays(int i, int j, int k) {
        int beautifulOnes = 0;

        for (int x = i; x <= j; x++) {
            if (Math.Abs(x - ReversedNum(x)) % k == 0) {
                beautifulOnes++;
            }
        }

        return beautifulOnes;
    }

    static int ReversedNum(int num) {
        int reversed = 0, lastdigit = 0;

        while (num != 0) {
            lastdigit = num % 10;
            reversed = (reversed * 10) + lastdigit;
            num /= 10;
        }

        return reversed;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] ijk = Console.ReadLine().Split(' ');

        int i = Convert.ToInt32(ijk[0]);

        int j = Convert.ToInt32(ijk[1]);

        int k = Convert.ToInt32(ijk[2]);

        int result = beautifulDays(i, j, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

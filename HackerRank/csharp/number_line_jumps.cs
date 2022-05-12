// https://www.hackerrank.com/challenges/kangaroo/problem?h_r=profile
// 08-12-2018

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

    // Complete the kangaroo function below.
    static string kangaroo(int x1, int v1, int x2, int v2) {
        if (v1 <= v2) return "NO";
        
        if ((x1 - x2) % (v2 - v1) == 0) return "YES";
        else return "NO";
        
        /*if (x1 == x2) return "YES";
        if (v1 <= v2) return "NO";
        
        while (true) {
            x1 += v1;
            x2 += v2;
            
            if (x1 == x2) return "YES";
            if (x1 > x2) return "NO";
        }*/
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = kangaroo(x1, v1, x2, v2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

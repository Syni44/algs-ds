// https://www.hackerrank.com/challenges/sock-merchant/problem?h_r=profile
// 08-27-2019

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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        int pairs = 0;
        List<int> colors = ar.Distinct().ToList();

        // iterate through each different sock color
        for (int i = 0; i < colors.Count(); i++) {
            int count = 0;

            // check every sock and count the ones of the current color
            foreach (int sock in ar) {
                if (sock == colors.ElementAt(i)) {
                    count++;

                    // for every two socks of the same color found, increment pairs by one
                    if (count % 2 == 0) {
                        pairs++;
                    }
                }
            }
        }

        return pairs;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

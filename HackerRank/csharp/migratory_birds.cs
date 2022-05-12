// https://www.hackerrank.com/challenges/migratory-birds/problem?h_r=profile
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

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr) {
        int highestCount = 0;
        int type = 0;

        // start by checking for each type of bird
        // decrement from type 5 to 1, letting lower numbers have priority logically
        for (int i = 5; i > 0; i--) {
            int count = 0;

            // look at all birds total and count how many are of the current type
            foreach (int bird in arr) {
                if (bird == i) {
                    count++;
                }
            }

            // check if the number of birds counted is the highest so far
            // because lower type no.s are last, they will override higher ones
            if (count >= highestCount) {
                highestCount = count;
                type = i;
            }
        }

        return type;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

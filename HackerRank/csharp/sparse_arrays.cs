// https://www.hackerrank.com/challenges/sparse-arrays/problem?h_r=profile
// 08-11-2018

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
    // Complete the matchingStrings function below.
    static int[] matchingStrings(string[] strings, string[] queries) {
        int[] result = Enumerable.Repeat(0, queries.Length).ToArray();
        List<int> indexes = new List<int>();
        
        for (int i = 0; i < strings.Length; i++) {
            // be wary of duplicates within the queries array! they *all* should be
            // incremented when a query is found in strings[]
            indexes = queries.Select((value, index) => new { value, index })
                .Where(x => x.value == strings[i])
                .Select(x => x.index)
                .ToList();
            
            for (int j = 0; j < indexes.Count(); j++) {                
                result[indexes[j]]++;
            }
        }
        
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int stringsCount = Convert.ToInt32(Console.ReadLine());

        string[] strings = new string [stringsCount];

        for (int i = 0; i < stringsCount; i++) {
            string stringsItem = Console.ReadLine();
            strings[i] = stringsItem;
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine());

        string[] queries = new string [queriesCount];

        for (int i = 0; i < queriesCount; i++) {
            string queriesItem = Console.ReadLine();
            queries[i] = queriesItem;
        }

        int[] res = matchingStrings(strings, queries);

        textWriter.WriteLine(string.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}

// 08-08-2018

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

    // Complete the dynamicArray function below.
    static List<int> dynamicArray(int n, List<List<int>> queries) {
        List<int> result = new List<int>();
        List<List<int>> seq = new List<List<int>>();
        
        for (int i = 0; i < n; i++) {
            seq.Add(new List<int>());
        }
        
        int lastAnswer = 0;
        
        for (int i = 0; i < queries.Count; i++) {
            List<int> q = queries.ElementAt(i);
            List<int> s = seq.ElementAt((q.ElementAt(1) ^ lastAnswer) % n);
            
            if (q.ElementAt(0) == 1) {
                s.Add(q.Last());
            }
            else {
                lastAnswer = (s.ElementAt(q.Last() % s.Count));
                result.Add(lastAnswer);
            }
        }
        
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nq = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nq[0]);

        int q = Convert.ToInt32(nq[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++) {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> result = dynamicArray(n, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

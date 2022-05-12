// https://www.hackerrank.com/challenges/array-left-rotation/problem?h_r=profile
// 08-09-2018

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
    static int[] ShiftedArray(int n, int d, int[] a) {
        int[] result = new int[n];
        
        for (int i = 0; i < a.Length; i++) {
            result[i] = a[(i + d) % n];
        }
        
        return result;
    }


    static void Main(string[] args) {
        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        
        int[] shiftedArray = ShiftedArray(n, d, a);
        for (int i = 0; i < shiftedArray.Length; i++) {
            Console.Write(shiftedArray[i] + " ");
        }
    }
}

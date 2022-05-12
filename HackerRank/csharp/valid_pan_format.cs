// 08-07-2018

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Solution {
    static void Main(String[] args) {
        int lines = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < lines; i++) {
            string pan = Console.ReadLine();
            if (Regex.IsMatch(pan, @"^[A-Z]{5}\d{4}[A-Z]$")) Console.WriteLine("YES");
            else                                       Console.WriteLine("NO");
        }
    }
}
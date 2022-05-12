// 08-07-2018

using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int lines = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < lines; i++) {
            string input = Console.ReadLine();
            
            if (input.StartsWith("hackerrank") && input.EndsWith("hackerrank")) {
                Console.WriteLine("0");
            }
            else if (input.StartsWith("hackerrank")) {
                Console.WriteLine("1");
            }
            else if (input.EndsWith("hackerrank")) {
                Console.WriteLine("2");
            }
            else Console.WriteLine("-1");
        }
    }
}
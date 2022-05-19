// https://leetcode.com/problems/add-binary/
// 05/18/2022

public class Solution {
    public string AddBinary(string a, string b) {
        string longest = (a.Length > b.Length) ? a : b;
        string shortest = (a.Length <= b.Length) ? a : b;

        if (longest.Length != shortest.Length)
        {
            int dif = longest.Length - shortest.Length;

            for (int i = 0; i < dif; i++)
            {
                shortest = "0" + shortest;
            }
        }

        string result = "";
        int carry = 0;

        for (int i = longest.Length - 1; i >= 0; i--)
        {
            int sum = Convert.ToInt32(longest[i] - '0') + Convert.ToInt32(shortest[i] - '0');

            if (sum + carry == 0) 
            {
                result = "0" + result;
                carry = 0;
            }
            else if (sum + carry == 1) 
            {
                result = "1" + result;
                carry = 0;
            }
            else if (sum + carry == 2)
            {
                result = "0" + result;
                carry = 1;
            }
            else
            {
                result = "1" + result;
                carry = 1;
            }            
        }

        if (carry == 1) result = "1" + result;

        return result;
    }
}
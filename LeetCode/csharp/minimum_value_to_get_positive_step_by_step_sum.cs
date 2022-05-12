// https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/
// Nov 2021

public class Solution {
    public int MinStartValue(int[] nums) {
        int tempSum = 1;
        List<int> sumList = new List<int>();
      
        for (int i = 0; i < nums.Count(); i++) {
            tempSum += nums[i];
            sumList.Add(tempSum);
        }
      
        if (sumList.Min() > 0) return 1;
        return ((1 - sumList.Min()) + 1);
    }
}
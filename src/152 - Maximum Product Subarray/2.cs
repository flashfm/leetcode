// Copyright (c) 2020 Alexey Filatov
// 152 - Maximum Product Subarray (https://leetcode.com/problems/maximum-product-subarray)
// Date solved: 10/16/2020 8:33:13 AM +00:00
// Memory: 25.2 MB
// Runtime: 92 ms


// 0 = stop
// <0 - still remember in case we meet <0 again
// >0 - multiply and stop at -1

// dp[I]
// max positive mul ending on I
// max negative mul ending on I
public class Solution {
    public int MaxProduct(int[] nums) {
        var n = nums.Length;
        if (n==0) {
            return 0;
        }
        int result = nums[0];
        int max = result;
        int min = result;
        for(int i = 1; i<n; i++) {
            var num = nums[i];
            if (num<0) {
                var tmp = max;
                max = min;
                min = tmp;
            }
            max = Math.Max(num, max * num);
            min = Math.Min(num, min * num);            
            result = Math.Max(max, result);
        }
        return result;
    }
}

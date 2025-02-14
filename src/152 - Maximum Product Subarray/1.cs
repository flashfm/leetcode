// Copyright (c) 2020 Alexey Filatov
// 152 - Maximum Product Subarray (https://leetcode.com/problems/maximum-product-subarray)
// Date solved: 10/16/2020 8:28:30 AM +00:00
// Memory: 25.4 MB
// Runtime: 88 ms


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
        int? pos = null;
        int? neg = null;
        int i = 0;
        while(i<n) {
            while(i<n && nums[i]==0) {
                pos = neg = null;
                if (result<0) {
                    result = 0;
                }
                i++;
            }
            if (i==n) {
                break;
            }
            var num = nums[i];
            if (num<0) {
                var newPos = neg==null ? null : neg * num;
                var newNeg = pos==null ? num : pos * num;
                pos = newPos;
                neg = newNeg;
            }
            else {
                pos = pos==null ? num : pos * num;
                neg = neg==null ? null : neg * num;
            }
            if (pos!=null) {
                result = Math.Max(pos.Value, result);
            }
            //Console.WriteLine($"{i}: {pos}, {neg}");
            i++;
        }
        return result;
    }
}

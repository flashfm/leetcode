// Copyright (c) 2020 Alexey Filatov
// 198 - House Robber (https://leetcode.com/problems/house-robber)
// Date solved: 3/18/2020 5:21:13 AM +00:00
// Memory: 23.9 MB
// Runtime: 92 ms


public class Solution {
    public int Rob(int[] nums) {
        var n = nums.Length;
        if (n==0) return 0;
        var withLast = nums[0];
        var withoutLast = 0;
        for(var i=1;i<n;i++) {
            var prevWithLast = withLast;
            withLast = nums[i] + withoutLast;
            withoutLast = Math.Max(withoutLast, prevWithLast);
        }
        return Math.Max(withLast, withoutLast);
    }
}

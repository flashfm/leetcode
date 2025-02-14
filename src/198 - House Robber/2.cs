// Copyright (c) 2020 Alexey Filatov
// 198 - House Robber (https://leetcode.com/problems/house-robber)
// Date solved: 3/18/2020 5:24:49 AM +00:00
// Memory: 24 MB
// Runtime: 96 ms


public class Solution {
    public int Rob(int[] nums) {
        var n = nums.Length;
        if (n==0) return 0;
        var withLast = 0;
        var withoutLast = 0;
        foreach(var num in nums) {
            var prevWithLast = withLast;
            withLast = num + withoutLast;
            withoutLast = Math.Max(withoutLast, prevWithLast);
        }
        return Math.Max(withLast, withoutLast);
    }
}

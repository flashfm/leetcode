// Copyright (c) 2024 Alexey Filatov
// 334 - Increasing Triplet Subsequence (https://leetcode.com/problems/increasing-triplet-subsequence)
// Date solved: 11/9/2024 10:30:47 PM +00:00
// Memory: 86.3 MB
// Runtime: 1 ms


public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        var min1 = int.MaxValue;
        var min2 = int.MaxValue;
        foreach(var n in nums) {
            if (n>min2) {
                return true;
            }
            if (n<=min1) {
                min1 = n;
            }
            else {
                min2 = Math.Min(min2, n);
            }
        }
        return false;
    }
}

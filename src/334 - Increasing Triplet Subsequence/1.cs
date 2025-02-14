// Copyright (c) 2020 Alexey Filatov
// 334 - Increasing Triplet Subsequence (https://leetcode.com/problems/increasing-triplet-subsequence)
// Date solved: 1/29/2020 7:44:16 AM +00:00
// Memory: 24.8 MB
// Runtime: 108 ms


public class Solution {
    public bool IncreasingTriplet(int[] nums)
    {
        var min = int.MaxValue;
        var secondMin = int.MaxValue;
        foreach(var n in nums) {
            if (n<=min) {
                min = n;
            }
            else if (n<secondMin) {
                secondMin = n;
            }
            else if (n>secondMin) { return true; }
        }
        return false;
    }
}

// Copyright (c) 2020 Alexey Filatov
// 41 - First Missing Positive (https://leetcode.com/problems/first-missing-positive)
// Date solved: 11/13/2020 11:56:05 PM +00:00
// Memory: 25.1 MB
// Runtime: 96 ms


public class Solution {
    public int FirstMissingPositive(int[] nums) {
        var hash = new HashSet<int>(nums);
        var i=1;
        for(;i<=nums.Length;i++) {
            if (!hash.Contains(i)) {
                return i;
            }
        }
        return i;
    }
}

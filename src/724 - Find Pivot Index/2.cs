// Copyright (c) 2024 Alexey Filatov
// 724 - Find Pivot Index (https://leetcode.com/problems/find-pivot-index)
// Date solved: 11/10/2024 8:20:47 PM +00:00
// Memory: 48.5 MB
// Runtime: 7 ms


public class Solution {
    public int PivotIndex(int[] nums) {
        var total = nums.Sum();
        var sum = 0;
        for(var i = 0; i<nums.Length; i++) {
            var n = nums[i];
            var right = total-sum-n;
            if (sum==right) {
                return i;
            }
            sum += n;
        }
        return -1;
    }
}

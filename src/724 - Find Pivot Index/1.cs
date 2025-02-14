// Copyright (c) 2024 Alexey Filatov
// 724 - Find Pivot Index (https://leetcode.com/problems/find-pivot-index)
// Date solved: 11/10/2024 4:31:08 AM +00:00
// Memory: 48.3 MB
// Runtime: 5 ms


public class Solution {
    public int PivotIndex(int[] nums) {
        var total = nums.Sum();
        var sum = 0;
        for(var i = 0; i<nums.Length; i++) {
            var n = nums[i];
            if (sum==total-sum-n) {
                return i;
            }
            sum += n;
        }
        return -1;
    }
}

// Copyright (c) 2024 Alexey Filatov
// 932 - Monotonic Array (https://leetcode.com/problems/monotonic-array)
// Date solved: 12/17/2024 7:54:25 AM +00:00
// Memory: 69.4 MB
// Runtime: 2 ms


public class Solution {
    public bool IsMonotonic(int[] nums) {
        var n = nums.Length;
        var inc = true;
        var dec = true;
        for(var i=1; i<n; i++) {
            inc = inc && (nums[i]>=nums[i-1]);
            dec = dec && (nums[i]<=nums[i-1]);
        }
        return inc || dec;
    }
}

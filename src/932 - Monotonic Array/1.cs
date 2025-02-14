// Copyright (c) 2024 Alexey Filatov
// 932 - Monotonic Array (https://leetcode.com/problems/monotonic-array)
// Date solved: 12/17/2024 7:51:28 AM +00:00
// Memory: 69.6 MB
// Runtime: 1 ms


public class Solution {
    public bool IsMonotonic(int[] nums) {
        var n = nums.Length;
        var sign = 0;        
        for(var i=1; i<n; i++) {
            if (sign==0) {
                sign = nums[i]>nums[i-1] ? 1 : nums[i]<nums[i-1] ? -1 : 0;
            }
            else if (sign==1) {
                if (nums[i]<nums[i-1]) {
                    return false;
                }
            }
            else {
                if (nums[i]>nums[i-1]) {
                    return false;
                }
            }
        }
        return true;
    }
}

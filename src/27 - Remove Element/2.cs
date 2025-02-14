// Copyright (c) 2024 Alexey Filatov
// 27 - Remove Element (https://leetcode.com/problems/remove-element)
// Date solved: 7/31/2024 9:11:24 PM +00:00
// Memory: 45.9 MB
// Runtime: 113 ms


public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var j = 0;
        for(var i = 0; i<nums.Length; i++) {
            if (nums[i] != val) {
                nums[j++] = nums[i];
            }
        }
        return j;
    }
}

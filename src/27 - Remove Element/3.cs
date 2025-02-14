// Copyright (c) 2024 Alexey Filatov
// 27 - Remove Element (https://leetcode.com/problems/remove-element)
// Date solved: 7/31/2024 9:12:16 PM +00:00
// Memory: 46 MB
// Runtime: 112 ms


public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var j = 0;
        for(var i = 0; i<nums.Length; i++) {
            var x = nums[i];
            if (x != val) {
                nums[j++] = x;
            }
        }
        return j;
    }
}

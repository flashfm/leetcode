// Copyright (c) 2024 Alexey Filatov
// 27 - Remove Element (https://leetcode.com/problems/remove-element)
// Date solved: 7/31/2024 9:07:35 PM +00:00
// Memory: 45.7 MB
// Runtime: 100 ms


public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var len = nums.Length;
        var valCount = 0;
        var j = 0;
        var i = 0;
        while(i<len && j<len) {
            while(j<len && nums[j]==val) {
                j++;
                valCount++;
            }
            if (j<len) {
                nums[i++] = nums[j++];
            }
        }
        return len - valCount;
    }
}

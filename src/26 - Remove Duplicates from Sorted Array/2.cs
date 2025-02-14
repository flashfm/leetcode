// Copyright (c) 2024 Alexey Filatov
// 26 - Remove Duplicates from Sorted Array (https://leetcode.com/problems/remove-duplicates-from-sorted-array)
// Date solved: 10/30/2024 3:00:39 AM +00:00
// Memory: 50.1 MB
// Runtime: 0 ms


public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var n = nums.Length;
        var j = 1;
        var i = 1;
        while(i<n && j<n) {
            while(i<n && nums[i]==nums[i-1]) {
                i++;
            }
            if (i<n) {
                nums[j] = nums[i];
                i++;
                j++;
            }
        }
        return j;
    }
}

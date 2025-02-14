// Copyright (c) 2024 Alexey Filatov
// 80 - Remove Duplicates from Sorted Array II (https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii)
// Date solved: 7/31/2024 11:03:42 PM +00:00
// Memory: 47.3 MB
// Runtime: 104 ms


public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length==0) {
            return 0;
        }
        var x = 100000;
        var prev = nums[0];
        var counter = 1;
        for(var i = 1; i<nums.Length; i++) {
            if (nums[i]==prev) {
                counter++;
            }
            else {
                counter = 1;
            }
            prev = nums[i];
            if (counter>2) {
                nums[i] = x;
            }
        }
        var j = 0;
        for(var i = 0; i<nums.Length; i++) {
            if (nums[i]!=x) {
                nums[j++] = nums[i];
            }
        }
        return j;
    }
}

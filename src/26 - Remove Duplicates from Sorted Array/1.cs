// Copyright (c) 2020 Alexey Filatov
// 26 - Remove Duplicates from Sorted Array (https://leetcode.com/problems/remove-duplicates-from-sorted-array)
// Date solved: 2/18/2020 6:07:35 AM +00:00
// Memory: 33.4 MB
// Runtime: 256 ms


public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length==0) return 0;
        var j = 1;
        for(var i=1;i<nums.Length;i++) {
            if (nums[i]!=nums[j-1]) {
                nums[j] = nums[i];
                j++;
            }
        }
        return j;
    }
}

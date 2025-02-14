// Copyright (c) 2020 Alexey Filatov
// 283 - Move Zeroes (https://leetcode.com/problems/move-zeroes)
// Date solved: 4/9/2020 5:59:56 AM +00:00
// Memory: 31.7 MB
// Runtime: 248 ms


public class Solution {
    public void MoveZeroes(int[] nums) {
        var pos = 0;
        int right = 0;
        
        while(pos<nums.Length && right<nums.Length) {
            while(pos<nums.Length && nums[pos]!=0) pos++;
            right = pos+1;
            while(right<nums.Length && nums[right]==0) right++;
            
            if (right<nums.Length)
                swap(nums, pos, right);
        }
    }
    private void swap(int[] nums, int a, int b)
    {
        var t = nums[a];
        nums[a] = nums[b];
        nums[b] = t;
    }
}

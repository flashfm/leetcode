// Copyright (c) 2019 Alexey Filatov
// 55 - Jump Game (https://leetcode.com/problems/jump-game)
// Date solved: 12/24/2019 8:13:23 AM +00:00
// Memory: 25.5 MB
// Runtime: 96 ms


public class Solution {
   public bool CanJump(int[] nums) {
        var prevMax = nums[0];
        for(var i=1;i<nums.Length;i++) {
            if (i > prevMax) return false;
            prevMax = Math.Max(prevMax, nums[i]+i);
        }        
        return true;
    }
}

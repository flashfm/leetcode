// Copyright (c) 2019 Alexey Filatov
// 55 - Jump Game (https://leetcode.com/problems/jump-game)
// Date solved: 12/24/2019 8:12:51 AM +00:00
// Memory: 25.4 MB
// Runtime: 100 ms


public class Solution {
   public bool CanJump(int[] nums) {
        var n = nums.Length;
        var prevMax = nums[0];
        for(var i=1;i<n;i++) {
            if (i > prevMax) {
                return false;
            }
            prevMax = Math.Max(prevMax, nums[i]+i);
        }        
        return true;
    }
}

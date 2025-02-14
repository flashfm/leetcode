// Copyright (c) 2019 Alexey Filatov
// 55 - Jump Game (https://leetcode.com/problems/jump-game)
// Date solved: 12/24/2019 8:11:16 AM +00:00
// Memory: 25.7 MB
// Runtime: 100 ms


public class Solution {
   public bool CanJump(int[] nums) {
        var n = nums.Length;
        var prevMax = nums[0];
        for(var to=1;to<n;to++) {
            if (to > prevMax) {
                return false;
            }
            prevMax = Math.Max(prevMax, nums[to]+to);
        }        
        return true;
    }
}

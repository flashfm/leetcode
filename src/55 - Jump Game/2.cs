// Copyright (c) 2019 Alexey Filatov
// 55 - Jump Game (https://leetcode.com/problems/jump-game)
// Date solved: 12/24/2019 8:09:39 AM +00:00
// Memory: 25.5 MB
// Runtime: 100 ms


public class Solution {
   public bool CanJump(int[] nums) {
        var n = nums.Length;
       
        var hasPrev = new bool[n];
       
        var prevMax = 0;
        
        for(var to=0;to<n;to++) {
            
            var ok = to <= prevMax;
            
            prevMax = Math.Max(prevMax, nums[to]+to);
            
            if (to!=0 && !ok) return false;
        }        
        
        return true;
    }
}

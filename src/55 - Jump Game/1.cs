// Copyright (c) 2019 Alexey Filatov
// 55 - Jump Game (https://leetcode.com/problems/jump-game)
// Date solved: 12/24/2019 7:57:13 AM +00:00
// Memory: 25.7 MB
// Runtime: 804 ms


public class Solution {
   public bool CanJump(int[] nums) {
        var n = nums.Length;
        var result = new bool[n];
        for(var to=0;to<n;to++) {
            for(var from=0;from<to;from++) {
                var ok = (to-from) <= nums[from];
                if (ok) {
                    result[to] = true;
                    break;
                }
            }
            if (to!=0 && !result[to]) return false;
        }        
        
        return true;
    }
}

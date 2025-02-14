// Copyright (c) 2024 Alexey Filatov
// 45 - Jump Game II (https://leetcode.com/problems/jump-game-ii)
// Date solved: 11/5/2024 9:11:40 PM +00:00
// Memory: 44.7 MB
// Runtime: 0 ms


public class Solution {
    public int Jump(int[] nums)
    {        
        var curEnd = 0;
        var curFarthest = 0;
        var result = 0;
        for(var i = 0; i<nums.Length-1; i++) {
            curFarthest = Math.Max(curFarthest, i + nums[i]);
            if (i==curEnd) {
                result++;
                curEnd = curFarthest;
            }
        }
        return result;
    }
}

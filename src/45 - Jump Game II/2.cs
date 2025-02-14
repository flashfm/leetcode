// Copyright (c) 2024 Alexey Filatov
// 45 - Jump Game II (https://leetcode.com/problems/jump-game-ii)
// Date solved: 8/22/2024 2:30:19 AM +00:00
// Memory: 44.5 MB
// Runtime: 128 ms


public class Solution {
    private int[] nums;
    public int Jump(int[] nums)
    {
        this.nums = nums;
        var i = nums.Length-1;
        var result = 0;
        while(i>0) {
            i = GetFarthestPossibleIndexFrom(i);
            result++;
        }
        return result;
    }

    private int GetFarthestPossibleIndexFrom(int cur) {
        for(var i = 0; i<cur; i++) {
            var dist = cur - i;
            if (nums[i] >= dist) {
                return i;
            }
        }
        return -1;
    }
}

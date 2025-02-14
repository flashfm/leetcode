// Copyright (c) 2024 Alexey Filatov
// 45 - Jump Game II (https://leetcode.com/problems/jump-game-ii)
// Date solved: 11/5/2024 9:07:59 PM +00:00
// Memory: 44.7 MB
// Runtime: 10 ms


public class Solution {
    public int Jump(int[] nums)
    {
        var pos = nums.Length-1;
        var result = 0;
        while(pos>0) {
            var newPos = 0;
            while(newPos<pos && nums[newPos] < pos - newPos) {
                newPos++;
            }
            if (newPos==pos) {
                break;
            }
            pos = newPos;
            result++;
        }
        return result;
    }
}

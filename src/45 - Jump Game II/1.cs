// Copyright (c) 2024 Alexey Filatov
// 45 - Jump Game II (https://leetcode.com/problems/jump-game-ii)
// Date solved: 8/22/2024 2:18:32 AM +00:00
// Memory: 46.1 MB
// Runtime: 522 ms


public class Solution {
    private int[] cache;
    private int[] nums;
    public int Jump(int[] nums)
    {
        this.nums = nums;
        cache = new int[nums.Length];
        return GetHopsIfAt(0);
    }
    private int GetHopsIfAt(int cur)
    {
        if (cur>=nums.Length-1) {
            return 0;
        }
        if (cache[cur]==0) {
            var minHops = int.MaxValue-1;
            var maxLen = nums[cur];
            for(var i = 1; i<=maxLen; i++) {
                var hops = GetHopsIfAt(cur + i);
                if (hops<minHops) {
                    minHops = hops;
                }
            }
            cache[cur] = minHops + 1;
        }
        return cache[cur];
    }
}

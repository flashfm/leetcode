// Copyright (c) 2020 Alexey Filatov
// 1 - Two Sum (https://leetcode.com/problems/two-sum)
// Date solved: 6/15/2020 5:12:40 PM +00:00
// Memory: 31.3 MB
// Runtime: 252 ms


public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var posByNum = new Dictionary<int, int>();
        for(var i = 0; i<nums.Length; i++) {
            posByNum[nums[i]] = i;
        }
        for(var i = 0; i<nums.Length; i++) {
            var x = target - nums[i];
            if (posByNum.TryGetValue(x, out var j) && j>i) {
                return new[] {i,j};
            }
        }
        return new int[0];
    }
}

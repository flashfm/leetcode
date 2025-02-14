// Copyright (c) 2024 Alexey Filatov
// 1798 - Max Number of K-Sum Pairs (https://leetcode.com/problems/max-number-of-k-sum-pairs)
// Date solved: 11/10/2024 3:00:20 AM +00:00
// Memory: 67.9 MB
// Runtime: 276 ms


public class Solution {
    public int MaxOperations(int[] nums, int k) {
        var result = 0;
        var countByNum = new Dictionary<int, int>();
        foreach(var num in nums) {
            countByNum[num] = countByNum.GetValueOrDefault(num) + 1;
        }
        foreach(var num in nums) {
            var pair = k-num;
            var min = 0;
            if (pair==num) {
                min = 1;
            }
            if (countByNum.TryGetValue(num, out var c1) && c1>min && countByNum.TryGetValue(pair, out var count) && count>min) {
                result++;
                countByNum[pair]--;
                countByNum[num]--;
            }
        }
        return result;
    }
}

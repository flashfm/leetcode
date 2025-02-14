// Copyright (c) 2024 Alexey Filatov
// 1798 - Max Number of K-Sum Pairs (https://leetcode.com/problems/max-number-of-k-sum-pairs)
// Date solved: 11/10/2024 3:07:23 AM +00:00
// Memory: 67.6 MB
// Runtime: 271 ms


public class Solution {
    public int MaxOperations(int[] nums, int k) {
        var result = 0;
        var countByNum = new Dictionary<int, int>();
        foreach(var num in nums) {
            countByNum[num] = countByNum.GetValueOrDefault(num) + 1;
        }
        foreach(var num in countByNum.Keys) {
            result += Math.Min(countByNum[num], countByNum.GetValueOrDefault(k-num));
        }
        return result/2;
    }
}

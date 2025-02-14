// Copyright (c) 2024 Alexey Filatov
// 1330 - Longest Arithmetic Subsequence of Given Difference (https://leetcode.com/problems/longest-arithmetic-subsequence-of-given-difference)
// Date solved: 12/26/2024 11:41:27 PM +00:00
// Memory: 68.4 MB
// Runtime: 59 ms


public class Solution {
    public int LongestSubsequence(int[] arr, int difference) {
        var lenByNum = new Dictionary<int, int>();
        var result = 0;
        foreach(var a in arr) {
            result = Math.Max(result, lenByNum[a] = lenByNum.GetValueOrDefault(a-difference) + 1);
        }
        return result;
    }
}

// Copyright (c) 2024 Alexey Filatov
// 1330 - Longest Arithmetic Subsequence of Given Difference (https://leetcode.com/problems/longest-arithmetic-subsequence-of-given-difference)
// Date solved: 12/26/2024 11:40:10 PM +00:00
// Memory: 68.3 MB
// Runtime: 57 ms


public class Solution {
    public int LongestSubsequence(int[] arr, int difference) {
        var lenByNum = new Dictionary<int, int>();
        var result = 0;
        foreach(var a in arr) {
            var val = lenByNum[a] = lenByNum.GetValueOrDefault(a-difference) + 1;
            result = Math.Max(result, val);
        }
        //Console.WriteLine(string.Join(",", lenByNum.Select(p => (p.Key, p.Value))));
        return result;
    }
}

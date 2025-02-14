// Copyright (c) 2022 Alexey Filatov
// 395 - Longest Substring with At Least K Repeating Characters (https://leetcode.com/problems/longest-substring-with-at-least-k-repeating-characters)
// Date solved: 11/6/2022 4:15:24 AM +00:00
// Memory: 34.7 MB
// Runtime: 108 ms


public class Solution {
    public int LongestSubstring(string s, int k) {
        // Example: aaabbcaaabb, k = 4
        // Find "stop-chars" - those which count is not enough.
        // If we don't have them - then it's good range, exit.
        // On ranges between stop-chars, run the same algorithm.
        return Math.Max(0, CheckRange(s, k, 0, s.Length-1));
    }

    private int CheckRange(string s, int k, int start, int end)
    {
        if (end-start < k-1) {
            return int.MinValue;
        }
        var countByChar = new int[26];
        for(var i = start; i<=end; i++) {
            countByChar[s[i]-'a']++;
        }
        if (countByChar.All(p => p==0 || p >= k)) {
            return end - start + 1;
        }
        var newStart = start;
        var max = int.MinValue;
        for(var i = start; i<=end; i++) {
            var c = countByChar[s[i]-'a'];
            if (c > 0 && c < k) {
                max = Math.Max(max, CheckRange(s, k, newStart, i-1));
                newStart = i+1;
            }
        }
        return Math.Max(max, CheckRange(s, k, newStart, end));
    }
}

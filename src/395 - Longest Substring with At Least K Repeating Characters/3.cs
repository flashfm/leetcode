// Copyright (c) 2022 Alexey Filatov
// 395 - Longest Substring with At Least K Repeating Characters (https://leetcode.com/problems/longest-substring-with-at-least-k-repeating-characters)
// Date solved: 11/10/2022 6:17:31 AM +00:00
// Memory: 35.1 MB
// Runtime: 130 ms


public class Solution {
    public int LongestSubstring(string s, int k) {
        var maxUnique = s.ToHashSet().Count();
        var result = 0;
        for(var i = 1; i<=maxUnique; i++) {
            result = Math.Max(result, LongestSubstring(s, k, i));
        }
        return result;
    }

    private int LongestSubstring(string s, int k, int curUnique)
    {
        var left = 0;
        var right = 0;
        var countByChar = new int[26];
        var numUnique = 0;
        var result = 0;
        var numberOfCharsHavingK = 0;
        while(right < s.Length) {
            if (numUnique <= curUnique) {
                var c = s[right]-'a';
                if (countByChar[c]==0) numUnique++;
                countByChar[c]++;
                if (countByChar[c]==k) numberOfCharsHavingK++;
                right++;
            }
            else {
                var c = s[left]-'a';
                if (countByChar[c]==k) numberOfCharsHavingK--;
                countByChar[c]--;
                if (countByChar[c]==0) numUnique--;
                left++;
            }
            if (numberOfCharsHavingK==numUnique && numUnique==curUnique) {
                result = Math.Max(result, right-left);
            }
        }
        return result;
    }
}

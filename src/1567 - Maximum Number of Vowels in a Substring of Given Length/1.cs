// Copyright (c) 2024 Alexey Filatov
// 1567 - Maximum Number of Vowels in a Substring of Given Length (https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length)
// Date solved: 11/10/2024 3:15:57 AM +00:00
// Memory: 44.4 MB
// Runtime: 11 ms


public class Solution {
    string vowels = "aeiou";
    public int MaxVowels(string s, int k) {
        var count = 0;
        for(var i = 0; i<k; i++) {
            if (vowels.Contains(s[i])) {
                count++;
            }
        }
        var max = count;
        for(var i = k; i<s.Length; i++) {
            if (vowels.Contains(s[i])) {
                count++;
            }
            if (vowels.Contains(s[i-k])) {
                count--;
            }
            max = Math.Max(max, count);
        }
        return max;
    }
}

// Copyright (c) 2024 Alexey Filatov
// 1567 - Maximum Number of Vowels in a Substring of Given Length (https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length)
// Date solved: 11/10/2024 3:17:17 AM +00:00
// Memory: 43.3 MB
// Runtime: 6 ms


public class Solution {
    public int MaxVowels(string s, int k) {
        var count = 0;
        for(var i = 0; i<k; i++) {
            if (IsVowel(s[i])) {
                count++;
            }
        }
        var max = count;
        for(var i = k; i<s.Length; i++) {
            if (IsVowel(s[i])) {
                count++;
            }
            if (IsVowel(s[i-k])) {
                count--;
            }
            max = Math.Max(max, count);
        }
        return max;
        bool IsVowel(char c) => c=='a' || c=='e' || c=='i' || c=='o' || c=='u';
    }
}

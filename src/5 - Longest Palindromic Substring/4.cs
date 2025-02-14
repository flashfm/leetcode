// Copyright (c) 2024 Alexey Filatov
// 5 - Longest Palindromic Substring (https://leetcode.com/problems/longest-palindromic-substring)
// Date solved: 11/4/2024 3:35:15 AM +00:00
// Memory: 41.3 MB
// Runtime: 6 ms


public class Solution {
    public string LongestPalindrome(string s) {
        // manacher algo
        var orig = s;
        s = "#" + string.Join('#', s.AsEnumerable<char>()) + "#";
        //Console.WriteLine(s);
        var rad = new int[s.Length];
        var center = 0;
        var right = 0;
        var maxRad = 0;
        var maxCenter = 0;
        for(var i = 0; i<s.Length; i++) {
            var mirror = center - (i - center);
            // initialize
            var newRad = 0;
            if (i<right) {
                newRad = Math.Min(right-i, rad[mirror]); // either distance to right border or mirror radius
            }
            // expand
            while(i+newRad+1 < s.Length && i-newRad-1>=0 && s[i+newRad+1] == s[i-newRad-1]) {
                newRad++;
            }
            // update
            if (i+newRad > right) {
                right = i+newRad;
                center = i;
            }
            if (newRad>maxRad) {
                maxRad = newRad;
                maxCenter = i;
            }
            rad[i] = newRad;
        }
        var start = (maxCenter - maxRad) / 2;
        var result = orig.Substring(start, maxRad);
        return result;
    }
}

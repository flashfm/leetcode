// Copyright (c) 2024 Alexey Filatov
// 345 - Reverse Vowels of a String (https://leetcode.com/problems/reverse-vowels-of-a-string)
// Date solved: 11/8/2024 10:10:59 PM +00:00
// Memory: 44.1 MB
// Runtime: 3 ms


public class Solution {
    public string ReverseVowels(string s) {
        var chars = s.ToArray();
        var l = 0;
        var r = s.Length-1;
        while(l<r) {
            while(l<r && !IsVowel(chars[l])) { l++; }
            while(l<r && !IsVowel(chars[r])) { r--; }
            // swap
            (chars[l], chars[r]) = (chars[r], chars[l]);
            l++;
            r--;
        }
        return new string(chars);
    }
    private bool IsVowel(char l)
        =>
            l=='a' || l=='e' || l=='i' || l=='o' || l=='u' ||
            l=='A' || l=='E' || l=='I' || l=='O' || l=='U';
}

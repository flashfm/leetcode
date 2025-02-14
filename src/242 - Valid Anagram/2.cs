// Copyright (c) 2020 Alexey Filatov
// 242 - Valid Anagram (https://leetcode.com/problems/valid-anagram)
// Date solved: 3/17/2020 7:11:09 AM +00:00
// Memory: 23.5 MB
// Runtime: 76 ms


public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s?.Length!=t?.Length) return false;
                
        var letters = new int[26];
        
        FillLetters(s, letters, 1);
        FillLetters(t, letters, -1);
        
        foreach(var v in letters) if (v!=0) return false;
        
        return true;
    }
    private void FillLetters(string s, int[] dict, int d)
    {
        foreach(var c in s) {
            dict[c - 'a'] += d;
        }
    }
}

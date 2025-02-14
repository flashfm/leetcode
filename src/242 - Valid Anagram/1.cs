// Copyright (c) 2020 Alexey Filatov
// 242 - Valid Anagram (https://leetcode.com/problems/valid-anagram)
// Date solved: 3/17/2020 7:09:28 AM +00:00
// Memory: 23.8 MB
// Runtime: 84 ms


public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s?.Length!=t?.Length) return false;
        
        var letters = new Dictionary<char, int>();
        
        FillLetters(s, letters, 1);
        FillLetters(t, letters, -1);
        
        foreach(var v in letters.Values) if (v!=0) return false;
        
        return true;
    }
    private void FillLetters(string s, Dictionary<char, int> dict, int d)
    {
        foreach(var c in s) {
            dict.TryGetValue(c, out var n);
            dict[c] = n+d;
        }
    }
}

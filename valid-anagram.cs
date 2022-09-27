// Valid Anagram
// https://leetcode.com/problems/valid-anagram
// Date solved: 03/17/2020 07:11:09 +00:00

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

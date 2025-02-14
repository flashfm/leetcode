// Copyright (c) 2020 Alexey Filatov
// 139 - Word Break (https://leetcode.com/problems/word-break)
// Date solved: 9/30/2020 5:34:46 AM +00:00
// Memory: 28.3 MB
// Runtime: 124 ms


public class Solution {
    private HashSet<string> dict;
    private string s;
    private bool?[] cache;
    
    public bool WordBreak(string s, IList<string> wordDict) {
        if (string.IsNullOrEmpty(s)) {
            return false;
        }
        if (wordDict==null || wordDict.Count==0) {
            return false;
        }
        this.s = s;
        this.dict = wordDict.ToHashSet();
        cache = new bool?[s.Length];
        return CanBreakFrom(0);
    }
    
    private bool CanBreakFrom(int start)
    {
        if (start>=s.Length) {
            return true;
        }
        if (cache[start]==true) {
            return true;
        }
        if (cache[start]==false) {
            return false;
        }
        var word = "";
        for(var i = start; i<s.Length; i++) {
            word += s[i];
            if (dict.Contains(word) && CanBreakFrom(i+1)) {
                cache[start] = true;
                return true;
            }
        }
        cache[start] = false;
        return false;
    }
}

// Copyright (c) 2020 Alexey Filatov
// 139 - Word Break (https://leetcode.com/problems/word-break)
// Date solved: 9/30/2020 5:45:36 AM +00:00
// Memory: 28.5 MB
// Runtime: 116 ms


public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        if (string.IsNullOrEmpty(s)) {
            return false;
        }
        if (wordDict==null || wordDict.Count==0) {
            return false;
        }
        var dict = wordDict.ToHashSet();
        
        var dp = new bool[s.Length+1]; // dp[i]==true if s(0,i) can be split
        dp[0] = true;
        for(var i=1;i<=s.Length;i++) {
            for(var j=0; j<i; j++) {
                if (dp[j] && dict.Contains(s.Substring(j, i-j))) {
                    dp[i] = true;
                    break;
                }
            }
        }
        
        return dp[s.Length];
    }
}

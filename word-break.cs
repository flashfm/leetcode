// Word Break
// https://leetcode.com/problems/word-break
// Date solved: 09/30/2020 05:47:47 +00:00

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
            var x = "";
            for(var j=i-1;j>=0;j--) {
                x = s[j] + x;
                if (dp[j] && dict.Contains(x)) {
                    dp[i] = true;
                    break;
                }
            }
        }
        
        return dp[s.Length];
    }
}

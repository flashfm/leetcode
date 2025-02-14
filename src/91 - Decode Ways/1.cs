// Copyright (c) 2020 Alexey Filatov
// 91 - Decode Ways (https://leetcode.com/problems/decode-ways)
// Date solved: 10/5/2020 3:46:28 AM +00:00
// Memory: 23.6 MB
// Runtime: 72 ms


public class Solution {
    public int NumDecodings(string s) {
        var n = s.Length;
        if (n==0) return 0;
        var dp = new int[n];
        dp[0] = s[0]>'0' ? 1 : 0;
        for(var i=1;i<n;i++) {
            var c = s[i];
            var pre = i>0 ? int.Parse(""+s[i-1]+s[i]) : 0;
            dp[i] = (s[i]>'0' ? dp[i-1] : 0) + (pre>=10 && pre<=26 ? (i>1 ? dp[i-2] : 1) : 0);
        }
        return dp[n-1];
    }
}

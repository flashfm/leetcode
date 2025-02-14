// Copyright (c) 2020 Alexey Filatov
// 91 - Decode Ways (https://leetcode.com/problems/decode-ways)
// Date solved: 10/5/2020 3:48:12 AM +00:00
// Memory: 23.7 MB
// Runtime: 76 ms


public class Solution {
    public int NumDecodings(string s) {
        var n = s.Length;
        var dp = new int[n];
        for(var i=0;i<n;i++) {
            var pre = i>0 ? int.Parse(""+s[i-1]+s[i]) : 0;
            dp[i] = (s[i]>'0' ? (i>0 ? dp[i-1] : 1) : 0) + (pre>=10 && pre<=26 ? (i>1 ? dp[i-2] : 1) : 0);
        }
        return n==0 ? 0 : dp[n-1];
    }
}

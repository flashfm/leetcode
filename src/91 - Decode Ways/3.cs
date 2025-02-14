// Copyright (c) 2020 Alexey Filatov
// 91 - Decode Ways (https://leetcode.com/problems/decode-ways)
// Date solved: 10/5/2020 3:49:49 AM +00:00
// Memory: 23.2 MB
// Runtime: 76 ms


public class Solution {
    public int NumDecodings(string s) {
        var dp = new int[s.Length];
        for(var i=0;i<s.Length;i++) {
            var pre = i>0 ? ((s[i-1]-'0')*10 + s[i]-'0') : 0;
            dp[i] = (s[i]>'0' ? (i>0 ? dp[i-1] : 1) : 0) + (pre>=10 && pre<=26 ? (i>1 ? dp[i-2] : 1) : 0);
        }
        return s.Length==0 ? 0 : dp[s.Length-1];
    }
}

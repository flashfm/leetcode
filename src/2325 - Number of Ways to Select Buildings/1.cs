// Copyright (c) 2024 Alexey Filatov
// 2325 - Number of Ways to Select Buildings (https://leetcode.com/problems/number-of-ways-to-select-buildings)
// Date solved: 10/27/2024 6:58:24 PM +00:00
// Memory: 52.3 MB
// Runtime: 91 ms


public class Solution {
    public long NumberOfWays(string s) {
        return WaysToChoose(s, "010") + WaysToChoose(s, "101");
    }

    private long WaysToChoose(string s, string val)
    {
        var dp = new long[s.Length];
        var prevDp = new long[s.Length];
        for(var j=0; j<val.Length; j++) {
            long sum = 0;
            for(var i = 0; i<s.Length; i++) {
                dp[i] = s[i]==val[j] ? (j==0 ? 1 : sum) : 0;
                sum += prevDp[i];
            }
            (dp, prevDp) = (prevDp, dp);
        }
        return prevDp.Sum();
    }
}

// Copyright (c) 2024 Alexey Filatov
// 97 - Interleaving String (https://leetcode.com/problems/interleaving-string)
// Date solved: 10/16/2024 1:40:44 AM +00:00
// Memory: 40.2 MB
// Runtime: 51 ms


public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        var l1 = s1.Length;
        var l2 = s2.Length;
        var l3 = s3.Length;
        if (l1+l2!=l3) {
            return false;
        }
        if (l1==l2 && l1==0) {
            return l3==0;
        }
        var dp = new bool[l1+1, l2+1]; // can we using substrings length i and j build s3 with length i+j?
        dp[0,0] = true;
        // for(var i = 1; i<=l1; i++) {
        //     dp[i,0] = dp[i-1, 0] && s1[i-1]==s3[i-1];
        // }
        // for(var i = 1; i<=l2; i++) {
        //     dp[0,i] = dp[0, i-1] && s2[i-1]==s3[i-1];
        // }
        for(var i = 0; i<=l1; i++) {
            for (var j=0; j<=l2; j++) { 
                dp[i,j] = (i==0 && j==0) || (i==0 ? false : dp[i-1,j] && s3[i+j-1]==s1[i-1]) || (j==0 ? false : dp[i,j-1] && s3[i+j-1]==s2[j-1]);
            }
        }
        return dp[l1, l2];
    }
}

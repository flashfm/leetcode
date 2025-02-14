// Copyright (c) 2024 Alexey Filatov
// 72 - Edit Distance (https://leetcode.com/problems/edit-distance)
// Date solved: 10/16/2024 5:30:14 AM +00:00
// Memory: 44.3 MB
// Runtime: 58 ms


public class Solution {
    public int MinDistance(string word1, string word2) {
        var l1 = word1.Length;
        var l2 = word2.Length;
        var dp = new int[l1+1, l2+1];
        for(var i = 0; i<=l1; i++) {
            for(var j = 0; j<=l2; j++) {
                dp[i,j] = j==0 ? i : (i==0 ? j : (word1[i-1]==word2[j-1] ? dp[i-1, j-1] : Math.Min(dp[i-1, j], Math.Min(dp[i, j-1], dp[i-1, j-1])) + 1));
            }
        }
        return dp[l1, l2];
    }
}

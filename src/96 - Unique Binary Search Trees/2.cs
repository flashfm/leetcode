// Copyright (c) 2025 Alexey Filatov
// 96 - Unique Binary Search Trees (https://leetcode.com/problems/unique-binary-search-trees)
// Date solved: 1/7/2025 7:31:04 AM +00:00
// Memory: 27.2 MB
// Runtime: 0 ms


public class Solution {
    public int NumTrees(int n) {  
        var dp = new int[n+1];
        dp[0] = dp[1] = 1;    
        for(var m=2; m<=n; m++) {
            for(var i=1; i<=m; i++) {
                dp[m] += dp[i-1] * dp[m-i];
            }
        }
        return dp[n];
    }
}

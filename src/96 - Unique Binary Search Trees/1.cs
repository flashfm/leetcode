// Copyright (c) 2025 Alexey Filatov
// 96 - Unique Binary Search Trees (https://leetcode.com/problems/unique-binary-search-trees)
// Date solved: 1/7/2025 7:28:34 AM +00:00
// Memory: 27.6 MB
// Runtime: 0 ms


public class Solution {
    public int NumTrees(int n) {  
        var dp = new int[n+1];      
        for(var m=1; m<=n; m++) {
            var sum = 0;
            for(var i=1; i<=m; i++) {
                sum += (i==1 ? 1 : dp[i-1]) * (i==m ? 1 : dp[m-i]);
            }
            dp[m] = sum;
        }
        return dp[n];
    }
}

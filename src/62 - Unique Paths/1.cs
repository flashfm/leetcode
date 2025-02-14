// Copyright (c) 2019 Alexey Filatov
// 62 - Unique Paths (https://leetcode.com/problems/unique-paths)
// Date solved: 12/25/2019 8:29:36 AM +00:00
// Memory: 14 MB
// Runtime: 40 ms


public class Solution {
    public int UniquePaths(int m, int n) {
        var memo = new int[n,m];
        for(var i=0;i<m;i++) {
            memo[0,i] = 1;
        }
        for(var i=0;i<n;i++) {
            memo[i,0] = 1;
        }
        for(var i=1;i<n;i++) {
            for(var j=1;j<m;j++) {
                memo[i,j] = memo[i,j-1] + memo[i-1,j];
            }
        }
        return memo[n-1,m-1];
    }
}

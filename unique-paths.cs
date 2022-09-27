// Unique Paths
// https://leetcode.com/problems/unique-paths
// Date solved: 12/25/2019 08:29:36 +00:00

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

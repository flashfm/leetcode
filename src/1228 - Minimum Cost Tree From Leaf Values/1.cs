// Copyright (c) 2024 Alexey Filatov
// 1228 - Minimum Cost Tree From Leaf Values (https://leetcode.com/problems/minimum-cost-tree-from-leaf-values)
// Date solved: 12/2/2024 3:57:51 AM +00:00
// Memory: 41.3 MB
// Runtime: 4 ms


public class Solution {
    public int MctFromLeafValues(int[] arr) {
        var n = arr.Length;
        var dp = new int[n, n]; // for I-J
        var rightMax = new int[n];
        for(var i=n-1; i>=0; i--) {
            // starting at i
            for(var j=i+1; j<n; j++) {
                // finishing at j
                rightMax[j] = arr[j];
                for(var k=j-1; k>=i; k--) {
                    rightMax[k] = Math.Max(arr[k], rightMax[k+1]);
                }
                var leftMax = int.MinValue;
                var min = int.MaxValue;
                for(var k=i; k<j; k++) {
                    leftMax = Math.Max(leftMax, arr[k]);
                    min = Math.Min(min, leftMax * rightMax[k+1] + dp[i, k] + dp[k+1, j]);
                }
                dp[i,j] = min;
            }
        }
       return dp[0, n-1];
    }
}

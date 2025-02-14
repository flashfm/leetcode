// Copyright (c) 2022 Alexey Filatov
// 279 - Perfect Squares (https://leetcode.com/problems/perfect-squares)
// Date solved: 10/19/2022 4:35:47 AM +00:00
// Memory: 29.1 MB
// Runtime: 1381 ms


public class Solution {
    public int NumSquares(int n) {
        var dp = new int[n+1];
        var squares = new HashSet<int>();
        for(var i = 1; i*i<=n; i++) {
            squares.Add(i*i);
        }
        for(var i = 1; i<=n; i++) {
            if (squares.Contains(i)) {
                dp[i] = 1;
            }
            else {
                var min = int.MaxValue;
                for(var j = i/2; j<i; j++) {
                    var c = dp[j] + dp[i-j];
                    if (c<min) {
                        min = c;
                    }
                }
                dp[i] = min;
            }
        }
        return dp[n];
    }
}

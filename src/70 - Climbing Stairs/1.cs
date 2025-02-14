// Copyright (c) 2020 Alexey Filatov
// 70 - Climbing Stairs (https://leetcode.com/problems/climbing-stairs)
// Date solved: 3/10/2020 8:06:58 AM +00:00
// Memory: 14.5 MB
// Runtime: 40 ms


public class Solution {
    public int ClimbStairs(int n) {
        if (n==1) return 1;
        var d1 = 1;
        var d2 = 2;
        for(var i = 3; i<=n; i++) {
            var t = d2;
            d2 = d1 + d2;
            d1 = t;
        }
        return d2;
    }
}

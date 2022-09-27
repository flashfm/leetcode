// Climbing Stairs
// https://leetcode.com/problems/climbing-stairs
// Date solved: 03/10/2020 08:06:58 +00:00

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

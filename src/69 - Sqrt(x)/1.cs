// Copyright (c) 2019 Alexey Filatov
// 69 - Sqrt(x) (https://leetcode.com/problems/sqrtx)
// Date solved: 12/31/2019 7:26:01 AM +00:00
// Memory: 14.2 MB
// Runtime: 40 ms


public class Solution {
    public int MySqrt(int x) {
        if (x==0) return 0;
        var l = 1;
        var r = x;
        while(r-l>1) {
            var m = l+(r-l)/2;
            var d = x/m;
            if (m==d) return m;
            if (m>d) r = m; else l = m;
        }
        return l;
    }
}

// x = 8, l = 0, r = 8
// m = 4, d = 2
// 4>2, l=0, r = 4
// m = 2, d = 4
// l = 2, r = 4
// m = 3, d = 2
// 3>2 => r = 3
// l = 2, r = 3
// m = 2, d = 4
// l = 2, r = 3


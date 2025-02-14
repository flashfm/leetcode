// Copyright (c) 2020 Alexey Filatov
// 7 - Reverse Integer (https://leetcode.com/problems/reverse-integer)
// Date solved: 6/15/2020 5:25:33 PM +00:00
// Memory: 14.6 MB
// Runtime: 40 ms


public class Solution {
    public int Reverse(int x) {
        long z = x;
        var neg = z<0;
        if (z<0) z = -z;
        long r = 0;
        while(z>0) {
            var d = z%10;
            z = z / 10;            
            r = r * 10 + d;
        }
        if (neg) {
            r = -r;            
        }
        return r>int.MaxValue || r<int.MinValue ? 0 : (int)r;
    }
}

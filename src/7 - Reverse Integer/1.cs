// Copyright (c) 2020 Alexey Filatov
// 7 - Reverse Integer (https://leetcode.com/problems/reverse-integer)
// Date solved: 3/14/2020 1:59:16 AM +00:00
// Memory: 14.7 MB
// Runtime: 44 ms


public class Solution {
    public int Reverse(int x) {
        var s = x<0 ? -1 : 1;
        long y = Math.Abs((long)x);
        long r = 0;
        while(y>0) {
            var d = y%10;
            y /= 10;
            r = r*10 + d;
            if (r>int.MaxValue || (r*s)<int.MinValue) return 0;
        }
        return (int)r*s;
    }
}

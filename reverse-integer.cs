// Reverse Integer
// https://leetcode.com/problems/reverse-integer
// Date solved: 06/15/2020 17:25:33 +00:00

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

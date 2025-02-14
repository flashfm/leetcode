// Copyright (c) 2024 Alexey Filatov
// 1585 - The kth Factor of n (https://leetcode.com/problems/the-kth-factor-of-n)
// Date solved: 10/25/2024 11:06:27 PM +00:00
// Memory: 27.3 MB
// Runtime: 0 ms


public class Solution {
    public int KthFactor(int n, int k) {
        var r = Math.Sqrt(n);
        var a = 0;
        for(var i = 1; i<r; i++) {
            if (n%i==0) {
                a++;
            }
            if (a==k) {
                return i;
            }
        }
        for(var i = (int)r; i>0; i--) {
            if (n%i==0) {
                a++;
            }
            if (a==k) {
                return n/i;
            }
        }
        return -1;
    }
}

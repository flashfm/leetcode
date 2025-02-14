// Copyright (c) 2019 Alexey Filatov
// 50 - Pow(x, n) (https://leetcode.com/problems/powx-n)
// Date solved: 12/31/2019 5:58:01 AM +00:00
// Memory: 14.5 MB
// Runtime: 44 ms


public class Solution {
    public double MyPow(double x, int n) {
        if (x==0) return 0;
        if (n==0) return 1;
        long ln = n;
        if (ln<0) {
            ln = -ln;
            x = 1/x;
        }
        var result = MyPow(x, (int)(ln/2));
        result *= result;
        if (ln%2==1) result *= x;
        
        return result;
    }
}

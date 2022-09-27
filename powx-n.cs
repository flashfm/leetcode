// Pow(x, n)
// https://leetcode.com/problems/powx-n
// Date solved: 12/31/2019 05:58:01 +00:00

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

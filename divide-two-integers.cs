// Divide Two Integers
// https://leetcode.com/problems/divide-two-integers
// Date solved: 01/14/2020 17:11:40 +00:00

public class Solution {
    public int Divide(int dividend, int divisor) {
        return DivideLong(dividend, divisor);
    }
    
    private int DivideLong(long dividend, long divisor) {
        //20 / 3
        
        //3 - 1
        //6 - 2
        //12 - 4
        //24 - 8
        
        // 24 - 3 = 21
        // 24 - 6 = 18
        // 18 + 3 = 21 - stop (first step, getting > dividend)
        
        var negative = (dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0);
        if (dividend<0) dividend = -dividend;
        if (divisor<0) divisor = -divisor;
        
        if (dividend < divisor) return 0;
        
        var current = divisor;
        long n = 1;
        var newCurrent = current;
        
        while (current<dividend) {
            newCurrent = current + current;
            if (newCurrent>=dividend) {
                n = n + DivideLong(dividend - current, divisor);
                break;
            }
            else {
                current = newCurrent;
                n += n;
            }
        }
                    
        var result = negative ? -n : n;
        return (result < int.MinValue || result > int.MaxValue) ? int.MaxValue : (int)result;
    }
}

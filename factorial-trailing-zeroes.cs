// Factorial Trailing Zeroes
// https://leetcode.com/problems/factorial-trailing-zeroes
// Date solved: 12/30/2019 09:29:04 +00:00

public class Solution {
    public int TrailingZeroes(int n) {
        // 2 3 4 5
        // 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 .. 
        // 2 * 5
        // 5, 10, 15, 20, (5*5)=25, 30   35  40 45 (5*5*2)=50
        // 1  2   3   4    6?       7            
        // +  +   +   +   ++        +    +   +  +   ++
        // *25 = *5*5 
        
        // 2 * 3 * (2*2) * 5 * 6 * 7 * (2*2*2) * 9 * (2*5) * 11 * (2*2*3) * 13 * (2*7) * (3*5)
        // * (2*2*2*2) * 17 * (2*9) * 19 * (2*2*5) * 21 * (2*11) * 23 * (2*2*2*3) * (5*5)
        // *26 * 27 * 28 * 29 * (6*5)
                
        
        // divide by 5 - this number of 0
        // divide by 25 - this number of 00 minus number of 0 (i.e. +4 - 2)
        // divide by 5^3 - this number of 000 minus number of 00        
        
        int divisor = 5;
        int result = 0;
        while(divisor<=n) {
            result += n / divisor;
            if (divisor>int.MaxValue/5) break;
            divisor *= 5;
        }
        return result;
    }
}

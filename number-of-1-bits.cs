// Number of 1 Bits
// https://leetcode.com/problems/number-of-1-bits
// Date solved: 03/11/2020 07:14:35 +00:00

public class Solution {
    public int HammingWeight(uint n) {
        uint result = 0;
        while(n>0) {
            result += n & 1;
            n = n >> 1;
        }
        return (int)result;
    }
}

// Reverse Bits
// https://leetcode.com/problems/reverse-bits
// Date solved: 03/17/2020 03:08:22 +00:00

public class Solution {
    public uint reverseBits(uint n) {
        uint result = 0;
        uint mask = ((uint)1) << 31;
        while(n>0) {
            if ((n & 1)==1) {
                result |= mask;
            }
            n = n >> 1;
            mask = mask >> 1;
        }
        return result;
    }
}

// Hamming Distance
// https://leetcode.com/problems/hamming-distance
// Date solved: 03/16/2020 08:55:42 +00:00

public class Solution {
    public int HammingDistance(int x, int y) {
        var xor = x^y;
        var result = 0;
        while(xor>0) {
            if ((xor & 1) == 1) result++;
            xor = xor >> 1;
        }
        return result;
    }
}

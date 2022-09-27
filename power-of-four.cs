// Power of Four
// https://leetcode.com/problems/power-of-four
// Date solved: 08/05/2020 06:14:49 +00:00

public class Solution {
    public bool IsPowerOfFour(int num) {
        // 4=100 - 2zeros
        // 16=10000 - 4zeros
        // 64=1000000 -8zeros
        long x = 1;
        while (x<int.MaxValue) {
            if (num==x) return true;
            x = x << 2;
        }
        return false;
    }
}

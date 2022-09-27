// Power of Three
// https://leetcode.com/problems/power-of-three
// Date solved: 03/17/2020 04:56:56 +00:00

public class Solution {
    public bool IsPowerOfThree(int n) {
        return n<1 ? false : 1162261467 % n == 0;
    }
}

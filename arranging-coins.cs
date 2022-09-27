// Arranging Coins
// https://leetcode.com/problems/arranging-coins
// Date solved: 07/07/2020 06:11:23 +00:00

public class Solution {
    public int ArrangeCoins(int n) {
        return (int)(Math.Sqrt(0.25 + 2*((long)n)) - 0.5);
    }
}
//n * (n+1) = 2*x
//n^2 + n - 2x = 0
//ay^2 + by + c = 0 => y = -(b +- sqsrt (b^2 - 4ac))/2a
//a = 1, b = 1, c = -2x

//y = (sqrt(1 + 8x)-1) / 2

// x = 15, x = 5
// 1,2,3,4,5 = 15 (5*6/2)

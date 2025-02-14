// Copyright (c) 2020 Alexey Filatov
// 441 - Arranging Coins (https://leetcode.com/problems/arranging-coins)
// Date solved: 7/7/2020 5:56:25 AM +00:00
// Memory: 14.7 MB
// Runtime: 100 ms


public class Solution {
    public int ArrangeCoins(int n) {
        var size = 1;
        var count = 0;
        while(n>=size) {
            n-=size;
            size++;
            count++;
        }
        return count;
    }
}

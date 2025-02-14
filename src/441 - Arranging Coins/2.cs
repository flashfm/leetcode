// Copyright (c) 2020 Alexey Filatov
// 441 - Arranging Coins (https://leetcode.com/problems/arranging-coins)
// Date solved: 7/7/2020 5:58:06 AM +00:00
// Memory: 14.5 MB
// Runtime: 72 ms


public class Solution {
    public int ArrangeCoins(int n) {
        var size = 1;
        while(n>=size) {
            n-=size;
            size++;
        }
        return size-1;
    }
}
// x = 20
// 1,2,3,4,5,6,7,8

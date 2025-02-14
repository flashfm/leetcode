// Copyright (c) 2024 Alexey Filatov
// 605 - Can Place Flowers (https://leetcode.com/problems/can-place-flowers)
// Date solved: 11/8/2024 10:02:22 PM +00:00
// Memory: 48.3 MB
// Runtime: 1 ms


public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        for(var i = 0; i<flowerbed.Length && n>0; i++) {
            if (flowerbed[i]==0 && (i-1<0 || flowerbed[i-1]!=1) && (i+1==flowerbed.Length || flowerbed[i+1]!=1)) {
                flowerbed[i]=1;
                n--;
            }
        }
        return n==0;
    }
}

// Copyright (c) 2024 Alexey Filatov
// 1950 - Sign of the Product of an Array (https://leetcode.com/problems/sign-of-the-product-of-an-array)
// Date solved: 12/17/2024 7:25:44 AM +00:00
// Memory: 42.2 MB
// Runtime: 0 ms


public class Solution {
    public int ArraySign(int[] nums) {
        var result = 1;
        foreach(var num in nums) {
            result *= (num>0 ? 1 : num<0 ? -1 : 0);
        }
        return result;
    }
}

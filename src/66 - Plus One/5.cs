// Copyright (c) 2020 Alexey Filatov
// 66 - Plus One (https://leetcode.com/problems/plus-one)
// Date solved: 7/7/2020 5:52:57 AM +00:00
// Memory: 29.9 MB
// Runtime: 452 ms


public class Solution {
    public int[] PlusOne(int[] digits) {
        var over = false;
        for(var i = digits.Length-1; i>=0; i--) {
            over = false;
            if (digits[i]!=9) {
                digits[i]++;
                break;
            }
            else {
                digits[i] = 0;
                over = true;
            }
        }
        if (over) {
            var arr = new int[digits.Length+1];
            arr[0] = 1;
            for(var i = 0; i<digits.Length; i++) arr[i+1] = digits[i];
            digits = arr;            
        }
        return digits;
    }
}

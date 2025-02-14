// Copyright (c) 2024 Alexey Filatov
// 1626 - Can Make Arithmetic Progression From Sequence (https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence)
// Date solved: 12/17/2024 7:28:09 AM +00:00
// Memory: 43.3 MB
// Runtime: 3 ms


public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        if (arr.Length<=2) {
            return true;
        }
        Array.Sort(arr);
        var d = arr[1]-arr[0];
        for(var i=2; i<arr.Length; i++) {
            if (arr[i]-arr[i-1]!=d) {
                return false;
            }
        }
        return true;
    }
}

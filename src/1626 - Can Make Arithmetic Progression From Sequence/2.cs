// Copyright (c) 2024 Alexey Filatov
// 1626 - Can Make Arithmetic Progression From Sequence (https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence)
// Date solved: 12/17/2024 7:44:54 AM +00:00
// Memory: 43.6 MB
// Runtime: 7 ms


public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        var n = arr.Length;
        if (n==1) {
            return true;
        }
        var min = arr.Min();
        var max = arr.Max();
        if ((max-min) % (n-1) != 0) {
            return false;
        }
        var d = (max-min) / (n-1);
        var hashSet = new HashSet<int>(arr);
        for(var i=0; i<n; i++) {
            if (!hashSet.Contains(min+i*d)) {
                return false;
            }
        }
        return true;
    }
}

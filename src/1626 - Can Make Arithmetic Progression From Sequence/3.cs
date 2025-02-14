// Copyright (c) 2024 Alexey Filatov
// 1626 - Can Make Arithmetic Progression From Sequence (https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence)
// Date solved: 12/17/2024 7:59:59 AM +00:00
// Memory: 44.3 MB
// Runtime: 6 ms


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
        var i = 0;
        while(i<n) {
            // is arr[i] on it's place (based on i and d)?
            if (arr[i] == min + i*d) {
                i++; // yes
            }
            else if ((arr[i] - min) % d !=0) {
                return false; // no d*N between min and arr[i]
            }
            else {
                var pos = (arr[i] - min) / d;
                // pos should be > i, since we put in increasing order always
                // and there should be no dupe in terms of d (d==0 allows dupes)
                if (pos<i || arr[pos]==arr[i]) {
                    return false;
                }
                (arr[i], arr[pos]) = (arr[pos], arr[i]);
            }
        }
        return true;
    }
}

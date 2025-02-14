// Copyright (c) 2024 Alexey Filatov
// 2392 - Successful Pairs of Spells and Potions (https://leetcode.com/problems/successful-pairs-of-spells-and-potions)
// Date solved: 11/22/2024 7:50:42 AM +00:00
// Memory: 90.7 MB
// Runtime: 29 ms


public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        var result = new int[spells.Length];
        for(var i = 0; i<spells.Length; i++) {
            var s = spells[i];
            var l = 0;
            var r = potions.Length-1;
            while(l<=r) {
                var m = l + (r-l)/2;
                var p = potions[m];
                if ((long)s*p<success) {
                    l = m+1;
                }
                else {
                    r = m-1;
                }
            }
            // l is the position of last number that is < success
            result[i] = potions.Length-l;
        }
        return result;
    }
}

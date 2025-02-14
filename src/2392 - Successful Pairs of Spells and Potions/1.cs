// Copyright (c) 2024 Alexey Filatov
// 2392 - Successful Pairs of Spells and Potions (https://leetcode.com/problems/successful-pairs-of-spells-and-potions)
// Date solved: 11/22/2024 7:48:25 AM +00:00
// Memory: 82.2 MB
// Runtime: 31 ms


public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        var result = new List<int>();
        foreach(var s in spells) {
            var l = 0;
            var r = potions.Length-1;
            while(l<r) {
                var m = l + (r-l)/2;
                var p = potions[m];
                if ((long)s*p<success) {
                    l = m+1;
                }
                else {
                    r = m-1;
                }
            }
            if ((long)s*potions[l]>=success) {
                l--;
            }
            // l is the position of last number that is < success
            result.Add(potions.Length-1-l);
        }
        return result.ToArray();
    }
}

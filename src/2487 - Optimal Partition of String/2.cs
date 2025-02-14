// Copyright (c) 2024 Alexey Filatov
// 2487 - Optimal Partition of String (https://leetcode.com/problems/optimal-partition-of-string)
// Date solved: 10/25/2024 11:56:06 PM +00:00
// Memory: 43.8 MB
// Runtime: 2 ms


public class Solution {
    public int PartitionString(string s) {
        int existing = 0;
        var result = 0;
        foreach(var c in s) {
            var v = c-'a';
            var bit = 1<<v;
            if ((existing & bit) != 0) {
                existing = 0;
                result++;
            }
            existing |= bit;
        }
        if (existing>0) {
            result++;
        }
        return result;
    }
}

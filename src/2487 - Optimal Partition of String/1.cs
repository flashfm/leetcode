// Copyright (c) 2024 Alexey Filatov
// 2487 - Optimal Partition of String (https://leetcode.com/problems/optimal-partition-of-string)
// Date solved: 10/25/2024 11:52:51 PM +00:00
// Memory: 43.3 MB
// Runtime: 13 ms


public class Solution {
    public int PartitionString(string s) {
        var existing = new HashSet<char>();
        var result = 0;
        foreach(var c in s) {
            if (existing.Contains(c)) {
                existing.Clear();
                result++;
            }
            existing.Add(c);
        }
        if (existing.Count>0) {
            result++;
        }
        return result;
    }
}

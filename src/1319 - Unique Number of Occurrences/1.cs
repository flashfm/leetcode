// Copyright (c) 2024 Alexey Filatov
// 1319 - Unique Number of Occurrences (https://leetcode.com/problems/unique-number-of-occurrences)
// Date solved: 10/29/2024 4:48:02 AM +00:00
// Memory: 42.5 MB
// Runtime: 1 ms


public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var dict = new Dictionary<int, int>();
        foreach(var a in arr) {
            dict[a] = dict.GetValueOrDefault(a) + 1;
        }
        var hs = new HashSet<int>();
        foreach(var v in dict.Values) {
            if (hs.Contains(v)) {
                return false;
            }
            hs.Add(v);
        }
        return true;
    }
}

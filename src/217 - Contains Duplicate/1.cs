// Copyright (c) 2020 Alexey Filatov
// 217 - Contains Duplicate (https://leetcode.com/problems/contains-duplicate)
// Date solved: 3/17/2020 7:03:41 AM +00:00
// Memory: 31.7 MB
// Runtime: 112 ms


public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var hashSet = new HashSet<int>();
        foreach(var n in nums) {
            if (hashSet.Contains(n)) return true;
            hashSet.Add(n);
        }
        return false;
    }
}

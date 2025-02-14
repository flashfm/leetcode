// Copyright (c) 2020 Alexey Filatov
// 260 - Single Number III (https://leetcode.com/problems/single-number-iii)
// Date solved: 7/25/2020 5:24:18 AM +00:00
// Memory: 31.4 MB
// Runtime: 408 ms


public class Solution {
    public int[] SingleNumber(int[] nums) {
        var hashset = new HashSet<int>();
        foreach(var n in nums) {
            if (hashset.Contains(n)) {
                hashset.Remove(n);
            }
            else {
                hashset.Add(n);
            }
        }
        return hashset.ToArray();
    }
}

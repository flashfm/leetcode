// Copyright (c) 2020 Alexey Filatov
// 260 - Single Number III (https://leetcode.com/problems/single-number-iii)
// Date solved: 7/25/2020 5:24:49 AM +00:00
// Memory: 31.6 MB
// Runtime: 332 ms


public class Solution {
    public int[] SingleNumber(int[] nums) {
        var hashset = new HashSet<int>(nums.Length);
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

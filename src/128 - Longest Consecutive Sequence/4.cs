// Copyright (c) 2020 Alexey Filatov
// 128 - Longest Consecutive Sequence (https://leetcode.com/problems/longest-consecutive-sequence)
// Date solved: 3/27/2020 5:04:30 AM +00:00
// Memory: 24.9 MB
// Runtime: 96 ms


public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hash = nums.ToHashSet();
        var result = 0;
        foreach(var x in nums) {
            if (!hash.Contains(x-1)) {
                // x is a start of seq                
                var seq = 1;
                var d = 1;
                while(hash.Contains(x+(d++))) seq++;
                if (seq>result) result = seq;
            }
        }    
        return result;
    }
}

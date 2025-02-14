// Copyright (c) 2020 Alexey Filatov
// 128 - Longest Consecutive Sequence (https://leetcode.com/problems/longest-consecutive-sequence)
// Date solved: 3/27/2020 4:56:51 AM +00:00
// Memory: 25.3 MB
// Runtime: 100 ms


public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hash = new HashSet<int>();
        foreach(var x in nums) hash.Add(x);
        
        var result = 0;
        while(hash.Count>0) {
            var curSec = 1;
            var x = hash.First();
            hash.Remove(x);
            var goLeft = true;
            var goRight = true;
            var d = 1;
            while(goLeft || goRight) {
                if (goLeft && hash.Contains(x-d)) {
                    curSec++;
                    hash.Remove(x-d);
                }
                else {
                    goLeft = false;
                }
                if (goRight && hash.Contains(x+d)) {
                    curSec++;
                    hash.Remove(x+d);
                }
                else {
                    goRight = false;
                }
                d++;
                result = Math.Max(result, curSec);
            }
        }
        
        return result;
    }
}

// Longest Consecutive Sequence
// https://leetcode.com/problems/longest-consecutive-sequence
// Date solved: 03/27/2020 05:04:30 +00:00

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

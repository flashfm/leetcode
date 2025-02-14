// Copyright (c) 2024 Alexey Filatov
// 228 - Summary Ranges (https://leetcode.com/problems/summary-ranges)
// Date solved: 9/24/2024 10:45:13 PM +00:00
// Memory: 46.3 MB
// Runtime: 100 ms


public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var result = new List<string>();
        if (nums.Length==0) {
            return result;
        }
        var l = nums[0];
        var r = nums[0];
        foreach(var n in nums.Skip(1)) {
            if (n == r+1) {
                r = n;
            }
            else {
                result.Add(l==r ? l.ToString() : l + "->" + r);
                l = r = n;
            }
        }
        result.Add(l==r ? l.ToString() : l + "->" + r);
        return result;
    }
}

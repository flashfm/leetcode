// Copyright (c) 2024 Alexey Filatov
// 740 - Delete and Earn (https://leetcode.com/problems/delete-and-earn)
// Date solved: 12/19/2024 2:14:45 AM +00:00
// Memory: 44.3 MB
// Runtime: 14 ms


public class Solution {
    public int DeleteAndEarn(int[] nums) {
        Array.Sort(nums);
        var n = nums.Length;
        var counts = new List<(int N, int C)>();
        var count = 1;
        for(var i=1; i<n; i++) {
            if (nums[i]!=nums[i-1]) {
                counts.Add((nums[i-1], count));
                count = 1;
            }
            else {
                count++;
            }
        }
        counts.Add((nums[n-1], count));
        var pick = new int[counts.Count];
        pick[0] = counts[0].C * counts[0].N;
        for(var i=1; i<counts.Count; i++) {
            var c = counts[i];
            pick[i] = Math.Max(pick[i-1], c.N * c.C + (counts[i-1].N!=c.N-1 ? pick[i-1] : (i-2>=0 ? pick[i-2] : 0)));
        }
        return pick[counts.Count-1];
    }
}

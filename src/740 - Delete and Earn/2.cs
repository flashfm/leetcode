// Copyright (c) 2024 Alexey Filatov
// 740 - Delete and Earn (https://leetcode.com/problems/delete-and-earn)
// Date solved: 12/19/2024 2:37:27 AM +00:00
// Memory: 45.8 MB
// Runtime: 17 ms


public class Solution {
    public int DeleteAndEarn(int[] nums) {
        var n = nums.Length;
        var dict = new Dictionary<int, int>();
        foreach(var num in nums) {
            dict[num] = dict.GetValueOrDefault(num) + 1;
        }
        var counts = dict.OrderBy(p => p.Key).ToArray();
        var pick = new int[counts.Length];
        pick[0] = counts[0].Value * counts[0].Key;
        for(var i=1; i<pick.Length; i++) {
            var c = counts[i];
            pick[i] = Math.Max(pick[i-1], c.Value * c.Key + (counts[i-1].Key!=c.Key-1 ? pick[i-1] : (i-2>=0 ? pick[i-2] : 0)));
        }
        return pick[pick.Length-1];
    }
}

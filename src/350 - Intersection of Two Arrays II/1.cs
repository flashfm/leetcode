// Copyright (c) 2020 Alexey Filatov
// 350 - Intersection of Two Arrays II (https://leetcode.com/problems/intersection-of-two-arrays-ii)
// Date solved: 3/21/2020 5:19:32 AM +00:00
// Memory: 31.1 MB
// Runtime: 248 ms


public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var dict = new Dictionary<int, int>();
        var result = new List<int>();
        foreach(var n in nums1) {
            dict.TryGetValue(n, out var count);
            dict[n] = count+1;
        }
        foreach(var n in nums2) {
            if (dict.TryGetValue(n, out var count) && count>0) {
                result.Add(n);
                dict[n] = count-1;
            }
        }
        return result.ToArray();
    }
}

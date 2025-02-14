// Copyright (c) 2024 Alexey Filatov
// 1392 - Find the Difference of Two Arrays (https://leetcode.com/problems/find-the-difference-of-two-arrays)
// Date solved: 11/10/2024 8:30:44 PM +00:00
// Memory: 59.5 MB
// Runtime: 7 ms


public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var h1 = new HashSet<int>(nums1);
        var h2 = new HashSet<int>(nums2);
        var r1 = new List<int>(nums1.Length);
        var r2 = new List<int>(nums2.Length);
        foreach(var n in h1) {
            if (!h2.Contains(n)) {
                r1.Add(n);
            }
        }
        foreach(var n in h2) {
            if (!h1.Contains(n)) {
                r2.Add(n);
            }
        }
        return new[] {r1.ToArray(), r2.ToArray()};
    }
}

// Intersection of Two Arrays II
// https://leetcode.com/problems/intersection-of-two-arrays-ii
// Date solved: 03/21/2020 05:19:32 +00:00

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

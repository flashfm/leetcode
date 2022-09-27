// Majority Element
// https://leetcode.com/problems/majority-element
// Date solved: 01/16/2020 16:21:16 +00:00

public class Solution {
    public int MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach(var n in nums) dict[n] = dict.TryGetValue(n, out var o) ? o + 1 : 1;
        var n2 = nums.Length/2;
        foreach(var (n, c) in dict) if (c>n2) return n;
        return 0;
    }
}

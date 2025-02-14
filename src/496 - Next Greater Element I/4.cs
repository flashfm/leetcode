// Copyright (c) 2024 Alexey Filatov
// 496 - Next Greater Element I (https://leetcode.com/problems/next-greater-element-i)
// Date solved: 11/30/2024 8:45:39 PM +00:00
// Memory: 47.2 MB
// Runtime: 4 ms


public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var s = new Dictionary<int, int>();
        var stack = new Stack<int>();
        foreach(var n in nums2) {
            while(stack.Count>0 && stack.Peek()<n) {
                s[stack.Pop()] = n;
            }
            stack.Push(n);
        }
        var result = new int[nums1.Length];
        for(var i=0; i<nums1.Length; i++) {
            result[i] = s.GetValueOrDefault(nums1[i], -1);
        }
        return result;
    }
}

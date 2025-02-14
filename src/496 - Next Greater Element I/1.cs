// Copyright (c) 2024 Alexey Filatov
// 496 - Next Greater Element I (https://leetcode.com/problems/next-greater-element-i)
// Date solved: 11/30/2024 8:37:40 PM +00:00
// Memory: 47.1 MB
// Runtime: 8 ms


public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var s = new Dictionary<int,int>();
        for(var i = 0; i<nums1.Length; i++) {
            s[nums1[i]] = i;
        }
        var result = new int[nums1.Length];
        var stack = new Stack<int>();
        for(var i=nums2.Length-1; i>=0; i--) {
            var n = nums2[i];            
            while(stack.Count>0 && stack.Peek()<=n) {
                stack.Pop();
            }
            if (s.TryGetValue(n, out var j)) {
                result[j] = stack.Count>0 ? stack.Peek() : -1;
            }
            stack.Push(n);
        }
        return result;
    }
}

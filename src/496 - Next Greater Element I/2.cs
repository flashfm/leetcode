// Copyright (c) 2024 Alexey Filatov
// 496 - Next Greater Element I (https://leetcode.com/problems/next-greater-element-i)
// Date solved: 11/30/2024 8:40:50 PM +00:00
// Memory: 47 MB
// Runtime: 3 ms


public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var s = new Dictionary<int,int>();
        var stack = new Stack<int>();
        for(var i=nums2.Length-1; i>=0; i--) {
            var n = nums2[i];            
            while(stack.Count>0 && stack.Peek()<=n) {
                stack.Pop();
            }
            s[n] = stack.Count>0 ? stack.Peek() : -1;
            stack.Push(n);
        }
        var result = new int[nums1.Length];
        for(var i=0; i<nums1.Length; i++) {
            result[i] = s[nums1[i]];
        }
        return result;
    }
}

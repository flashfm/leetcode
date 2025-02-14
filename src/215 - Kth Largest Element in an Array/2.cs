// Copyright (c) 2024 Alexey Filatov
// 215 - Kth Largest Element in an Array (https://leetcode.com/problems/kth-largest-element-in-an-array)
// Date solved: 10/11/2024 4:07:37 AM +00:00
// Memory: 55.1 MB
// Runtime: 321 ms


public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // min-heap
        var s = new PriorityQueue<int, int>();
        foreach(var n in nums) {
            if (s.Count<k) {
                s.Enqueue(n, n);
            }
            else if (n>=s.Peek()) {
                s.DequeueEnqueue(n, n);
            }
        }
        return s.Peek();        
    }
}

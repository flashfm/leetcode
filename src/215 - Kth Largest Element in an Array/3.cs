// Copyright (c) 2024 Alexey Filatov
// 215 - Kth Largest Element in an Array (https://leetcode.com/problems/kth-largest-element-in-an-array)
// Date solved: 10/11/2024 4:12:02 AM +00:00
// Memory: 56.9 MB
// Runtime: 382 ms


public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // min-heap
        var s = new PriorityQueue<int, int>(nums.Select(n => (-n, -n)));
        for(var i = 0; i<k-1; i++) {
            s.Dequeue();
        }
        return -s.Peek();        
    }
}

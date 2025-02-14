// Copyright (c) 2024 Alexey Filatov
// 2553 - Total Cost to Hire K Workers (https://leetcode.com/problems/total-cost-to-hire-k-workers)
// Date solved: 11/19/2024 2:12:17 AM +00:00
// Memory: 71.4 MB
// Runtime: 128 ms


public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        var n = costs.Length;
        var rightHeap = new PriorityQueue<int, int>();
        var leftHeap = new PriorityQueue<int, int>();
        var indexRemoved = new bool[costs.Length];
        var l = 0;
        var r = n-1;
        long sum = 0;
        for(var i = 0; i<k; i++) {
            while(leftHeap.Count<candidates && l<=r) {
                leftHeap.Enqueue(costs[l], costs[l]);
                l++;
            }
            while(rightHeap.Count<candidates && l<=r) {
                rightHeap.Enqueue(costs[r], costs[r]);
                r--;
            }
            var lc = leftHeap.Count>0 ? leftHeap.Peek() : int.MaxValue;
            var rc = rightHeap.Count>0 ? rightHeap.Peek() : int.MaxValue;

            if (lc<=rc) {
                sum += lc;
                leftHeap.Dequeue();
            }
            else {
                sum += rc;
                rightHeap.Dequeue();
            }
        }
        return sum;
    }
}

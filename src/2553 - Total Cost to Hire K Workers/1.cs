// Copyright (c) 2024 Alexey Filatov
// 2553 - Total Cost to Hire K Workers (https://leetcode.com/problems/total-cost-to-hire-k-workers)
// Date solved: 11/19/2024 2:07:18 AM +00:00
// Memory: 73.2 MB
// Runtime: 204 ms


public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        var n = costs.Length;
        var rightHeap = new PriorityQueue<int, int>();
        var leftHeap = new PriorityQueue<int, int>();
        var indexRemoved = new bool[costs.Length];
        var l = 0;
        var r = n-1-l;
        for(var i=0;i<candidates;i++) {
            leftHeap.Enqueue(l, costs[l]);
            rightHeap.Enqueue(r, costs[r]);
            l++;
            r--;
        }
        long sum = 0;
        for(var i = 0; i<k; i++) {
            // dequeue both heaps if we see indexRemoved
            while(leftHeap.Count>0 && indexRemoved[leftHeap.Peek()]) {
                leftHeap.Dequeue();
            }
            while(rightHeap.Count>0 && indexRemoved[rightHeap.Peek()]) {
                rightHeap.Dequeue();
            }
            if (leftHeap.Count==0 && rightHeap.Count==0) {
                break;
            }
            int indexToRemove;
            if (leftHeap.Count==0) {
                indexToRemove = rightHeap.Peek();
            }
            else if (rightHeap.Count==0) {
                indexToRemove = leftHeap.Peek();
            }
            else {
                var lc = costs[leftHeap.Peek()];
                var rc = costs[rightHeap.Peek()];
                indexToRemove = lc<rc || (lc==rc && leftHeap.Peek()<rightHeap.Peek()) ? leftHeap.Peek() : rightHeap.Peek();
            }

            sum += costs[indexToRemove];
            indexRemoved[indexToRemove] = true;
            // add 1 more
            if (indexToRemove<=l && l<n) {
                leftHeap.Enqueue(l, costs[l]);
                l++;
            }
            if (indexToRemove>=r && r>=0) { 
                rightHeap.Enqueue(r, costs[r]);
                r--;
            }
        }
        return sum;
    }
}

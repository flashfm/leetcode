// Copyright (c) 2024 Alexey Filatov
// 373 - Find K Pairs with Smallest Sums (https://leetcode.com/problems/find-k-pairs-with-smallest-sums)
// Date solved: 10/11/2024 4:46:19 AM +00:00
// Memory: 115 MB
// Runtime: 800 ms


public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var queue = new PriorityQueue<int[], int>();
        foreach(var n1 in nums1) {
            var updated = false;
            foreach(var n2 in nums2) {
                var val = -n1-n2;
                if (queue.Count<k) {
                    queue.Enqueue(new int[] {n1, n2}, val);
                    updated = true;
                }
                else if (queue.TryPeek(out _, out var peek) && val > peek) {
                    queue.DequeueEnqueue(new int[] {n1, n2}, val);
                    updated = true;
                }
            }
            if (!updated) {
                break;
            }
        }
        var result = new List<IList<int>>();
        for(var i = 0; i<k; i++) {
            result.Add(queue.Dequeue());
        }
        return result;
    }
}

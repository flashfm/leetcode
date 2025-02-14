// Copyright (c) 2024 Alexey Filatov
// 373 - Find K Pairs with Smallest Sums (https://leetcode.com/problems/find-k-pairs-with-smallest-sums)
// Date solved: 10/11/2024 4:56:06 AM +00:00
// Memory: 116.9 MB
// Runtime: 681 ms


public class Solution {
    public class MaxComparer : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }

    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var queue = new PriorityQueue<int[], int>(new MaxComparer());
        foreach(var n1 in nums1) {
            var updated = false;
            foreach(var n2 in nums2) {
                var val = n1+n2;
                if (queue.Count<k) {
                    queue.Enqueue(new int[] {n1, n2}, val);
                    updated = true;
                }
                else if (queue.TryPeek(out _, out var peek) && val < peek) {
                    queue.DequeueEnqueue(new int[] {n1, n2}, val);
                    updated = true;
                }
                else {
                    break;
                }
            }
            if (!updated) {
                break;
            }
        }
        return queue.UnorderedItems.Select(i => i.Element).ToArray();
    }
}

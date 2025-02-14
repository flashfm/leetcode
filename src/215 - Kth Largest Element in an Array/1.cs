// Copyright (c) 2020 Alexey Filatov
// 215 - Kth Largest Element in an Array (https://leetcode.com/problems/kth-largest-element-in-an-array)
// Date solved: 1/28/2020 5:09:30 AM +00:00
// Memory: 27.3 MB
// Runtime: 108 ms


public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // min-heap
        var s = new SortedSet<Key>(new Key());
        foreach(var n in nums) {
            if (s.Count<k) {
                s.Add(new Key {val=n});
            }
            else if (n>=s.Min.val) {
                s.Remove(s.Min);
                s.Add(new Key {val=n});
            }
        }
        return s.Min.val;
    }
    
    public class Key: IComparer<Key>
    {
        public int val;
        private Guid guid = Guid.NewGuid();
        
        public int Compare(Key a, Key b)
        {
            return a.val==b.val ? a.guid.CompareTo(b.guid) : a.val.CompareTo(b.val);
        }
    }
}

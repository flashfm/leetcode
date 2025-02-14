// Copyright (c) 2020 Alexey Filatov
// 23 - Merge k Sorted Lists (https://leetcode.com/problems/merge-k-sorted-lists)
// Date solved: 2/7/2020 6:28:17 AM +00:00
// Memory: 28.9 MB
// Runtime: 132 ms


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

// minhash and pointers of all lists
// (a0+a1+a2+a3+a4) * log(4)

public class Solution {
    public ListNode MergeKLists(ListNode[] lists)
    {
        var minheap = new SortedSet<Key>(new Key());
        foreach(var l in lists) {
            if (l!=null) {
                minheap.Add(new Key { Node = l });
            }
        }
        ListNode current = null;
        ListNode head = null;
        while(minheap.Count>0) {
            var minKey = minheap.Min;
            minheap.Remove(minKey);
            var minHead = minKey.Node;
            
            if (head==null) head=minHead;
            if (current!=null) {
                current.next = minHead;
            }
            current = minHead;
            minHead = minHead.next;
            if (minHead!=null) {
                minheap.Add(new Key { Node = minHead });
            }
        }
        return head;
    }

    public class Key: IComparer<Key>
    {
        public Guid Guid;
        public ListNode Node;
        
        public Key() => Guid = Guid.NewGuid();
        
        public int Compare(Key a, Key b) => a.Node.val==b.Node.val ? a.Guid.CompareTo(b.Guid) : a.Node.val.CompareTo(b.Node.val);
    }
}

// Copyright (c) 2024 Alexey Filatov
// 23 - Merge k Sorted Lists (https://leetcode.com/problems/merge-k-sorted-lists)
// Date solved: 11/1/2024 11:12:50 PM +00:00
// Memory: 47.9 MB
// Runtime: 14 ms


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists==null) {
            return null;
        }
        var minHeap = new PriorityQueue<ListNode, int>();
        foreach(var node in lists) {
            if (node!=null) {
                minHeap.Enqueue(node, node.val);
            }
        }
        var fakeRoot = new ListNode();
        ListNode cur = fakeRoot;
        while(minHeap.Count>0) {
            var node = minHeap.Dequeue();
            if (node.next!=null) {
                minHeap.Enqueue(node.next, node.next.val);
            }
            cur.next = node;
            cur = node;
        }
        return fakeRoot.next;
    }
}

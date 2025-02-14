// Copyright (c) 2024 Alexey Filatov
// 82 - Remove Duplicates from Sorted List II (https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii)
// Date solved: 9/28/2024 4:24:44 AM +00:00
// Memory: 42 MB
// Runtime: 74 ms


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
    public ListNode DeleteDuplicates(ListNode head) {
        var fakeHead = new ListNode(0);
        var prev = fakeHead;
        var node = head;
        while(node!=null) {
            while(node!=null && node.next!=null && node.next.val==node.val) {
                node = node.next;
                if (node.next==null || node.next.val!=node.val) {
                    node = node.next;
                }
            }
            prev.next = node;
            prev = node;
            node = node?.next;
        }
        return fakeHead.next;
    }
}

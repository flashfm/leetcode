// Copyright (c) 2024 Alexey Filatov
// 206 - Reverse Linked List (https://leetcode.com/problems/reverse-linked-list)
// Date solved: 10/29/2024 4:53:46 AM +00:00
// Memory: 41.9 MB
// Runtime: 0 ms


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
    public ListNode ReverseList(ListNode head) {
        if (head==null) {
            return null;
        }
        var (nh, nt) = Reverse(head);
        return nh;
    }

    private (ListNode, ListNode) Reverse(ListNode head)
    {
        if (head.next==null) {
            return (head, head);
        }
        var (newHead, newTail) = Reverse(head.next);
        newTail.next = head;
        head.next = null;
        return (newHead, head);
    }
}

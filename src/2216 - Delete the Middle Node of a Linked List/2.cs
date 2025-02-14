// Copyright (c) 2024 Alexey Filatov
// 2216 - Delete the Middle Node of a Linked List (https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list)
// Date solved: 11/14/2024 11:14:17 PM +00:00
// Memory: 129.9 MB
// Runtime: 13 ms


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
    public ListNode DeleteMiddle(ListNode head) {
        if (head.next==null) {
            return null;
        }
        var node = head;
        var node2 = head;
        while(node2?.next!=null) {
            node2 = node2.next?.next;
            if (node2?.next!=null) {
                node = node.next;
            }
        }
        node.next = node.next?.next;
        return head;
    }
}

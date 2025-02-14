// Copyright (c) 2024 Alexey Filatov
// 2216 - Delete the Middle Node of a Linked List (https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list)
// Date solved: 11/14/2024 11:07:42 PM +00:00
// Memory: 101.7 MB
// Runtime: 3 ms


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
        var n = 0;
        var node = head;
        while(node!=null) {
            n++;
            node = node.next;
        }
        if (n==1) {
            return null;
        }
        var i = 0;
        node = head;
        ListNode prev = null;
        while(node!=null) {
            if (i==n/2) {
                prev.next = node.next;
                return head;
            }
            i++;
            prev = node;
            node = node.next;
        }
        return null;
    }
}

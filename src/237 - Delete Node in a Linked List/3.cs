// Copyright (c) 2022 Alexey Filatov
// 237 - Delete Node in a Linked List (https://leetcode.com/problems/delete-node-in-a-linked-list)
// Date solved: 10/13/2022 6:39:23 AM +00:00
// Memory: 37.6 MB
// Runtime: 134 ms


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        var prev = node;
        while (node.next!=null) {
            node.val = node.next.val;
            prev = node;
            node = node.next;
        }
        prev.next = null;
    }
}

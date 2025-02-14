// Copyright (c) 2020 Alexey Filatov
// 237 - Delete Node in a Linked List (https://leetcode.com/problems/delete-node-in-a-linked-list)
// Date solved: 3/8/2020 2:01:54 AM +00:00
// Memory: 25.6 MB
// Runtime: 96 ms


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
        node.val = node.next.val;
        node.next = node.next.next;
    }
}

// Copyright (c) 2024 Alexey Filatov
// 206 - Reverse Linked List (https://leetcode.com/problems/reverse-linked-list)
// Date solved: 10/29/2024 4:59:06 AM +00:00
// Memory: 41.8 MB
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
        var stack = new Stack<ListNode>();
        while(head!=null) {
            stack.Push(head);
            head = head.next;
        }
        head = stack.Pop();
        var node = head;
        while(stack.Count>0) {
            node.next = stack.Pop();
            node = node.next;
        }
        node.next = null;
        return head;
    }
}

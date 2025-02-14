// Copyright (c) 2024 Alexey Filatov
// 92 - Reverse Linked List II (https://leetcode.com/problems/reverse-linked-list-ii)
// Date solved: 9/27/2024 5:59:59 PM +00:00
// Memory: 40.9 MB
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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        var i = 1;
        var result = new ListNode();
        var root = result;
        var current = head;
        while(i<left) {
            result.next = new ListNode(current.val);
            result = result.next;
            current = current.next;
            i++;
        }
        var stack = new Stack<int>();
        while(i<=right) {
            stack.Push(current.val);
            current = current.next;
            i++;
        }
        foreach(var v in stack) {
            result.next = new ListNode(v);
            result = result.next;
        }
        while(current!=null) {
            result.next = new ListNode(current.val);
            result = result.next;
            current = current.next;
        }
        return root.next;
    }
}

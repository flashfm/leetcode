// Copyright (c) 2024 Alexey Filatov
// 25 - Reverse Nodes in k-Group (https://leetcode.com/problems/reverse-nodes-in-k-group)
// Date solved: 9/27/2024 9:32:49 PM +00:00
// Memory: 45.5 MB
// Runtime: 85 ms


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
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode tail;
        (head, tail) = Reverse(head, k);
        while(tail.next!=null) {
            var (newHead, newTail) = Reverse(tail.next, k);
            tail.next = newHead;
            tail = newTail;
        }
        return head;
    }

    private (ListNode, ListNode) Reverse(ListNode head, int k)
    {
        var i = 0;
        var stack = new Stack<ListNode>();
        var node = head;
        while(i<k) {
            stack.Push(node);
            if (node.next==null) {
                break;
            }
            i++;
            node = node.next;
        }
        var tail = stack.Peek();
        var tailNext = tail.next;
        if (stack.Count<k) {
            return (head, tail);
        }
        while(stack.Count>0) {
            stack.Pop().next = stack.Count>0 ? stack.Peek() : tailNext;
        }
        return (tail, head);
    }
}

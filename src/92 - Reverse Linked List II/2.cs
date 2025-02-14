// Copyright (c) 2024 Alexey Filatov
// 92 - Reverse Linked List II (https://leetcode.com/problems/reverse-linked-list-ii)
// Date solved: 9/27/2024 6:14:40 PM +00:00
// Memory: 40.6 MB
// Runtime: 57 ms


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
        var fakeRoot = new ListNode(0, head);
        var current = fakeRoot;
        while(i<left) {
            current = current.next;
            i++;
        }
        var preLeft = current;
        var leftNode = current.next;
        
        var stack = new Stack<ListNode>();
        while(i<=right) {
            current = current.next;
            stack.Push(current);
            i++;
        }

        preLeft.next = current;
        leftNode.next = current.next;

        while(stack.Count>0) {
            var n = stack.Pop();
            if (stack.Count>0) {
                n.next = stack.Peek();
            }
        }

        return fakeRoot.next;
    }
}

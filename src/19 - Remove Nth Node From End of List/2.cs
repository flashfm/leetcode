// Copyright (c) 2020 Alexey Filatov
// 19 - Remove Nth Node From End of List (https://leetcode.com/problems/remove-nth-node-from-end-of-list)
// Date solved: 3/14/2020 2:27:25 AM +00:00
// Memory: 24.6 MB
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head==null) return head;
        var fast = head;
        ListNode prevRemove = null;
        var i = 1;
        while(fast.next!=null) {
            fast = fast.next;
            if (i==n) prevRemove = prevRemove==null ? head : prevRemove.next; else i++;
        }
        if (prevRemove==null) return head.next;
        
        prevRemove.next = prevRemove.next?.next;
        
        return head;
    }
}

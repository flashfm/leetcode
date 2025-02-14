// Copyright (c) 2020 Alexey Filatov
// 19 - Remove Nth Node From End of List (https://leetcode.com/problems/remove-nth-node-from-end-of-list)
// Date solved: 3/14/2020 2:09:57 AM +00:00
// Memory: 24.6 MB
// Runtime: 92 ms


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
        var len = GetLen(head);
        if (len==n) return head.next;
        var t = head;
        for(var i = 0; i < len-n-1; i++) t = t.next;
        t.next = t.next?.next;
        return head;
    }
    private int GetLen(ListNode head)
    {
        for(var i=1;true;i++) {
            head = head.next;
            if (head==null) return i;
        }
    }
}

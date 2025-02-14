// Copyright (c) 2020 Alexey Filatov
// 19 - Remove Nth Node From End of List (https://leetcode.com/problems/remove-nth-node-from-end-of-list)
// Date solved: 3/14/2020 2:31:13 AM +00:00
// Memory: 24.8 MB
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
        var dummy = new ListNode(0);
        dummy.next = head;
        var fast = dummy;
        var prevRemove = dummy;
        
        for(var i=0;i<n+1;i++) fast = fast.next;
        
        while(fast!=null) {
            fast = fast.next;
            prevRemove = prevRemove.next;
        }
        prevRemove.next = prevRemove.next?.next;
        return dummy.next;
    }
}

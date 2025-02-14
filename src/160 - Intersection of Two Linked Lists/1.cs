// Copyright (c) 2020 Alexey Filatov
// 160 - Intersection of Two Linked Lists (https://leetcode.com/problems/intersection-of-two-linked-lists)
// Date solved: 1/25/2020 6:28:41 AM +00:00
// Memory: 36.1 MB
// Runtime: 192 ms


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var lenA = GetLen(headA);
        var lenB = GetLen(headB);
        while(lenA>lenB) {
            headA = headA.next;
            lenA--;
        }
        while(lenB>lenA) {
            headB = headB.next;
            lenB--;
        }
        while(headA!=headB) {
            headA = headA.next;
            headB = headB.next;
        }
        return headA;
    }
    
    private int GetLen(ListNode head) {
        var i = 0;
        while(head!=null) {
            i++;
            head = head.next;
        }
        return i;
    }
}

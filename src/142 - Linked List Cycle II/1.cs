// Copyright (c) 2024 Alexey Filatov
// 142 - Linked List Cycle II (https://leetcode.com/problems/linked-list-cycle-ii)
// Date solved: 12/10/2024 10:48:01 PM +00:00
// Memory: 44.1 MB
// Runtime: 96 ms


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if (head==null) {
            return null;
        }
        var p1 = head.next;
        var p2 = head.next?.next;
        while(p1!=p2 && p2!=null) {
            p1 = p1.next;
            p2 = p2.next?.next;
        }
        if (p2==null) {
            return null;
        }
        p1 = head;
        while(p1!=p2) {
            p1 = p1.next;
            p2 = p2.next;
        }
        return p1;
    }
}

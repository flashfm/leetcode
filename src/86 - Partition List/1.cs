// Copyright (c) 2024 Alexey Filatov
// 86 - Partition List (https://leetcode.com/problems/partition-list)
// Date solved: 9/30/2024 9:33:28 PM +00:00
// Memory: 41.6 MB
// Runtime: 68 ms


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
    public ListNode Partition(ListNode head, int x) {
        var current = head;
        var leftRoot = new ListNode(-300);
        var leftCurrent = leftRoot;
        var rightRoot = new ListNode(-300);
        var rightCurrent = rightRoot;
        while(current!=null) {
            if (current.val<x) {
                leftCurrent.next = current;
                leftCurrent = current;
            }
            else {
                rightCurrent.next = current;
                rightCurrent = current;
            }
            current = current.next;
        }
        leftCurrent.next = rightRoot.next;
        rightCurrent.next = null;
        return leftRoot.next;
    }
}

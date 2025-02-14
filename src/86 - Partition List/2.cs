// Copyright (c) 2024 Alexey Filatov
// 86 - Partition List (https://leetcode.com/problems/partition-list)
// Date solved: 9/30/2024 9:34:28 PM +00:00
// Memory: 41.2 MB
// Runtime: 63 ms


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
        var leftRoot = new ListNode(0);
        var leftCurrent = leftRoot;
        var rightRoot = new ListNode(0);
        var rightCurrent = rightRoot;
        while(current!=null) {
            if (current.val<x) {
                leftCurrent = leftCurrent.next = current;
            }
            else {
                rightCurrent = rightCurrent.next = current;
            }
            current = current.next;
        }
        leftCurrent.next = rightRoot.next;
        rightCurrent.next = null;
        return leftRoot.next;
    }
}

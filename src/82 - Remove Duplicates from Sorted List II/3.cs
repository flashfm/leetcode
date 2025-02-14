// Copyright (c) 2024 Alexey Filatov
// 82 - Remove Duplicates from Sorted List II (https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii)
// Date solved: 9/28/2024 4:29:32 AM +00:00
// Memory: 42.2 MB
// Runtime: 70 ms


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
    public ListNode DeleteDuplicates(ListNode head) {
        var fakeHead = new ListNode(0, head);
        var prev = fakeHead;
        var node = head;
        while(node!=null) {
            while(node.next!=null && node.next.val==node.val) {
                node = node.next;
            }

            if (prev.next==node) {
                prev = node;
            }
            else {
                prev.next = node.next;
            }

            node = node.next;
        }
        return fakeHead.next;
    }
}

// Copyright (c) 2020 Alexey Filatov
// 21 - Merge Two Sorted Lists (https://leetcode.com/problems/merge-two-sorted-lists)
// Date solved: 3/18/2020 4:47:26 AM +00:00
// Memory: 25.7 MB
// Runtime: 88 ms


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode head = null;
        ListNode prev = null;        
        
        while (l1!=null || l2!=null) {
            ListNode current = null;
            if (l2==null || (l1!=null && l1.val<l2.val)) {
                current = l1;
                l1 = l1.next;
            }
            else {
                current = l2;
                l2 = l2.next;
            }

            if (prev!=null) prev.next = current;
            if (head==null) head = current;
            prev = current;
        }
        
        return head;
    }
}

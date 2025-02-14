// Copyright (c) 2024 Alexey Filatov
// 24 - Swap Nodes in Pairs (https://leetcode.com/problems/swap-nodes-in-pairs)
// Date solved: 12/10/2024 7:20:01 AM +00:00
// Memory: 40.6 MB
// Runtime: 0 ms


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
    public ListNode SwapPairs(ListNode head) {
        if (head==null) {
            return null;
        }
        var n2 = head.next;
        if (n2==null) {
            return head;
        }
        var n3 = n2.next;
        n2.next = head;
        head.next = SwapPairs(n3);
        return n2;
    }
}

// Copyright (c) 2019 Alexey Filatov
// 2 - Add Two Numbers (https://leetcode.com/problems/add-two-numbers)
// Date solved: 12/21/2019 2:02:27 AM +00:00
// Memory: 26.9 MB
// Runtime: 116 ms


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var p1 = l1;
        var p2 = l2;
        var over = 0;
        ListNode head = null;
        ListNode prevNode = null;
        while(p1!=null || p2!=null) {
            var sum = (p1?.val ?? 0) + (p2?.val ?? 0) + over;
            var val = sum % 10;
            over = sum / 10;
            var node = new ListNode(val);
            if (prevNode!=null) {
                prevNode.next = node;
            }
            else {
                head = node;
            }
            prevNode = node;
            
            if (p1!=null) p1 = p1.next;
            if (p2!=null) p2 = p2.next;
        }
        if (over!=0) {
            var node = new ListNode(over);
            prevNode.next = node;
        }
        return head;
    }
}

// Copyright (c) 2020 Alexey Filatov
// 328 - Odd Even Linked List (https://leetcode.com/problems/odd-even-linked-list)
// Date solved: 1/7/2020 6:22:18 AM +00:00
// Memory: 25.6 MB
// Runtime: 108 ms


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        if (head==null) return head;
        var oddCurrent = head;
        var evenCurrent = head.next;
        var firstEven = head.next;
        var lastOdd = head;
        while(oddCurrent!=null) {
            if (oddCurrent.next!=null) {
                oddCurrent.next = oddCurrent.next.next;
            }
            lastOdd = oddCurrent;
            oddCurrent = oddCurrent.next;
            
            if (evenCurrent!=null) {
                if (evenCurrent.next!=null) {
                    evenCurrent.next = evenCurrent.next.next;
                }
                evenCurrent = evenCurrent.next;
            }
        }
        lastOdd.next = firstEven;
        return head;
    }
}

// Copyright (c) 2020 Alexey Filatov
// 908 - Middle of the Linked List (https://leetcode.com/problems/middle-of-the-linked-list)
// Date solved: 4/9/2020 6:08:49 AM +00:00
// Memory: 23.8 MB
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
    public ListNode MiddleNode(ListNode head) {
        var slow = head;
        var fast = head;
        while(fast!=null && fast.next!=null) {
            slow = slow.next;
            fast = fast.next?.next;
        }
        return slow;
    }
}

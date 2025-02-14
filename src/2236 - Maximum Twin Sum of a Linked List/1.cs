// Copyright (c) 2024 Alexey Filatov
// 2236 - Maximum Twin Sum of a Linked List (https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list)
// Date solved: 11/14/2024 11:57:12 PM +00:00
// Memory: 106.8 MB
// Runtime: 4 ms


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
    public int PairSum(ListNode head) {
        var result = 0;
        var stack = new Stack<int>();
        var fast = head;
        var slow = head;
        while(slow!=null) {
            if (fast!=null) {
                stack.Push(slow.val);
            }
            else {
                result = Math.Max(result, slow.val + stack.Pop());
            }
            fast = fast?.next?.next;
            slow = slow.next;
        }
        return result;
    }
}

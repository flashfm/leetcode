// Linked List Cycle
// https://leetcode.com/problems/linked-list-cycle
// Date solved: 03/21/2020 05:46:54 +00:00

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
    public bool HasCycle(ListNode head) {
        if (head==null) return false;
        var slow = head;
        var fast = head.next;
        while(slow!=null && fast!=null) {
            if (fast==slow) return true;
            slow = slow.next;
            fast = fast.next?.next;
        }
        return false;
    }
}

// Middle of the Linked List
// https://leetcode.com/problems/middle-of-the-linked-list
// Date solved: 04/09/2020 06:08:49 +00:00

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

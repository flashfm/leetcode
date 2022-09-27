// Reverse Linked List
// https://leetcode.com/problems/reverse-linked-list
// Date solved: 03/15/2020 05:50:52 +00:00

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head==null) return null;
        ListNode prev = null;
        var node = head;
        while(node!=null) {
            var newNode = new ListNode(node.val);
            newNode.next = prev;
            prev = newNode;
            node = node.next;
        }
        return prev;
    }
}

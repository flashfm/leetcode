// Delete Node in a Linked List
// https://leetcode.com/problems/delete-node-in-a-linked-list
// Date solved: 03/08/2020 02:00:01 +00:00

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        while(node!=null) {
            node.val = node.next.val;
            if (node.next.next==null) {
                node.next = null;
            }
            node = node.next;
        }
    }
}

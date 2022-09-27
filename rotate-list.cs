// Rotate List
// https://leetcode.com/problems/rotate-list
// Date solved: 10/07/2020 16:13:40 +00:00

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
    public ListNode RotateRight(ListNode head, int k) {
        var n = GetLen(head);
        if (n<=1) return head;
        k = k % n;
        if (k==0) return head;
        // skip n-k
        var node = head;
        for(var i=0;i<n-k-1;i++) {
            node = node.next;
        }
        var newHead = node.next;
        node.next = null;
        node = newHead;
        while(node.next!=null) {
            node = node.next;
        }
        node.next = head;
        return newHead;
    }
    private int GetLen(ListNode head)
    {
        var i = 0;
        while(head!=null) {
            i++;
            head = head.next;
        }
        return i;
    }
}

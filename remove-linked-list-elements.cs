// Remove Linked List Elements
// https://leetcode.com/problems/remove-linked-list-elements
// Date solved: 07/21/2020 05:35:58 +00:00

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
    public ListNode RemoveElements(ListNode head, int val) {
        
        if (head==null) return null;

        var tmp = new ListNode { next = head };
        var prev = tmp;
        var current = tmp.next;
        while(current!=null) {
            
            while(current!=null && current.val==val) {
                prev.next = current.next;
                current = current.next;
            }

            prev = current;
            current = current?.next;
        }
        return tmp.next;
    }
}

// Merge Two Sorted Lists
// https://leetcode.com/problems/merge-two-sorted-lists
// Date solved: 03/18/2020 04:52:57 +00:00

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        var dummy = new ListNode(0);
        var current = dummy;        
        while (l1!=null || l2!=null) {
            if (l2==null || (l1!=null && l1.val<l2.val)) {
                current.next = l1;
                l1 = l1.next;
            }
            else {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }        
        return dummy.next;
    }
}

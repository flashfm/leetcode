// Palindrome Linked List
// https://leetcode.com/problems/palindrome-linked-list
// Date solved: 03/20/2020 05:05:41 +00:00

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        var len = 0;
        var cur = head;
        while(cur!=null) {
            cur = cur.next;
            len++;
        }
        if (len==1) return true;
        cur = head;
        ListNode prev = null;
        for(var i = 0; i<len/2; i++) {
            var next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next;
        }
        var p1 = cur;
        if (len%2==1) p1 = p1.next;
        var p2 = prev;       
        while(p1!=null && p2!=null) {
            if (p1.val != p2.val) return false;
            p1 = p1.next;
            p2 = p2.next;
        }
        return p1==null && p2==null;
    }
}

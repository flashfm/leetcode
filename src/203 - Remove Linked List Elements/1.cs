// Copyright (c) 2020 Alexey Filatov
// 203 - Remove Linked List Elements (https://leetcode.com/problems/remove-linked-list-elements)
// Date solved: 7/21/2020 5:35:58 AM +00:00
// Memory: 27.9 MB
// Runtime: 136 ms


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

// Copyright (c) 2020 Alexey Filatov
// 23 - Merge k Sorted Lists (https://leetcode.com/problems/merge-k-sorted-lists)
// Date solved: 2/6/2020 7:02:51 AM +00:00
// Memory: 48.9 MB
// Runtime: 920 ms


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length==0) return null;
        var result = lists[0];
        for(var i = 1; i<lists.Length; i++) {
            result = Merge(result, lists[i]);
        }
        return result;
    }
    private ListNode Merge(ListNode list1, ListNode list2)
    {
        ListNode root = null;
        ListNode current = null;
        var a = list1;
        var b = list2;
        while(a!=null || b!=null) {
            ListNode next;
            if (b==null || (a!=null && a.val<b.val)) {
                next = a;
                a = a.next;
            }
            else {
                next = b;
                b = b.next;
            }
            var clone = new ListNode(next.val);
            if (root==null) root = clone;
            if (current!=null) current.next = clone;
            current = clone;
        }
        return root;
    }
}

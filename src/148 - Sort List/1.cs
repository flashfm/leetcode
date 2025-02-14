// Copyright (c) 2020 Alexey Filatov
// 148 - Sort List (https://leetcode.com/problems/sort-list)
// Date solved: 10/10/2020 5:47:53 PM +00:00
// Memory: 29.7 MB
// Runtime: 572 ms


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
    public ListNode SortList(ListNode head) {
        if (head==null) {
            return head;
        }
        var end = head;
        while(end.next!=null) {
            end = end.next;
        }
        Sort(head, end);
        return head;
    }
    
    private void Sort(ListNode start, ListNode end)
    {
        if (start!=end) {
            var premid = Partition(start, end);
            Sort(start, premid);
            Sort(premid.next, end);
        }
    }
    
    private ListNode Partition(ListNode start, ListNode pivot) {
        if (start==pivot) {
            return start;
        }
        var l = start;
        var prel = l;
        var r = start;
        while(r!=pivot) {
            if (r.val<pivot.val) {
                Swap(r, l);
                prel = l;
                l = l.next;
            }
            r = r.next;
        }
        Swap(l, pivot);
        
        return prel;
    }
    
    private void Swap(ListNode node1, ListNode node2)
    {
        var tmp = node1.val;
        node1.val = node2.val;
        node2.val = tmp;
    }
    
    private void Print(ListNode node)
    {
        var s = "";
        while(node!=null) {
            s += node.val + " ";
            node = node.next;
        }
        Console.WriteLine(s);
    }
}

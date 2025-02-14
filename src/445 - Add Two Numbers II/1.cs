// Copyright (c) 2020 Alexey Filatov
// 445 - Add Two Numbers II (https://leetcode.com/problems/add-two-numbers-ii)
// Date solved: 11/8/2020 7:36:59 AM +00:00
// Memory: 28.3 MB
// Runtime: 104 ms


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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var s1 = new Stack<int>();
        var s2 = new Stack<int>();
        while(l1!=null || l2!=null) {
            if (l1!=null) s1.Push(l1.val);
            if (l2!=null) s2.Push(l2.val);
            l1 = l1?.next;
            l2 = l2?.next;
        }
        var s3 = new Stack<int>();
        var over = 0;
        while(s1.Count>0 || s2.Count>0) {
            var a = s1.Count>0 ? s1.Pop() : 0;
            var b = s2.Count>0 ? s2.Pop() : 0;
            var x = a+b+over;
            over = 0;
            if (x>=10) {
                x-=10;
                over = 1;
            }
            s3.Push(x);
        }
        if (over==1) {
            s3.Push(1);
        }
        var tmp = new ListNode();
        var prev = tmp;
        while(s3.Count>0) {
            var n = new ListNode(s3.Pop());
            prev.next = n;
            prev = n;
        }
        return tmp.next;
    }
}

// Sort List
// https://leetcode.com/problems/sort-list
// Date solved: 10/12/2020 07:01:09 +00:00

public class Solution {
    public ListNode SortList(ListNode head) {
        if (head==null) {
            return head;
        }
        var len = 1;    
        var l1 = head;
        var l2 = head.next;
        while(l2!=null) {
            ListNode prevListEnd = null;
            do {
                var nextl1 = l1;
                var nextl2 = l2;
                for(var i = 0; i<len*2 && nextl1!=null; i++) {
                    nextl1 = nextl1.next;
                    nextl2 = nextl2?.next;
                }

                var (subHead, subEnd) = Merge(l1, l2, len);
                if (l1==head) {
                    head = subHead;
                }

                l1 = nextl1;
                l2 = nextl2;

                if (prevListEnd!=null) {
                    prevListEnd.next = subHead;
                }
                prevListEnd = subEnd;
            }
            while (l1!=null);

            prevListEnd.next = null;
            
            len *= 2;
            l1 = head;
            l2 = head;          
            for(var i = 0; i<len; i++) {
                l2 = l2?.next;
            }
        }
        return head;
    }
    private (ListNode, ListNode) Merge(ListNode l1, ListNode l2, int len)
    {
        var len1 = 0;
        var len2 = 0;
        var tmp = new ListNode();
        var head = tmp;
        while(true) {
            if ((len1==len || l1==null) && (len2==len || l2==null)) {
                break;
            }
            if (len1<len && (l2==null || len2==len || l1.val<l2.val)) {
                head.next = l1;
                l1 = l1.next;
                len1++;
            }
            else {
                head.next = l2;
                l2 = l2.next;
                len2++;
            }            
            head = head.next;
        }
        return (tmp.next, head);
    }
    public static void Print(ListNode node)
    {
        while (node!=null) {
            Console.Write(node.val + " ");
            node = node.next;
        }
        Console.WriteLine();
    }
}

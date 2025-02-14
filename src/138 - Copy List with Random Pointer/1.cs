// Copyright (c) 2020 Alexey Filatov
// 138 - Copy List with Random Pointer (https://leetcode.com/problems/copy-list-with-random-pointer)
// Date solved: 10/7/2020 5:00:26 PM +00:00
// Memory: 25.8 MB
// Runtime: 84 ms


/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        var tmp = new Node(0);
        var preRoot = tmp;
        var dict = new Dictionary<Node, Node>();
        var node = head;
        while(node!=null) {
            var clone = new Node(node.val);
            tmp.next = clone;
            tmp = clone;
            dict[node] = clone;
            node = node.next;
        }
        node = head;
        while(node!=null) {
            var clone = dict[node];
            clone.random = node.random==null ? null : dict[node.random];
            node = node.next;
        }
        return preRoot.next;
    }
}

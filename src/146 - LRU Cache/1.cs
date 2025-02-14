// Copyright (c) 2020 Alexey Filatov
// 146 - LRU Cache (https://leetcode.com/problems/lru-cache)
// Date solved: 10/8/2020 4:22:09 AM +00:00
// Memory: 49.6 MB
// Runtime: 228 ms


public class LRUCache {

    private Dictionary<int, Node> dict;
    private Node head = null;
    private Node tail = null;
    private int capacity;
    
    public LRUCache(int capacity) {
        this.capacity = capacity;
        dict = new Dictionary<int, Node>(capacity);
    }
    
    public int Get(int key) {
        if (!dict.TryGetValue(key, out var node)) {
            return -1;
        }
        Update(node);
        return node.val;
    }
    
    public void Put(int key, int value) {
        if (!dict.TryGetValue(key, out var node)) {
            if (dict.Count==capacity) {
                Evict(tail);
            }
            node = new Node {
                key = key
            };
            dict[key] = node;
        }
        node.val = value;
        Update(node);
    }
    
    private void Update(Node node)
    {
        if (node==head) {
            return;
        }
        Remove(node);
        node.next = head;
        if (head!=null) {
            head.prev = node;
        }
        head = node;
        if (tail==null) {
            tail = node;
        }
    }
    
    private void Evict(Node node)
    {
        if (node==null) {
            return;
        }
        dict.Remove(node.key);
        Remove(node);
    }
    
    private void Remove(Node node)
    {
        if (node==null) {
            return;
        }
        if (node==tail) {
            tail = node.prev;
        }
        if (node==head) {
            head = node.next;
        }
        if (node.prev!=null) {
            node.prev.next = node.next;
        }
        if (node.next!=null) {
            node.next.prev = node.prev;
        }
        node.prev = null;
        node.next = null;
    }
    
    public class Node
    {
        public int key;
        public int val;
        public Node next;
        public Node prev;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */

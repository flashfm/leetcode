// Copyright (c) 2020 Alexey Filatov
// 155 - Min Stack (https://leetcode.com/problems/min-stack)
// Date solved: 3/16/2020 7:35:08 AM +00:00
// Memory: 34.8 MB
// Runtime: 136 ms


public class MinStack {

    private Stack<int> s = new Stack<int>();
    private Stack<int> mins = new Stack<int>();
    /** initialize your data structure here. */
    public MinStack() {
        
    }
    
    public void Push(int x) {
        s.Push(x);
        if (mins.Count==0 || x<=GetMin()) mins.Push(x);
    }
    
    public void Pop() {
        var top = s.Pop();
        if (top==GetMin()) mins.Pop();        
    }
    
    public int Top() {
        return s.Peek();
    }
    
    public int GetMin() {
        return mins.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */

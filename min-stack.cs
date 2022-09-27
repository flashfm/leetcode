// Min Stack
// https://leetcode.com/problems/min-stack
// Date solved: 03/16/2020 07:37:33 +00:00

public class MinStack {

    private Stack<int> s = new Stack<int>();
    private Stack<int> mins = new Stack<int>();
    /** initialize your data structure here. */
    public MinStack() {
        
    }
    
    public void Push(int x) {
        s.Push(x);
        mins.Push(mins.Count==0 || x<=GetMin() ? x : GetMin());
    }
    
    public void Pop() {
        s.Pop();
        mins.Pop();        
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

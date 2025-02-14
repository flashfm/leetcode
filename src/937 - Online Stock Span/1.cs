// Copyright (c) 2024 Alexey Filatov
// 937 - Online Stock Span (https://leetcode.com/problems/online-stock-span)
// Date solved: 11/29/2024 7:54:57 PM +00:00
// Memory: 75.7 MB
// Runtime: 7 ms


public class StockSpanner {
    Stack<(int Val, int Count)> stack = new(); // Count of numbers <= Val
    public StockSpanner() {
        
    }
    
    public int Next(int price) {
        var n = 1;
        while(stack.Count>0 && stack.Peek().Val<=price) {
            n += stack.Pop().Count;
        }
        stack.Push((price, n));
        return n;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */

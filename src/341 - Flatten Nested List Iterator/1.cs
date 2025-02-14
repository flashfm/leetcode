// Copyright (c) 2022 Alexey Filatov
// 341 - Flatten Nested List Iterator (https://leetcode.com/problems/flatten-nested-list-iterator)
// Date solved: 10/11/2022 9:10:50 PM +00:00
// Memory: 42.5 MB
// Runtime: 185 ms


/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {
    private class Pair
    {
        public IList<NestedInteger> List;
        public int Pos;
    }

    private Stack<Pair> stack = new();

    public NestedIterator(IList<NestedInteger> nestedList) {
        if (nestedList.Count==0) return;
        stack.Push(new Pair { List = nestedList, Pos = 0 });
        expandToNumber();
    }

    public bool HasNext() {
        popEmpty();
        return stack.Any();
    }

    public int Next() {
        // 1. get number
        var pair = stack.Peek();
        var value = pair.List[pair.Pos];        

        // 2. reduce to next and expand to number
        pair.Pos++;
        popEmpty();
        expandToNumber();
        return value.GetInteger();
    }

    private void expandToNumber()
    {
        if (stack.Count==0) return;
        var pair = stack.Peek();
        while(pair!=null && !pair.List[pair.Pos].IsInteger()) {            
            var list = pair.List[pair.Pos].GetList();
            pair.Pos++;
            if (list.Count!=0) {
                stack.Push(new Pair { List = list, Pos = 0 });
            }
            else {
                popEmpty();
            }
            pair = stack.Count == 0 ? null : stack.Peek();
        }
    }

    private void popEmpty()
    {
        if (stack.Count==0) return;
        var pair = stack.Peek();
        while(pair!=null && pair.Pos==pair.List.Count) {
            stack.Pop();
            pair = stack.Count == 0 ? null : stack.Peek();
        }
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */

// Copyright (c) 2024 Alexey Filatov
// 216 - Combination Sum III (https://leetcode.com/problems/combination-sum-iii)
// Date solved: 11/22/2024 8:16:08 AM +00:00
// Memory: 38 MB
// Runtime: 1 ms


public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var result = new List<IList<int>>();
        var nums = new Stack<int>();
        Dfs(1, n);
        return result;

        void Dfs(int start, int n)
        {
            if (n<0) {
                return;
            }
            if (nums.Count==k && n==0) {
                result.Add(nums.ToArray());
                return;
            }
            for(var i = start; i<=9; i++) {
                nums.Push(i);
                Dfs(i+1, n-i);
                nums.Pop();
            }
        }
    }
}

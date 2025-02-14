// Copyright (c) 2024 Alexey Filatov
// 216 - Combination Sum III (https://leetcode.com/problems/combination-sum-iii)
// Date solved: 11/22/2024 8:10:54 AM +00:00
// Memory: 38.3 MB
// Runtime: 1 ms


public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var result = new List<IList<int>>();
        var nums = new Stack<int>();
        Dfs();
        return result;

        void Dfs()
        {
            for(var i = 1; i<=9; i++) {
                if (i<=n && (nums.Count==0 || i>nums.Peek())) {
                    nums.Push(i);
                    n -= i;
                    if (nums.Count==k) {
                        if (n==0) {
                            result.Add(nums.ToArray());
                        }
                    }
                    else if (n>0) {
                        Dfs();
                    }
                    nums.Pop();
                    n += i;
                }
            }
        }
    }
}

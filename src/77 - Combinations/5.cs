// Copyright (c) 2024 Alexey Filatov
// 77 - Combinations (https://leetcode.com/problems/combinations)
// Date solved: 10/9/2024 12:13:34 AM +00:00
// Memory: 140 MB
// Runtime: 354 ms


public class Solution {
    private List<IList<int>> result = new();
    private int n;
    private int k;

    public IList<IList<int>> Combine(int n, int k) {
        this.n = n;
        this.k = k;
        Dfs(new List<int>(k), 0);
        return result;
    }

    private void Dfs(List<int> current, int prev)
    {
        if (current.Count==k) {
            result.Add(current.ToArray());
        }
        while (current.Count<k && prev < n) {
            prev = prev+1;
            current.Add(prev);
            Dfs(current, prev);
        }
        if (current.Count>0) {
            current.RemoveAt(current.Count-1);
        }
    }
}

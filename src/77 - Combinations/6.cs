// Copyright (c) 2024 Alexey Filatov
// 77 - Combinations (https://leetcode.com/problems/combinations)
// Date solved: 10/9/2024 12:14:49 AM +00:00
// Memory: 140.3 MB
// Runtime: 359 ms


public class Solution {
    private List<IList<int>> result = new();
    private int n;
    private int k;
    private List<int> current;

    public IList<IList<int>> Combine(int n, int k) {
        this.n = n;
        this.k = k;
        current = new List<int>(k);
        Dfs(0);
        return result;
    }

    private void Dfs(int prev)
    {
        if (current.Count==k) {
            result.Add(current.ToArray());
        }
        while (current.Count<k && prev < n) {
            prev = prev+1;
            current.Add(prev);
            Dfs(prev);
        }
        if (current.Count>0) {
            current.RemoveAt(current.Count-1);
        }
    }
}

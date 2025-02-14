// Copyright (c) 2024 Alexey Filatov
// 77 - Combinations (https://leetcode.com/problems/combinations)
// Date solved: 10/9/2024 5:43:02 AM +00:00
// Memory: 140.5 MB
// Runtime: 340 ms


public class Solution {
    private List<IList<int>> result = new();
    private int n;
    private int k;
    private int[] current;
    private int i;

    public IList<IList<int>> Combine(int n, int k) {
        this.n = n;
        this.k = k;
        current = new int[k];
        Dfs(0);
        return result;
    }

    private void Dfs(int prev)
    {
        if (i==k) {
            result.Add(current.ToArray());
        }
        while (i<k && prev<n) {
            prev++;
            current[i++] = prev;
            Dfs(prev);
            i--;
        }
    }
}

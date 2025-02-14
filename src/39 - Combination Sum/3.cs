// Copyright (c) 2024 Alexey Filatov
// 39 - Combination Sum (https://leetcode.com/problems/combination-sum)
// Date solved: 10/9/2024 5:48:23 AM +00:00
// Memory: 46.7 MB
// Runtime: 108 ms


public class Solution {
    private List<IList<int>> result = new();
    private List<int> current = new();
    private int[] candidates;
    private int target;

    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        this.candidates = candidates;
        this.target = target;
        Array.Sort(candidates);
        Dfs(0, 0);
        return result;
    }

    private void Dfs(int sum, int startIndex)
    {
        for(var i = startIndex; i<candidates.Length; i++) {
            var c = candidates[i];
            if (c>target) {
                break;
            }
            sum += c;
            if (sum<=target) {                
                current.Add(c);
                if (sum==target) {
                   result.Add(current.ToArray());
                }
                else {
                    Dfs(sum, i);
                }
                current.RemoveAt(current.Count-1);
            }
            sum -= c;
        }
    }
}

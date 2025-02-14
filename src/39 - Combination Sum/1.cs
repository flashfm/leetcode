// Copyright (c) 2024 Alexey Filatov
// 39 - Combination Sum (https://leetcode.com/problems/combination-sum)
// Date solved: 10/9/2024 5:39:00 AM +00:00
// Memory: 46.7 MB
// Runtime: 111 ms


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
        //Console.WriteLine(string.Join(",", current));
        if (sum==target) {
            result.Add(current.ToArray());
        }
        var i = startIndex;
        while(i<candidates.Length) {
            var c = candidates[i];
            if (c>target) {
                break;
            }
            if (sum+c<=target) {
                sum += c;
                current.Add(c);
                Dfs(sum, i);
                sum -= c;
                i++;
            }
            else {
                i++;
            }
        }
        if (current.Count>0) {
            current.RemoveAt(current.Count-1);
        }
    }
}

// Copyright (c) 2020 Alexey Filatov
// 47 - Permutations II (https://leetcode.com/problems/permutations-ii)
// Date solved: 11/13/2020 8:42:28 AM +00:00
// Memory: 34 MB
// Runtime: 252 ms


public class Solution {
    private int[][] arr;
    private int n;
    private IList<IList<int>> result = new List<IList<int>>();
    private Stack<int> stack = new Stack<int>();
    public IList<IList<int>> PermuteUnique(int[] nums) {
        n = nums.Length;
        var dict = new Dictionary<int, int>();
        foreach(var num in nums) {
            dict.TryGetValue(num, out var count);
            dict[num] = count+1;
        }
        // array of [number, count]
        arr = dict.Select(p => new[] {p.Key,p.Value}).ToArray();
        Forward();
        return result;
    }
    private void Forward()
    {
        foreach(var pair in arr) {
            if (pair[1]==0) {
                continue;
            }
            //Console.WriteLine(string.Join(",",stack));
            pair[1]--;
            stack.Push(pair[0]);
            if (stack.Count==n) {
                result.Add(stack.ToArray());
            }
            else {
                Forward();
            }
            stack.Pop();
            pair[1]++;
        }
    }
}

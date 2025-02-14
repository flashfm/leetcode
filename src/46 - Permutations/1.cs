// Copyright (c) 2020 Alexey Filatov
// 46 - Permutations (https://leetcode.com/problems/permutations)
// Date solved: 1/28/2020 4:36:28 AM +00:00
// Memory: 31.8 MB
// Runtime: 236 ms


public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var avail = new HashSet<int>(nums);
        var arr = new int[nums.Length];
        var results = new List<IList<int>>();
        Permute(arr, avail, 0, results);
        return results;
    }
    private void Permute(int[] arr, HashSet<int> avail, int pos, List<IList<int>> results)
    {
        foreach(var x in avail.ToArray()) {
            arr[pos] = x;
            if (pos==arr.Length-1) {
                results.Add((int[])arr.Clone());
            }
            else {
                avail.Remove(x);
                Permute(arr, avail, pos+1, results);
                avail.Add(x);
            }
        }
    }
}

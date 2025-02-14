// Copyright (c) 2024 Alexey Filatov
// 120 - Triangle (https://leetcode.com/problems/triangle)
// Date solved: 10/15/2024 3:38:52 AM +00:00
// Memory: 42.6 MB
// Runtime: 89 ms


public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int[] prevPath = new int[] {0};
        for(var r = 0; r<triangle.Count; r++) {
            var path = triangle[r].ToArray();
            for(var i = 0; i<path.Length; i++) {
                path[i] += Math.Min(
                    i<prevPath.Length ? prevPath[i] : int.MaxValue,
                    i>0 ? prevPath[i-1] : int.MaxValue);
            }
            prevPath = path;
        }
        return prevPath.Min();
    }
}

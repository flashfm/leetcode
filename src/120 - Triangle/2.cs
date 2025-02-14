// Copyright (c) 2024 Alexey Filatov
// 120 - Triangle (https://leetcode.com/problems/triangle)
// Date solved: 10/15/2024 3:42:27 AM +00:00
// Memory: 42.5 MB
// Runtime: 74 ms


public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        for(var r = 1; r<triangle.Count; r++) {
            var path = triangle[r];
            for(var i = 0; i<path.Count; i++) {
                var prevPath = triangle[r-1];
                path[i] += Math.Min(
                    i<prevPath.Count ? prevPath[i] : int.MaxValue,
                    i>0 ? prevPath[i-1] : int.MaxValue);
            }
        }
        return triangle[triangle.Count-1].Min();
    }
}

// Copyright (c) 2024 Alexey Filatov
// 149 - Max Points on a Line (https://leetcode.com/problems/max-points-on-a-line)
// Date solved: 10/15/2024 2:49:13 AM +00:00
// Memory: 62.8 MB
// Runtime: 81 ms


public class Solution {
    public int MaxPoints(int[][] points) {
        if (points.Length==1) {
            return 1;
        }
        var pointsByLine = new Dictionary<(double, double), HashSet<(int, int)>>();
        for(var i = 0; i<points.Length; i++) {
            var xi = points[i][0];
            var yi = points[i][1];
            for(var j = 0; j<i; j++) {
                var xj = points[j][0];
                var yj = points[j][1];
                var a = xi==xj ? double.MaxValue : ((double)(yi-yj))/(xi-xj);
                var b = xi==xj ? xi : yi - xi*a;
                var list = (pointsByLine.GetValueOrDefault((a,b)) ?? (pointsByLine[(a,b)] = new HashSet<(int, int)>()));
                list.Add((xi, yi));
                list.Add((xj, yj));
            }
        }
        var max = 0;
        foreach(var list in pointsByLine.Values) {
            max = Math.Max(max, list.Count);
        }
        return max;
    }
}

// Copyright (c) 2020 Alexey Filatov
// 593 - Valid Square (https://leetcode.com/problems/valid-square)
// Date solved: 11/13/2020 9:36:16 AM +00:00
// Memory: 28 MB
// Runtime: 100 ms


/*

    
             
    *
    |
    |
*---0---*
    |
    |
    *
*/
public class Solution {
    public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4) {
        var points = (new[] {p1,p2,p3,p4}).OrderBy(p=>p[0]).ToArray();
        var left = points[0];
        var right = points[3];
        if (left[0]==points[1][0] && left[1]==right[1]) {
            right = points[2];
        }
        var rest = points.Where(p=>p!=left && p!=right).ToArray();
        var l1 = GetLen(left,rest[0]);
        if (l1==0) return false;
        var l2 = GetLen(left,rest[1]);
        if (l1!=l2) return false;
        var l3 = GetLen(right,rest[0]);
        if (l1!=l3) return false;
        var l4 = GetLen(right,rest[1]);
        if (l1!=l4) return false;
        
        return GetDotProd(left, rest[0], left, rest[1]) == 0;
    }
    private int GetLen(int[] a, int[] b)
    {
        var x = a[0]-b[0];
        var y = a[1]-b[1];
        return x*x + y*y;
    }
    private int GetDotProd(int[] a1, int[] a2, int[] b1, int[] b2)
    {
        return (a2[0]-a1[0]) * (b2[0]-b1[0]) +
            (a2[1]-a1[1]) * (b2[1]-b1[1]);
    }
}

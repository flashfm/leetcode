// Copyright (c) 2020 Alexey Filatov
// 593 - Valid Square (https://leetcode.com/problems/valid-square)
// Date solved: 11/13/2020 9:35:33 AM +00:00
// Memory: 27.6 MB
// Runtime: 92 ms


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
        
        return IsOrt(left, rest[0], left, rest[1]);
        //var dotProd = GetDotProd(left, rest[0], left, rest[1]);
        /*
        Console.WriteLine(string.Join(",", left));
        Console.WriteLine(string.Join(",", right));
        Console.WriteLine(string.Join(",", rest[0]));
        Console.WriteLine(string.Join(",", rest[1]));
        Console.WriteLine(l1);
        Console.WriteLine(l2);
        Console.WriteLine(l3);
        Console.WriteLine(l4);
        Console.WriteLine(dotProd);
        */
        //return dotProd==0;
    }
    private int GetLen(int[] a, int[] b)
    {
        var x = a[0]-b[0];
        var y = a[1]-b[1];
        return x*x + y*y;
    }
    private bool IsOrt(int[] a1, int[] a2, int[] b1, int[] b2)
    {
        return (a2[0]-a1[0]) * (b2[0]-b1[0]) ==
            -(a2[1]-a1[1]) * (b2[1]-b1[1]);
    }
    private int GetDotProd(int[] a1, int[] a2, int[] b1, int[] b2)
    {
        return (a2[0]-a1[0]) * (b2[0]-b1[0]) +
            (a2[1]-a1[1]) * (b2[1]-b1[1]);
    }
}

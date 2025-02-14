// Copyright (c) 2020 Alexey Filatov
// 1049 - Minimum Domino Rotations For Equal Row (https://leetcode.com/problems/minimum-domino-rotations-for-equal-row)
// Date solved: 10/20/2020 7:18:48 AM +00:00
// Memory: 45.4 MB
// Runtime: 276 ms


// if we already have a set
// we get (a,b)
// we could keep (a) so all top are a or all bottom are b
// we could rotate once so all top are b or all bottom are a
// or we cannot (-1)

//2  -> 2 or 5
//5

//1  no rotat - loss because 1 is not 2 or 5, or 1 rotat => just 2 now
//2

// 2 -> 2 or 3
// 3

//3  -> 2 or 3, +1 rotat
//2

//3 2 2 2 2 3 
//2 3 3 3 3 2

// => we decreasing set of 2 numbers maybe to 1 number and count number of rotations?

public class Solution {
    public int MinDominoRotations(int[] A, int[] B) {
        var n = A.Length;
        if (n<=1) {
            return 0;
        }
        var count = 2;
        var result = 0;
        var x = A[0];
        var y = B[0];
        for(var i=1; i<n;i++) {
            var a = A[i];
            var b = B[i];
            if ((a==x && b==y) || (a==y && b==x)) {
            }
            else if (a==x || a==y) {
                count = 1;
                x = a;
                y = 0;
            }
            else if (b==x || b==y) {
                count = 1;
                x = b;
                y = 0;
            }
            else {
                return -1;
            }
        }
        if (count==2) {
            var turnToA = A.Count(n => n!=A[0]);
            var turnToB = A.Count(n => n!=B[0]);
            result = Math.Min(turnToA, turnToB);
        }
        else {
            var turnToA = A.Count(n => n!=x);
            var turnToB = B.Count(n => n!=x);
            result = Math.Min(turnToA, turnToB);
        }
        return result;
    }
}

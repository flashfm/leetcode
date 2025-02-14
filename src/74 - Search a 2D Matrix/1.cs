// Copyright (c) 2020 Alexey Filatov
// 74 - Search a 2D Matrix (https://leetcode.com/problems/search-a-2d-matrix)
// Date solved: 10/16/2020 5:43:56 PM +00:00
// Memory: 25.6 MB
// Runtime: 96 ms


public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var n = matrix.Length;
        if (n==0) {
            return false;
        }
        var m = matrix[0].Length;
        var l = 0;
        var r = m*n-1;
        while(l<=r) {
            var mid = (l+r)/2;
            var cand = matrix[mid/m][mid%m];
            //Console.WriteLine($"{l}, {r}, {cand}");
            if (cand==target) {
                return true;
            }
            else if (target<cand) {
                r = mid-1;
            }
            else {
                l = mid+1;
            }
        }
        return false;
    }
}

// Copyright (c) 2024 Alexey Filatov
// 374 - Guess Number Higher or Lower (https://leetcode.com/problems/guess-number-higher-or-lower)
// Date solved: 11/22/2024 7:25:45 AM +00:00
// Memory: 26.5 MB
// Runtime: 16 ms


/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        var l = 1;
        var r = n;
        while(l<=r) {
            var m = l + (r-l)/2;
            var g = guess(m);
            if (g==0) {
                return m;
            }
            else if (g<0) {
                r = m-1;
            }
            else {
                l = m+1;
            }
        }
        return 0;
    }
}

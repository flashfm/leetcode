// Single Number
// https://leetcode.com/problems/single-number
// Date solved: 04/02/2020 05:45:23 +00:00

public class Solution {
    public int SingleNumber(int[] nums) {
        var r = 0;
        foreach(var n in nums) r ^= n;
        return r;
    }
}

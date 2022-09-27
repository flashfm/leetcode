// Increasing Triplet Subsequence
// https://leetcode.com/problems/increasing-triplet-subsequence
// Date solved: 01/29/2020 07:44:16 +00:00

public class Solution {
    public bool IncreasingTriplet(int[] nums)
    {
        var min = int.MaxValue;
        var secondMin = int.MaxValue;
        foreach(var n in nums) {
            if (n<=min) {
                min = n;
            }
            else if (n<secondMin) {
                secondMin = n;
            }
            else if (n>secondMin) { return true; }
        }
        return false;
    }
}

// First Missing Positive
// https://leetcode.com/problems/first-missing-positive
// Date solved: 11/13/2020 23:56:05 +00:00

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        var hash = new HashSet<int>(nums);
        var i=1;
        for(;i<=nums.Length;i++) {
            if (!hash.Contains(i)) {
                return i;
            }
        }
        return i;
    }
}

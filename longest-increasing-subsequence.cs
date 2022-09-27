// Longest Increasing Subsequence
// https://leetcode.com/problems/longest-increasing-subsequence
// Date solved: 12/28/2019 21:38:26 +00:00

public class Solution {
    public int LengthOfLIS(int[] nums) {
        var n = nums.Length;
        if (n==0) return 0;
        var len = 0;
        var seq = new int[n];
        for(var i=0;i<n;i++) {
            
            var j = Array.BinarySearch(seq, 0, len, nums[i]);
            
            if (j<0) {
                j = ~j;
                seq[j] = nums[i];
                if (j>=len) {
                    len++;
                }
            }
            
        }
        return len;
    }
}

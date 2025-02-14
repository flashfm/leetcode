// Copyright (c) 2024 Alexey Filatov
// 416 - Partition Equal Subset Sum (https://leetcode.com/problems/partition-equal-subset-sum)
// Date solved: 12/9/2024 6:46:49 PM +00:00
// Memory: 50.5 MB
// Runtime: 57 ms


public class Solution {
    public bool CanPartition(int[] nums) {
        var n = nums.Length;
        var sum = nums.Sum();
        if (sum%2==1) {
            return false;
        }
        var target = sum / 2;
        var dp = new bool[n, target+1]; // can we build J on number of index I
        for(var i=0; i<n; i++) {
            for(var j=0; j<=target; j++) {
                dp[i, j] = nums[i]==j || (i-1>=0 && dp[i-1, j]) || (i-1>=0 && j-nums[i]>=0 && dp[i-1, j-nums[i]]);
            }
        }

        return dp[n-1, target];
    }
}

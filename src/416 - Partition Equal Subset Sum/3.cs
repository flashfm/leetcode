// Copyright (c) 2024 Alexey Filatov
// 416 - Partition Equal Subset Sum (https://leetcode.com/problems/partition-equal-subset-sum)
// Date solved: 12/10/2024 5:39:38 AM +00:00
// Memory: 44.7 MB
// Runtime: 26 ms


public class Solution {
    public bool CanPartition(int[] nums) {
        var n = nums.Length;
        var sum = nums.Sum();
        if (sum%2==1) {
            return false;
        }
        var target = sum / 2;
        var dp = new bool[target+1]; // can we build J on number of index I
        var prevDp = new bool[target+1];
        for(var i=0; i<n; i++) {
            for(var j=0; j<=target; j++) {
                dp[j] = nums[i]==j || prevDp[j] || (j-nums[i]>=0 && prevDp[j-nums[i]]);
            }
            (prevDp, dp) = (dp, prevDp);
        }

        return dp[target];
    }
}

// Copyright (c) 2024 Alexey Filatov
// 416 - Partition Equal Subset Sum (https://leetcode.com/problems/partition-equal-subset-sum)
// Date solved: 12/10/2024 5:45:38 AM +00:00
// Memory: 44 MB
// Runtime: 25 ms


public class Solution {
    public bool CanPartition(int[] nums) {
        var n = nums.Length;
        var sum = nums.Sum();
        if (sum%2==1) {
            return false;
        }
        var target = sum / 2;
        var dp = new bool[target+1]; // can we build J on number of index I
        for(var i=0; i<n; i++) {
            for(var j=target; j>=0; j--) {
                dp[j] = nums[i]==j || dp[j] || (j-nums[i]>=0 && dp[j-nums[i]]);
            }
        }

        return dp[target];
    }
}

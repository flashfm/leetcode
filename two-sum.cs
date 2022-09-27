// Two Sum
// https://leetcode.com/problems/two-sum
// Date solved: 05/29/2020 17:31:13 +00:00

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        for(var i=0;i<nums.Length;i++) {
            dict[nums[i]] = i; 
        }
        for(var i=0;i<nums.Length;i++) {
            var d = target - nums[i];
            if (dict.TryGetValue(d, out var j) && j!=i) {
                return new[] {i,j};
            }
        }
        return new int[0];
    }
}

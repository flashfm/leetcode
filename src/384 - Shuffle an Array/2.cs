// Copyright (c) 2020 Alexey Filatov
// 384 - Shuffle an Array (https://leetcode.com/problems/shuffle-an-array)
// Date solved: 3/11/2020 5:20:51 AM +00:00
// Memory: 50.2 MB
// Runtime: 444 ms


public class Solution {

    private int[] orig;
    
    public Solution(int[] nums) {
        this.orig = nums;
    }
    
    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        return orig;
    }
    
    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        var nums = (int[])orig.Clone();
        var result = new int[nums.Length];
        var random = new Random();
        for(var i = 0; i<nums.Length; i++) {
            var j = random.Next(nums.Length-i);
            result[i] = nums[j];
            
            nums[j] = nums[nums.Length-i-1];
        }
        return result;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */

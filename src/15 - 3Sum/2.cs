// Copyright (c) 2019 Alexey Filatov
// 15 - 3Sum (https://leetcode.com/problems/3sum)
// Date solved: 12/9/2019 7:03:38 AM +00:00
// Memory: 34.8 MB
// Runtime: 408 ms


public class Solution {
  public IList<IList<int>> ThreeSum(int[] nums) {
    
    Array.Sort(nums);
    
    var result = new List<IList<int>>();
    
    var maxPosByNum = new Dictionary<int, int>();
    for(var i=0;i<nums.Length;i++) {
      maxPosByNum[nums[i]] = i;
    }
        
    for(var i=0;i<nums.Length;i++) {
      
      if (i>0 && nums[i-1]==nums[i]) {
        continue;
      }
      
      for(var j=i+1;j<nums.Length;j++) {
        
        if (j!=i+1 && nums[j]==nums[j-1]) {
          continue;
        }
        
        var a = nums[i];
        var b = nums[j];
        var c = -(a + b);
        if (maxPosByNum.TryGetValue(c, out var pos) && pos>j) {
          result.Add(new List<int> { a, b, c });
        }
        
      }
    }
    return result;
  }
}

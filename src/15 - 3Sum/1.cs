// Copyright (c) 2019 Alexey Filatov
// 15 - 3Sum (https://leetcode.com/problems/3sum)
// Date solved: 12/9/2019 6:56:44 AM +00:00
// Memory: 152.2 MB
// Runtime: 1000 ms


public class Solution {
  public IList<IList<int>> ThreeSum(int[] nums) {
    
    Array.Sort(nums);
    
    var result = new List<IList<int>>();
    
    HashSet<int>[] numsSetAfter = new HashSet<int>[nums.Length];
    for(var i=0;i<nums.Length;i++) {
      numsSetAfter[i] = new HashSet<int>();
      for(var j=i+1;j<nums.Length;j++) {
        numsSetAfter[i].Add(nums[j]);
      }
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
        var numsSet = numsSetAfter[j];        
        if (numsSet.Contains(c)) {
          result.Add(new List<int> { a, b, c });
        }
        
      }
    }
    return result;
  }
}

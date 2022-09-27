// 3Sum
// https://leetcode.com/problems/3sum
// Date solved: 12/09/2019 07:28:12 +00:00

public class Solution {
  public IList<IList<int>> ThreeSum(int[] nums) {
    
    Array.Sort(nums);
    
    var result = new List<IList<int>>();
        
    for(var i=0;i<nums.Length-2;i++) {
      
      if (i>0 && nums[i-1]==nums[i]) {
        continue;
      }
      
      var c = -nums[i];    
      var l = i+1;
      var r = nums.Length-1;
      while(l<r) {
        var sum = nums[l] + nums[r];
        if (sum==c) {
          result.Add(new List<int> { nums[i], nums[l], nums[r] });
          while(l<r && nums[l]==nums[l+1]) l++;
          while(l<r && nums[r]==nums[r-1]) r--;
          l++;
          r--;
        }
        else if (sum<c) {
          l++;
        }
        else {
          r--;
        }
      }
    }
    return result;
  }
}

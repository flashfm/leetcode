// Subsets
// https://leetcode.com/problems/subsets
// Date solved: 01/30/2020 06:21:04 +00:00

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();
        if (nums.Length==0) return result;
        
        var used = new bool[nums.Length];
        var i = 0;
        do {
            result.Add(Gen(nums, used));
            i = 0;
            var overflow = false;
            do {
                overflow = used[i];
                used[i] = !used[i];
                if (overflow) {
                    i++;
                }
            } while(overflow && i<nums.Length);
        } while (i<nums.Length);
        return result;
    }
    
    private IList<int> Gen(int[] nums, bool[] used)
    {
        var list = new List<int>();
        for(var i=0;i<nums.Length;i++) {
            if (used[i]) {
                list.Add(nums[i]);
            }
        }
        return list;
    }
}

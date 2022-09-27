// Majority Element II
// https://leetcode.com/problems/majority-element-ii
// Date solved: 09/25/2020 08:11:29 +00:00

public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        var len = nums.Length;
        if (len==0) {
            return new int[0];
        }
        var dict = new Dictionary<int, int>();
        foreach(var n in nums) {
            dict.TryGetValue(n, out var count);
            dict[n] = count + 1;
            if (dict.Count==3) {
                foreach(var key in dict.Keys.ToList()) {
                    var v = dict[key];
                    if (v==1) {
                        dict.Remove(key);
                    }
                    else {
                        dict[key] = v-1;
                    }
                }
            }
        }
        return dict.Keys.Where(n => nums.Count(x => x==n)>len/3).ToList();
    }
}

// Single Number III
// https://leetcode.com/problems/single-number-iii
// Date solved: 07/25/2020 05:24:49 +00:00

public class Solution {
    public int[] SingleNumber(int[] nums) {
        var hashset = new HashSet<int>(nums.Length);
        foreach(var n in nums) {
            if (hashset.Contains(n)) {
                hashset.Remove(n);
            }
            else {
                hashset.Add(n);
            }
        }
        return hashset.ToArray();
    }
}

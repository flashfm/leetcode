// Contains Duplicate
// https://leetcode.com/problems/contains-duplicate
// Date solved: 03/17/2020 07:03:41 +00:00

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var hashSet = new HashSet<int>();
        foreach(var n in nums) {
            if (hashSet.Contains(n)) return true;
            hashSet.Add(n);
        }
        return false;
    }
}

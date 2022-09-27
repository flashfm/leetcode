// K-diff Pairs in an Array
// https://leetcode.com/problems/k-diff-pairs-in-an-array
// Date solved: 10/03/2020 23:31:00 +00:00

public class Solution {
    public int FindPairs(int[] nums, int k) {
        var result = 0;
        var countByNum = new Dictionary<int, int>();
        foreach(var n in nums) {
            countByNum.TryGetValue(n, out var count);
            countByNum[n] = count+1;
        }
        
        foreach(var (n,c) in countByNum) {
            if ((k>0 && countByNum.ContainsKey(n+k)) || (k==0 && c>1)) {
                result++;
            }
        }
        
        return result;
    }
}

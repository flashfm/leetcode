// Counting Elements
// https://leetcode.com/problems/counting-elements
// Date solved: 04/09/2020 06:03:48 +00:00

public class Solution {
    public int CountElements(int[] arr) {
        var set = arr.ToHashSet();
        var count = 0;
        foreach(var a in arr) {
            if (set.Contains(a+1)) {
                count++;
            }
        }
        return count;
    }
}

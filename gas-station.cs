// Gas Station
// https://leetcode.com/problems/gas-station
// Date solved: 09/25/2020 05:47:19 +00:00

public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        var n = gas.Length;
        var start = 0;
        var end = 0;
        var rem = 0;
        while(start<n) {
            if (rem<0) {
                rem -= (gas[start] - cost[start]);
                start++;
                if (end<start) {
                    end = start;
                }
            }
            else {
                rem += gas[end % n] - cost[end % n];
                end++;
                if (end % n==start) {
                    return rem>=0 ? start : -1;
                }
            }
        }
        return -1;
    }
}

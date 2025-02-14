// Copyright (c) 2024 Alexey Filatov
// 2330 - Maximum Total Beauty of the Gardens (https://leetcode.com/problems/maximum-total-beauty-of-the-gardens)
// Date solved: 11/7/2024 11:12:42 PM +00:00
// Memory: 65.7 MB
// Runtime: 227 ms


public class Solution {
    public long MaximumBeauty(int[] flowers, long newFlowers, int target, int full, int partial) {
        var initiallyComplete = flowers.Count(f => f >= target);
        flowers = flowers.Where(f => f < target).OrderBy(f => f).ToArray();
        var n = flowers.Length;

        var prefSum = new long[n+1];
        for(var i = 0; i<n; i++) {
            prefSum[i+1] = prefSum[i] + flowers[i];
        }

        long result = 0;

        for(int fullGardens = 0; fullGardens<=n; fullGardens++) {
            var remainingFlowers = newFlowers;
            if (fullGardens>0) {
                // look at as a rectangle with sizes fullGardens x target
                var flowersToComplete = ((long)target * fullGardens) - (prefSum[n] - prefSum[n-fullGardens]);
                if (flowersToComplete > newFlowers) {
                    break;
                }
                remainingFlowers = newFlowers - flowersToComplete;
            }

            long min = 0;
            if (fullGardens<n) {
                // find new "min" using binary search
                int l = 0;
                int r = target-1;
                while(l<r) {
                    var m = (l + r + 1)/2;

                    // view required flowers as rectangle with sides m and (n - fullGardens)
                    // however some of flowers can be higher than m and so we cannot use prefSum directly
                    // using binary search we find a position of the first flower that is less than m

                    var idx = Array.BinarySearch(flowers, 0, n - fullGardens, m);
                    if (idx<0) {
                        idx = ~idx;
                    }

                    var flowersForMin = (long)m * idx - prefSum[idx];

                    if (flowersForMin<=remainingFlowers) {
                        l = m;
                    }
                    else {
                        r = m-1;
                    }
                }
                min = l;
            }

            var cost = (long)(fullGardens + initiallyComplete) * full + min * partial;
            result = Math.Max(result, cost);
        }

        return result;
    }
}

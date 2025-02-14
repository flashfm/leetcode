// Copyright (c) 2019 Alexey Filatov
// 322 - Coin Change (https://leetcode.com/problems/coin-change)
// Date solved: 12/25/2019 10:44:13 PM +00:00
// Memory: 26.6 MB
// Runtime: 116 ms


public class Solution {
    
    public int CoinChange(int[] coins, int amount) {
        if (amount==0) {
            return 0;
        }
        var IMPOSSIBLE = amount+1;
        var memo = new int[amount+1];
        
        for(var i=0;i<memo.Length;i++) memo[i] = IMPOSSIBLE;        
        memo[0] = 0;
        
        for(var i=0;i<=amount;i++) {
            foreach(var c in coins) {
                if (i-c>=0) {
                    memo[i] = Math.Min(memo[i], memo[i-c]+1);
                }
            }
        }
                
        var result = memo[amount];
        return result==IMPOSSIBLE ? -1 : result;
    }        
}

// Copyright (c) 2019 Alexey Filatov
// 322 - Coin Change (https://leetcode.com/problems/coin-change)
// Date solved: 12/25/2019 8:52:15 AM +00:00
// Memory: 26.7 MB
// Runtime: 136 ms


public class Solution {
    
    const int IMPOSSIBLE = int.MaxValue;

    public int CoinChange(int[] coins, int amount) {
        if (amount==0) {
            return 0;
        }
        var memo = new int[amount+1];
        
        // coins = [1, 2, 5], amount = 11
        // можно ли собрать 10 (взяли 1 по 1)
        // можно ли собрать 9 (взяли 1 по 2)
        // можно ли собрать 6 (взяли 1 по 5)
        
        // мемо - массив - кол-во монет используемых чтоб собрать i
        var result = GetNum(coins, amount, memo);
        return result==IMPOSSIBLE ? -1 : result;
    }
        
    private int GetNum(int[] coins, int amount, int[] memo) {
        int bestNum = IMPOSSIBLE;
        if (memo[amount]!=0) return memo[amount];
        foreach(var c in coins) {
            if (c<amount) {
                var remNum = GetNum(coins, amount-c, memo);
                if (remNum!=IMPOSSIBLE) {
                    bestNum = Math.Min(bestNum, 1 + remNum);
                }
            }
            else if (c==amount) {
                bestNum = Math.Min(1, bestNum);
            }
        }
        memo[amount] = bestNum;
        return bestNum;
    }
}

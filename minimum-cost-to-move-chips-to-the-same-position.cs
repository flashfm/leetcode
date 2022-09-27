// Minimum Cost to Move Chips to The Same Position
// https://leetcode.com/problems/minimum-cost-to-move-chips-to-the-same-position
// Date solved: 11/07/2020 08:43:32 +00:00

/*
bruteforce: for each target position, calculate number of steps per chip and sum,
then find minimum
what do we repeat? calculation of steps per chip
we can calculate in advance per chip number of steps to do if to move to position
problem again - when enumerating, we have to sum number of steps 

tip: move to 0 or +-2 is no cost, but move to +-1 is with cost of 1
move chip to any position is cost of 0 or 1,
if it's in even distance then 0, if it's in odd distance then 1

if chip is on odd position then move to any odd is 0 and to any even is 1
if  --------- even ----------------------- even is 0 ----------- odd is 1

when enumerating all positions, the sum will be either sum1 or sum2 depending on odd/even
except when we hit one of the initial positions - then N of chips on it is removed from sum1 or sum2
no need to enumerate then - calculate sum1, sum2 and go through all positions and deduct and get minimum

dp?: if we have X-1 positions, and everything is already calculated
we add Xth position with N chips on it
for X-1 we know all costs of moving existing chips to any position up to X
a) calculate price of all moving to N
b) calculate price of Xth moving to current
c) can be more optimal with moving all to some Yth?

[2,3,3]
    *
  * *
0 1 2

*/

public class Solution {
    public int MinCostToMoveChips(int[] position) {        
        var chipsByPos = new Dictionary<int, int>();
        foreach(var pos in position) {
            var pos0 = pos-1;
            chipsByPos.TryGetValue(pos0, out var count);
            chipsByPos[pos0] = count+1;
        }        
        var sumEven = CalcSum(0, chipsByPos);
        var sumOdd = CalcSum(1, chipsByPos);
        return Math.Min(sumEven, sumOdd);
    }
    private int CalcSum(int rem, Dictionary<int, int> chipsByPos)
    {
        var sum = 0;
        foreach(var (pos, chips) in chipsByPos) {
            if (pos%2!=rem) {
                sum += chips;
            }
        }
        return sum;
    }
}

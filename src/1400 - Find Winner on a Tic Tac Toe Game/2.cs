// Copyright (c) 2024 Alexey Filatov
// 1400 - Find Winner on a Tic Tac Toe Game (https://leetcode.com/problems/find-winner-on-a-tic-tac-toe-game)
// Date solved: 12/18/2024 12:17:21 AM +00:00
// Memory: 42 MB
// Runtime: 1 ms


public class Solution {
    public string Tictactoe(int[][] moves) {
        var field = new int[3,3];
        var p = 1;
        foreach(var move in moves) {
            field[move[0], move[1]] = p;
            p = p==1 ? 2 : 1;
        }
        if (Check(1)) {
            return "A";
        }
        else if (Check(2)) {
            return "B";
        }
        else if (moves.Length<9) {
            return "Pending";
        }
        else {
            return "Draw";
        }

        bool Check(int t)
        {
            for(var r = 0; r<3; r++) {
                if (
                    (field[r, 0]==t && field[r, 1]==t && field[r, 2]==t) ||
                    (field[0, r]==t && field[1, r]==t && field[2, r]==t)) {
                    return true;
                }
            }
            if ((field[0, 0]==t && field[1, 1]==t && field[2, 2]==t) ||
                (field[0, 2]==t && field[1, 1]==t && field[2, 0]==t)) {
                return true;
            }
            return false;
        }
    }
}
